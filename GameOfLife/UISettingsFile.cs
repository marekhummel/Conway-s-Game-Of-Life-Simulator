using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using GameOfLife.UI;

namespace GameOfLife
{
    public class UISettingsFile
    {

		public UISettingsFile(FieldOfLifeUI.GridStyles gs, FieldOfLifeUI.CellStyles cf, int dis, int spc,
			Color bcol, Color gcol, Color lcol, Color hcol)
		{
			this.GridStyle = gs;
			this.CellStyle = cf;
			this.Distance = dis;
			this.BackgroundColor = bcol;
			this.GridColor = gcol;
			this.LivingColor = lcol;
			this.HoverColor = hcol;
			this.SizePerCell = spc;
		}

		public UI.FieldOfLifeUI.GridStyles GridStyle { get; set; }
		public FieldOfLifeUI.CellStyles CellStyle { get; set; }
		public int Distance { get; set; }
		public Color BackgroundColor { get; set; }
		public Color GridColor {get; set;}
		public Color LivingColor { get; set; }
		public Color HoverColor { get; set; }
		public int SizePerCell { get; set; }

    }
}
