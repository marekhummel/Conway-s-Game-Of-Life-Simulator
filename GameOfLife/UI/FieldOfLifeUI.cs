using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameOfLife.UI {
    public class FieldOfLifeUI : System.Windows.Forms.Panel
    {
		public int gridoffset;

        public FieldOfLifeUI()
        {
            this.DoubleBuffered = true;

           //The properties
			Attributes.AmountOfCellsPerLine = 32;

            this.BackgroundColor = Color.FromArgb(40, 40, 40);
            this.GridColor = Color.FromArgb(75, 75, 75);
            this.LivingCellColor = Color.LightBlue;
            this.HoverColor = Color.FromArgb(127, Color.Orange);

            this.CellStyle = FieldOfLifeUI.CellStyles.Square;
            this.CellFigureDistance = 1;
            this.GridStyle = FieldOfLifeUI.GridStyles.Continuous;

            this.InputEnabled = true;
        }


		public int SizePerCell { get { 	return (int)((this.Width -1) / Attributes.AmountOfCellsPerLine);	} }

        public bool InputEnabled { get; set; }

        public GridStyles GridStyle { get; set; }
        public enum GridStyles
        {
            Continuous,
            Dotted,
            BrokenLines,
            OnlyEdges,
            Empty
        }

        public CellStyles CellStyle { get; set; }
        public enum CellStyles
        {
            Square,
            Circle
        }
        public int CellFigureDistance { get; set; }

        public Color BackgroundColor { get; set; }
        public Color GridColor { get; set; }
        public Color LivingCellColor { get; set; }
        public Color HoverColor { get; set; }

        public InputModes InputMode;
        public enum InputModes
        {
            Toggle,
            Activated,
            Deactivated
        }


        //***********************************

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            DrawOnGfx(e.Graphics);
        }

        public void DrawOnGfx(Graphics egfx) //ref
        {
            egfx.CompositingQuality = CompositingQuality.HighQuality;

            //Draw the grid
            gridoffset = (this.Width - (Attributes.AmountOfCellsPerLine * this.SizePerCell + 1)) / 2;
            int realsize = Attributes.AmountOfCellsPerLine * this.SizePerCell + 1;

            Bitmap gridtexture = new Bitmap(this.SizePerCell, this.SizePerCell);
            Pen p;
            using (Graphics gfx = Graphics.FromImage(gridtexture)) {
                gfx.Clear(this.BackgroundColor);
                switch (this.GridStyle) {
                    case (FieldOfLifeUI.GridStyles.Continuous):
                        gfx.DrawRectangle(new Pen(this.GridColor), 0, 0, this.SizePerCell, this.SizePerCell);
                        break;
                    case (FieldOfLifeUI.GridStyles.BrokenLines):
                        float[] dp = { (float)(this.SizePerCell / 4), (float)(this.SizePerCell / 4), (float)(this.SizePerCell / 8), (float)(this.SizePerCell / 4), (float)(this.SizePerCell / 8) };
                        p = new Pen(this.GridColor) { DashPattern = dp };
                        gfx.DrawRectangle(p, 0, 0, this.SizePerCell, this.SizePerCell);
                        break;
                    case (FieldOfLifeUI.GridStyles.Dotted):
                        p = new Pen(this.GridColor) {DashPattern = new float[]{1,1}};
                        break;
                    case (FieldOfLifeUI.GridStyles.OnlyEdges):
                        gfx.DrawRectangle(new Pen(this.GridColor), 0, 0, 1, 1);
                        gfx.DrawRectangle(new Pen(this.GridColor), 0, this.SizePerCell, 1, 1);
                        gfx.DrawRectangle(new Pen(this.GridColor), this.SizePerCell, 0, 1, 1);
                        gfx.DrawRectangle(new Pen(this.GridColor), this.SizePerCell, this.SizePerCell, 1, 1);
                        break;
                    case (FieldOfLifeUI.GridStyles.Empty):
                        //Nothing
                        break;
                }
			}

            //Draw the background
            TextureBrush tb = new TextureBrush(gridtexture);
            tb.TranslateTransform(gridoffset, gridoffset);

            egfx.FillRectangle(new SolidBrush(this.BackgroundColor), 0, 0, this.Width, this.Height);
            if (this.GridStyle == GridStyles.OnlyEdges)
            {
                egfx.FillRectangle(tb, gridoffset, gridoffset, realsize + 1, realsize + 1);
            }
            else
            {
                egfx.FillRectangle(tb, gridoffset, gridoffset, realsize, realsize);
            }


			egfx.InterpolationMode = InterpolationMode.HighQualityBilinear;
			egfx.PixelOffsetMode = PixelOffsetMode.HighQuality;
			egfx.SmoothingMode = SmoothingMode.HighQuality;

			//Draw the (living) cells
			if (Attributes.Cells != null)
			{
				for(int y = 0; y <= Attributes.Cells.GetLength(0) - 1; y++) 
				{
					for (int x = 0; x <= Attributes.Cells.GetLength(0) - 1; x++)
					{
						if (Attributes.IsCellAlive(x, y))
						{
							if (this.CellStyle == CellStyles.Circle)
							{
								egfx.FillEllipse(new SolidBrush(this.LivingCellColor), IndexToRect(x, y,this.CellFigureDistance));
							}
							else if (this.CellStyle == CellStyles.Square)
							{
								egfx.FillRectangle(new SolidBrush(this.LivingCellColor), IndexToRect(x, y, this.CellFigureDistance));
							}
						}
					}
				}
			}

			//Draw the hover sign
			if (IsMouseInField(ActualMouseLocation))
			{
				if (this.CellStyle == CellStyles.Circle)
				{
					egfx.FillEllipse(new SolidBrush(this.HoverColor), IndexToRect(PointToIndex(ActualMouseLocation), this.CellFigureDistance));
				}
				else if (this.CellStyle == CellStyles.Square)
				{
					egfx.FillRectangle(new SolidBrush(this.HoverColor), IndexToRect(PointToIndex(ActualMouseLocation), this.CellFigureDistance));
				}
			}
            
        }



		// Activate + Deactivate cells

		private Point ActualMouseLocation = new Point(-10, -10);
		private Point LastMouseLocation = new Point(-10, -10);
		private Point LastMouseClickLocation = new Point(-10, -10);
		private bool IsMouseDown;

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);

			if (IsMouseDown && IsMouseInField(e.Location))
			{
				ChangeCell(e);
				LastMouseClickLocation = e.Location;
			}

			LastMouseLocation = ActualMouseLocation;
			ActualMouseLocation = e.Location;
			this.Invalidate(IndexToRect(PointToIndex(ActualMouseLocation), 0));
			this.Invalidate(IndexToRect(PointToIndex(LastMouseLocation), 0));
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);

			if (IsMouseInField(e.Location))
				ChangeCell(e);

			IsMouseDown = true;
			LastMouseClickLocation = e.Location;
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);

			IsMouseDown = false;
			LastMouseClickLocation = new Point(-10, -10);
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);

			this.Invalidate(IndexToRect(PointToIndex(ActualMouseLocation), 0));
			this.Invalidate(IndexToRect(PointToIndex(LastMouseLocation), 0));
			ActualMouseLocation = new Point(-10, -10);
			
		}




		// Methods

		public void ChangeCell(MouseEventArgs e) 
		{
			if (this.InputEnabled)
			{
				Point loc = e.Location;
				if((PointToIndex(loc).Item1 != PointToIndex(LastMouseClickLocation).Item1) ||
					(PointToIndex(loc).Item2 != PointToIndex(LastMouseClickLocation).Item2))
				{
					int index1 = PointToIndex(loc).Item1;
					int index2 = PointToIndex(loc).Item2;

					switch (this.InputMode)
					{
						case InputModes.Toggle :
							Attributes.SetCellLife(index1, index2, !Attributes.IsCellAlive(index1, index2));
							break;
						case InputModes.Activated :
							Attributes.SetCellLife(index1, index2, true);
							break;
						case InputModes.Deactivated :
							Attributes.SetCellLife(index1, index2, false);
							break;
					}

					this.Invalidate(IndexToRect(PointToIndex(loc), 2));
				}
			}
		}


		private Point GetRealLocation(Point loc)
		{
			return new Point(loc.X - gridoffset, loc.Y - gridoffset);
		}

		private Tuple<int, int> PointToIndex(Point pt)
		{
			if (IsMouseInField(pt))
			{
				Point realloc = GetRealLocation(pt);

				int i1 = realloc.X / this.SizePerCell;
				int i2 = realloc.Y / this.SizePerCell;

				return new Tuple<int, int>(i1, i2);
			}
			else
			{
				return new Tuple<int, int>(-1, -1);
			}
		}

		private Rectangle IndexToRect(Tuple<int, int> index, int offset)
		{
			return IndexToRect(index.Item1, index.Item2, offset);
		}
		private Rectangle IndexToRect(int i1, int i2, int offset)
		{
			return new Rectangle(i1 * this.SizePerCell + offset + gridoffset, i2 * this.SizePerCell + offset + gridoffset, this.SizePerCell - 2 * offset + 1, this.SizePerCell - 2 * offset + 1);
		}


		private bool IsMouseInField(Point pt)
		{
			return new Rectangle(gridoffset, gridoffset, this.Width - 2* gridoffset - 1, this.Height - 2* gridoffset - 1).IntersectsWith(new Rectangle(pt, new Size(0,0)));
		}

    }
}
