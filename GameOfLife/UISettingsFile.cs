using GameOfLife.UI;

namespace GameOfLife
{
    public class UISettingsFile
    {

        public UISettingsFile(FieldOfLifeUI.GridStyles gs, FieldOfLifeUI.CellStyles cf, int dis, int spc,
            Color bcol, Color gcol, Color lcol, Color hcol)
        {
            GridStyle = gs;
            CellStyle = cf;
            Distance = dis;
            BackgroundColor = bcol;
            GridColor = gcol;
            LivingColor = lcol;
            HoverColor = hcol;
            SizePerCell = spc;
        }

        public UI.FieldOfLifeUI.GridStyles GridStyle { get; set; }
        public FieldOfLifeUI.CellStyles CellStyle { get; set; }
        public int Distance { get; set; }
        public Color BackgroundColor { get; set; }
        public Color GridColor { get; set; }
        public Color LivingColor { get; set; }
        public Color HoverColor { get; set; }
        public int SizePerCell { get; set; }

    }
}
