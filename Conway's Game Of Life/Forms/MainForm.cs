using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace GameOfLife
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
			Attributes.CellListChanged += new Attributes.EmptyEventHandler(this.CellsDiffer);
			Attributes.NewGenCalculated += new Attributes.NewGenCalculatedEventHandler((bool[,] cells, bool IsNext) => this.NewGenCalculated(cells, IsNext));
		}

		private Size screensize = Screen.PrimaryScreen.Bounds.Size;

		private int borderright;
		private int borderbottom;

		//Form Load + Close
        private void MainForm_Load(object sender, EventArgs e)
        {
			//Load settings
			if (!System.IO.File.Exists(settingspath))
				SaveSettings(true);

			LoadSettings();


			//Set size
			this.MinimumSize = this.Size;
			borderright = this.Width - (this.TheFieldOfLife.Location.X + this.TheFieldOfLife.Width);
			borderbottom = this.Height - (this.TheFieldOfLife.Location.Y + this.TheFieldOfLife.Height);


			//Set input mode
			rb_toggle.Checked = true;

			//Refresh GUI
			CellsDiffer();
			this.Text += "  --  vers. " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." +
				System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString();

			//(new Forms.LoadForm()).ShowDialog();
			//this.Close();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Attributes.IsActive)
				Attributes.AbortAnimation();

			SaveSettings(false);
		}

		private string settingspath = Path.Combine(Attributes.SettingsDirectory, "settings.ini"); 
		private void LoadSettings()
		{

			Queue<string> settings = new Queue<string>();
			using (System.IO.StreamReader sr = new System.IO.StreamReader(settingspath))
			{
				while (sr.Peek() > -1)
				{
					settings.Enqueue(sr.ReadLine());
				}
			}


			try
			{
				Attributes.AmountOfCellsPerLine = int.Parse(settings.Dequeue());
				Attributes.Cells = Attributes.EmptyCells;

				this.TheFieldOfLife.BackgroundColor = Color.FromArgb(int.Parse(settings.Dequeue()));
				this.TheFieldOfLife.GridColor = Color.FromArgb(int.Parse(settings.Dequeue()));
				this.TheFieldOfLife.LivingCellColor = Color.FromArgb(int.Parse(settings.Dequeue()));
				this.TheFieldOfLife.HoverColor = Color.FromArgb(int.Parse(settings.Dequeue()));

				this.TheFieldOfLife.CellStyle = (UI.FieldOfLifeUI.CellStyles)System.Enum.Parse(Type.GetType(typeof(UI.FieldOfLifeUI.CellStyles).FullName), settings.Dequeue());
				this.TheFieldOfLife.CellFigureDistance = int.Parse(settings.Dequeue());
				this.TheFieldOfLife.GridStyle = (UI.FieldOfLifeUI.GridStyles)System.Enum.Parse(Type.GetType(typeof(UI.FieldOfLifeUI.GridStyles).FullName), settings.Dequeue());

				Attributes.Refreshrate = int.Parse(settings.Dequeue());
				Attributes.TorusActivated = bool.Parse(settings.Dequeue());
				Attributes.RuleToSurvive = settings.Dequeue();
				Attributes.RuleToBeBorn = settings.Dequeue();
			}
			catch
			{
				MessageBox.Show("This is not good");
			}
		}

		private void SaveSettings(bool def)
		{
			if (!Directory.Exists((new FileInfo(settingspath)).DirectoryName))
				Directory.CreateDirectory((new FileInfo(settingspath)).DirectoryName);

			using (StreamWriter sw = new StreamWriter(new FileStream(settingspath, FileMode.Create, FileAccess.Write)))
			{
				sw.WriteLine(Attributes.AmountOfCellsPerLine.ToString());

				sw.WriteLine(this.TheFieldOfLife.BackgroundColor.ToArgb().ToString());
				sw.WriteLine(this.TheFieldOfLife.GridColor.ToArgb().ToString());
				sw.WriteLine(this.TheFieldOfLife.LivingCellColor.ToArgb().ToString());
				sw.WriteLine(this.TheFieldOfLife.HoverColor.ToArgb().ToString());

				sw.WriteLine(this.TheFieldOfLife.CellStyle.ToString());
				sw.WriteLine(this.TheFieldOfLife.CellFigureDistance.ToString());
				sw.WriteLine(this.TheFieldOfLife.GridStyle.ToString());

				if (!def)
				{
					sw.WriteLine(Attributes.Refreshrate.ToString());
					sw.WriteLine(Attributes.TorusActivated.ToString());
					sw.WriteLine(Attributes.RuleToSurvive.ToString());
					sw.WriteLine(Attributes.RuleToBeBorn.ToString());
				}
				else
				{
					sw.WriteLine("100");
					sw.WriteLine("false");
					sw.WriteLine("23");
					sw.WriteLine("3");
				}
			}
		}


		//Buttons
		private Forms.RandomCellsForm randcellsfrm;
		private Forms.LoadForm loadfrm;
		private Forms.SaveForm savefrm;
		private Forms.SettingsForm settfrm;

		private void btn_clear_Click(object sender, EventArgs e)
		{
			Attributes.Generation = 0;
			Attributes.Cells = Attributes.EmptyCells;
			Attributes.CurrentCellStack.Clear();
			this.TheFieldOfLife.Invalidate();
		}

		private void btn_random_Click(object sender, EventArgs e)
		{
			randcellsfrm = new Forms.RandomCellsForm();

			//Center the randomcellsform on the mainform
			randcellsfrm.Location = new Point((int)(this.Location.X + ((this.Width - randcellsfrm.Width) / 2)),
				(int)(this.Location.Y + ((this.Height - randcellsfrm.Height) / 2)));

			if (randcellsfrm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Attributes.Generation = 0;
				Attributes.Cells = Attributes.RandomCells((double)randcellsfrm.Destiny.Value);
				this.TheFieldOfLife.Invalidate();
			}
		}

		private void btn_load_Click(object sender, EventArgs e)
		{
			loadfrm = new Forms.LoadForm();

			//Center the loadform on the mainform
			loadfrm.Location = new Point((int)(this.Location.X + ((this.Width - loadfrm.Width) / 2)),
				(int)(this.Location.Y + ((this.Height - loadfrm.Height) / 2)));

			loadfrm.ShowDialog();
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			if (Attributes.CurrentCellStack.Count > 0)
			{
				savefrm = new Forms.SaveForm();

				//Deliver the Attributes
				savefrm.AFieldOfLife = this.TheFieldOfLife;

				//Center the randomcellsform on the mainform
				savefrm.Location = new Point((int)(this.Location.X + ((this.Width - savefrm.Width) / 2)),
					(int)(this.Location.Y + ((this.Height - savefrm.Height) / 2)));

				savefrm.ShowDialog();
			}
		}

		private void btn_settings_Click(object sender, EventArgs e)
		{
			settfrm = new Forms.SettingsForm();

			//Add the settings
			UISettingsFile setts = new UISettingsFile(this.TheFieldOfLife.GridStyle, this.TheFieldOfLife.CellStyle, this.TheFieldOfLife.CellFigureDistance, this.TheFieldOfLife.SizePerCell, 
				this.TheFieldOfLife.BackgroundColor, this.TheFieldOfLife.GridColor, this.TheFieldOfLife.LivingCellColor, this.TheFieldOfLife.HoverColor);
			settfrm.UISettings = setts;

			//Center the settings form on the mainform
			settfrm.Location = new Point((int)(this.Location.X + ((this.Width - settfrm.Width) / 2)),
				(int)(this.Location.Y + ((this.Height - settfrm.Height) / 2)));

			settfrm.UISettingsChanged += new Forms.SettingsForm.EmptyEventHandler(this.settfrm_UISettingsChanged);

			settfrm.ShowDialog();
		}


		//Gets handled when the Cells change
		private void settfrm_UISettingsChanged()
		{
			this.TheFieldOfLife.GridStyle = settfrm.UISettings.GridStyle;
			this.TheFieldOfLife.CellStyle = settfrm.UISettings.CellStyle;
			this.TheFieldOfLife.CellFigureDistance = settfrm.UISettings.Distance;
			this.TheFieldOfLife.BackgroundColor = settfrm.UISettings.BackgroundColor;
			this.TheFieldOfLife.GridColor = settfrm.UISettings.GridColor;
			this.TheFieldOfLife.LivingCellColor = settfrm.UISettings.LivingColor;
			this.TheFieldOfLife.HoverColor = settfrm.UISettings.HoverColor;

			this.TheFieldOfLife.Invalidate();
		}


		//Toggle inputmode
		private void InputMode_CheckedChanged(object sender, EventArgs e)
		{
			if (rb_toggle.Checked)
			{
				this.TheFieldOfLife.InputMode = UI.FieldOfLifeUI.InputModes.Toggle;
			}
			else if (rb_activate.Checked)
			{
				this.TheFieldOfLife.InputMode = UI.FieldOfLifeUI.InputModes.Activated;
			}
			else if (rb_deactivate.Checked)
			{
				this.TheFieldOfLife.InputMode = UI.FieldOfLifeUI.InputModes.Deactivated;
			}

		}


		//Gets handled when the Cells change
		private void CellsDiffer()
		{
			if (this.InvokeRequired)
			{
				this.Invoke(new Action(() =>
				{
					this.lbl_value_gen.Text = Attributes.Generation.ToString();
					this.lbl_value_living.Text = Attributes.AmountOfLivingCells.ToString();
					this.lbl_value_total.Text = Attributes.AmountOfTotalCells.ToString();
					this.lbl_value_destiny.Text = (Math.Round(Attributes.Destiny * 100, 2)).ToString() + "%";
				}));
			}
			else
			{
				this.lbl_value_gen.Text = Attributes.Generation.ToString();
				this.lbl_value_living.Text = Attributes.AmountOfLivingCells.ToString();
				this.lbl_value_total.Text = Attributes.AmountOfTotalCells.ToString();
				this.lbl_value_destiny.Text = (Math.Round(Attributes.Destiny * 100, 2)).ToString() + "%";
			}

		}





		// ***** The animation *****
		private System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(Attributes.StartAnimation));
	
		//Toggle animating
		private void btn_runtoggle_Click(object sender, EventArgs e)
		{
			if (Attributes.Cells != null)
			{
				//Update controls
				//this.btn_load.Enabled = !this.btn_load.Enabled;
				this.btn_clear.Enabled = !this.btn_clear.Enabled;
				this.btn_random.Enabled = !this.btn_random.Enabled;
				this.btn_settings.Enabled = !this.btn_settings.Enabled;
				this.btn_save.Enabled = !this.btn_save.Enabled;
				this.rb_toggle.Enabled = !this.rb_toggle.Enabled;

				this.rb_activate.Enabled = !this.rb_activate.Enabled;
				this.rb_deactivate.Enabled = !this.rb_deactivate.Enabled;
				this.lbl_inputmode.Enabled = !this.lbl_inputmode.Enabled;

				if (!Attributes.IsActive)
				{
					thread = new System.Threading.Thread(new System.Threading.ThreadStart(Attributes.StartAnimation));
					thread.Start();

					this.btn_runtoggle.Text = "Stop";
					this.TheFieldOfLife.InputEnabled = false;
				}
				else 
				{
					thread.Abort();
					Attributes.AbortAnimation();
					this.btn_runtoggle.Text = "Run";
					this.TheFieldOfLife.InputEnabled = true;
				}
			}
		}

		//Do one step
		private void btn_next_Click(object sender, EventArgs e)
		{
			Attributes.CalculateNextGen();
		}

		//Undo last step
		private void btn_previous_Click(object sender, EventArgs e)
		{
			Attributes.CalculatePreviousGen();
		}

		//Gets handled when the Cells change while the animation is active
		private void NewGenCalculated(bool[,] cells, bool IsNext)
		{
			Attributes.Cells = cells;
			Attributes.CurrentCellStack.Push(cells);
			this.TheFieldOfLife.Invalidate();
			if (IsNext)
				Attributes.Generation++;
			else
				Attributes.Generation--;
			this.Invoke(new Action(() => lbl_value_gen.Text = Attributes.Generation.ToString()));
		}





		//Resize
		private const int WM_WINDOWPOSCHANGING = 0x46;

		[System.Diagnostics.DebuggerStepThrough()]
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == WM_WINDOWPOSCHANGING)
			{
				WINDOWPOS wp = new WINDOWPOS();
				wp = (WINDOWPOS)(Marshal.PtrToStructure(m.LParam, typeof(WINDOWPOS)));

				if (wp.cx > 0 && borderright > 0 && borderbottom > 0)
				{
					wp.cy = (int)(wp.cx - borderright + borderbottom);
					this.TheFieldOfLife.Size = new Size(wp.cx - borderright - this.TheFieldOfLife.Location.X, wp.cy - borderbottom - this.TheFieldOfLife.Location.Y);
					this.TheFieldOfLife.Invalidate();

					Marshal.StructureToPtr(wp, m.LParam, true);
				}
			}

			base.WndProc(ref m);
		}

		[StructLayout(LayoutKind.Sequential)]
		public struct WINDOWPOS
		{
			public IntPtr hwnd;
			public IntPtr hwndInsertAfter;
			public int x;
			public int y;
			public int cx;
			public int cy;
			public int flags;
		}

    }
}
