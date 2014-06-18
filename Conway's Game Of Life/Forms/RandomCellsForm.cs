using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GameOfLife.Forms
{
	public partial class RandomCellsForm : Form
	{
		public RandomCellsForm()
		{
			InitializeComponent();

			this.AcceptButton = btn_ok;
			this.CancelButton = btn_cancel;
			btn_ok.DialogResult = DialogResult.OK;
			btn_cancel.DialogResult = DialogResult.Cancel;
		}
	}
}
