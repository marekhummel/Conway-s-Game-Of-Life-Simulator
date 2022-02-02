namespace GameOfLife.Forms
{
    public partial class RandomCellsForm : Form
    {
        public RandomCellsForm()
        {
            InitializeComponent();

            AcceptButton = btn_ok;
            CancelButton = btn_cancel;
            btn_ok.DialogResult = DialogResult.OK;
            btn_cancel.DialogResult = DialogResult.Cancel;
        }
    }
}
