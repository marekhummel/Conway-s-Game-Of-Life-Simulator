using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;

namespace GameOfLife.UI
{
	public partial class RuleButtonRow : System.Windows.Forms.Control
	{

		private bool[] Active = new bool[9];

		public string Rule
		{
			get 
			{ 
				string ret = string.Empty;
				for (int i = 0; i <= 8; i++)
				{
					if (this.Active[i])
						ret += i.ToString();
				}
				return ret;
			}
			set
			{
				this.Active = new bool[9];
				foreach (char c in value)
				{
					this.Active[int.Parse(c.ToString())] = true;
				}
				this.Invalidate();
			}
		}

		//Draw
		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
			base.OnPaint(e);

			e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
			e.Graphics.CompositingQuality = CompositingQuality.HighQuality;


			Rectangle rect = new Rectangle(0, 0, 20, 20);


			for (int i = 0; i <= 8; i++)
			{
				//The background (depending on status)
				Pen p;
				Brush brsh;
				if (!this.Rule.Contains(i.ToString()))
				{
					brsh = new SolidBrush(Color.LightBlue);
					p = Pens.DarkGray;
				}
				else
				{
					brsh = new SolidBrush(Color.Blue);
					p = Pens.Black;
				}
				e.Graphics.FillRectangle(brsh, rect);
				e.Graphics.DrawRectangle(p, rect);


				//Text
				SizeF sz = new SizeF(e.Graphics.MeasureString(i.ToString(), this.Font));
				e.Graphics.DrawString(i.ToString(), this.Font, Brushes.White, rect.X + (rect.Width - sz.Width) / 2, rect.Y + (rect.Height - sz.Height) / 2);

				rect.Offset(rect.Width + 4, 0);
			}
		}


		//Handle clicks
		protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseDown(e);

			int x = e.X;

			if ((int)(x % (20 + 4)) <= 20)
			{
				int clickedbutton = (int)(x / (20 + 4));

				this.Active[clickedbutton] = !this.Active[clickedbutton];
				this.Invalidate(new Rectangle(clickedbutton * 24,0,20,20));
			}
		}

		//Disallow resizes
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			if (this.Size != new System.Drawing.Size(213, 22))
				this.Size = new System.Drawing.Size(213, 22);
		}

	}
}
