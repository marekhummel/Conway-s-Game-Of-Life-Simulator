using System.IO;
using System.Runtime.InteropServices;

namespace GameOfLife
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Attributes.CellListChanged += new Attributes.EmptyEventHandler(CellsDiffer);
            Attributes.NewGenCalculated += new Attributes.NewGenCalculatedEventHandler((bool[,] cells, bool IsNext) => NewGenCalculated(cells, IsNext));
        }

        private Size screensize = Screen.PrimaryScreen.Bounds.Size;

        private int borderright;
        private int borderbottom;

        //Form Load + Close
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Load settings
            if (!System.IO.File.Exists(settingspath)) {
                SaveSettings(true);
            }

            LoadSettings();


            //Set size
            MinimumSize = Size;
            borderright = Width - (TheFieldOfLife.Location.X + TheFieldOfLife.Width);
            borderbottom = Height - (TheFieldOfLife.Location.Y + TheFieldOfLife.Height);


            //Set input mode
            rb_toggle.Checked = true;

            //Refresh GUI
            CellsDiffer();
            Text += "  --  vers. " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version?.Major.ToString() + "." +
                System.Reflection.Assembly.GetExecutingAssembly().GetName().Version?.Minor.ToString();

            //(new Forms.LoadForm()).ShowDialog();
            //this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Attributes.IsActive) {
                Attributes.AbortAnimation();
            }

            SaveSettings(false);
        }

        private readonly string settingspath = Path.Combine(Attributes.SettingsDirectory, "settings.ini");
        private void LoadSettings()
        {

            var settings = new Queue<string>();
            using (var sr = new System.IO.StreamReader(settingspath)) {
                while (sr.Peek() > -1) {
                    settings.Enqueue(sr.ReadLine() ?? "");
                }
            }


            try {
                Attributes.AmountOfCellsPerLine = int.Parse(settings.Dequeue());
                Attributes.Cells = Attributes.EmptyCells;

                TheFieldOfLife.BackgroundColor = Color.FromArgb(int.Parse(settings.Dequeue()));
                TheFieldOfLife.GridColor = Color.FromArgb(int.Parse(settings.Dequeue()));
                TheFieldOfLife.LivingCellColor = Color.FromArgb(int.Parse(settings.Dequeue()));
                TheFieldOfLife.HoverColor = Color.FromArgb(int.Parse(settings.Dequeue()));

                TheFieldOfLife.CellStyle = (UI.FieldOfLifeUI.CellStyles)Enum.Parse(Type.GetType(typeof(UI.FieldOfLifeUI.CellStyles).FullName), settings.Dequeue());
                TheFieldOfLife.CellFigureDistance = int.Parse(settings.Dequeue());
                TheFieldOfLife.GridStyle = (UI.FieldOfLifeUI.GridStyles)Enum.Parse(Type.GetType(typeof(UI.FieldOfLifeUI.GridStyles).FullName), settings.Dequeue());

                Attributes.Refreshrate = int.Parse(settings.Dequeue());
                Attributes.TorusActivated = bool.Parse(settings.Dequeue());
                Attributes.RuleToSurvive = settings.Dequeue();
                Attributes.RuleToBeBorn = settings.Dequeue();
            }
            catch {
                MessageBox.Show("This is not good");
            }
        }

        private void SaveSettings(bool def)
        {
            if (!Directory.Exists((new FileInfo(settingspath)).DirectoryName)) {
                Directory.CreateDirectory((new FileInfo(settingspath)).DirectoryName);
            }

            using (var sw = new StreamWriter(new FileStream(settingspath, FileMode.Create, FileAccess.Write))) {
                sw.WriteLine(Attributes.AmountOfCellsPerLine.ToString());

                sw.WriteLine(TheFieldOfLife.BackgroundColor.ToArgb().ToString());
                sw.WriteLine(TheFieldOfLife.GridColor.ToArgb().ToString());
                sw.WriteLine(TheFieldOfLife.LivingCellColor.ToArgb().ToString());
                sw.WriteLine(TheFieldOfLife.HoverColor.ToArgb().ToString());

                sw.WriteLine(TheFieldOfLife.CellStyle.ToString());
                sw.WriteLine(TheFieldOfLife.CellFigureDistance.ToString());
                sw.WriteLine(TheFieldOfLife.GridStyle.ToString());

                if (!def) {
                    sw.WriteLine(Attributes.Refreshrate.ToString());
                    sw.WriteLine(Attributes.TorusActivated.ToString());
                    sw.WriteLine(Attributes.RuleToSurvive.ToString());
                    sw.WriteLine(Attributes.RuleToBeBorn.ToString());
                }
                else {
                    sw.WriteLine("100");
                    sw.WriteLine("false");
                    sw.WriteLine("23");
                    sw.WriteLine("3");
                }
            }
        }


        //Buttons
        private Forms.RandomCellsForm? randcellsfrm;
        private Forms.LoadForm? loadfrm;
        private Forms.SaveForm? savefrm;
        private Forms.SettingsForm? settfrm;

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Attributes.Generation = 0;
            Attributes.Cells = Attributes.EmptyCells;
            Attributes.CurrentCellStack.Clear();
            TheFieldOfLife.Invalidate();
        }

        private void btn_random_Click(object sender, EventArgs e)
        {
            randcellsfrm = new Forms.RandomCellsForm();

            //Center the randomcellsform on the mainform
            randcellsfrm.Location = new Point(Location.X + ((Width - randcellsfrm.Width) / 2),
                Location.Y + ((Height - randcellsfrm.Height) / 2));

            if (randcellsfrm.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                Attributes.Generation = 0;
                Attributes.Cells = Attributes.RandomCells((double)randcellsfrm.Density.Value);
                TheFieldOfLife.Invalidate();
            }
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            loadfrm = new Forms.LoadForm();

            //Center the loadform on the mainform
            loadfrm.Location = new Point(Location.X + ((Width - loadfrm.Width) / 2),
                Location.Y + ((Height - loadfrm.Height) / 2));

            loadfrm.ShowDialog();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (Attributes.CurrentCellStack.Count > 0) {
                savefrm = new Forms.SaveForm {

                    //Deliver the Attributes
                    AFieldOfLife = TheFieldOfLife
                };

                //Center the randomcellsform on the mainform
                savefrm.Location = new Point(Location.X + ((Width - savefrm.Width) / 2),
                    Location.Y + ((Height - savefrm.Height) / 2));

                savefrm.ShowDialog();
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            settfrm = new Forms.SettingsForm();

            //Add the settings
            var setts = new UISettingsFile(TheFieldOfLife.GridStyle, TheFieldOfLife.CellStyle, TheFieldOfLife.CellFigureDistance, TheFieldOfLife.SizePerCell,
                TheFieldOfLife.BackgroundColor, TheFieldOfLife.GridColor, TheFieldOfLife.LivingCellColor, TheFieldOfLife.HoverColor);
            settfrm.UISettings = setts;

            //Center the settings form on the mainform
            settfrm.Location = new Point(Location.X + ((Width - settfrm.Width) / 2),
                Location.Y + ((Height - settfrm.Height) / 2));

            settfrm.UISettingsChanged += new Forms.SettingsForm.EmptyEventHandler(settfrm_UISettingsChanged);

            settfrm.ShowDialog();
        }


        //Gets handled when the Cells change
        private void settfrm_UISettingsChanged()
        {
            if (settfrm == null) {
                return;
            }

            TheFieldOfLife.GridStyle = settfrm.UISettings.GridStyle;
            TheFieldOfLife.CellStyle = settfrm.UISettings.CellStyle;
            TheFieldOfLife.CellFigureDistance = settfrm.UISettings.Distance;
            TheFieldOfLife.BackgroundColor = settfrm.UISettings.BackgroundColor;
            TheFieldOfLife.GridColor = settfrm.UISettings.GridColor;
            TheFieldOfLife.LivingCellColor = settfrm.UISettings.LivingColor;
            TheFieldOfLife.HoverColor = settfrm.UISettings.HoverColor;

            TheFieldOfLife.Invalidate();
        }


        //Toggle inputmode
        private void InputMode_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_toggle.Checked) {
                TheFieldOfLife.InputMode = UI.FieldOfLifeUI.InputModes.Toggle;
            }
            else if (rb_activate.Checked) {
                TheFieldOfLife.InputMode = UI.FieldOfLifeUI.InputModes.Activated;
            }
            else if (rb_deactivate.Checked) {
                TheFieldOfLife.InputMode = UI.FieldOfLifeUI.InputModes.Deactivated;
            }

        }


        //Gets handled when the Cells change
        private void CellsDiffer()
        {
            if (InvokeRequired) {
                Invoke(new Action(() => {
                    lbl_value_gen.Text = Attributes.Generation.ToString();
                    lbl_value_living.Text = Attributes.AmountOfLivingCells.ToString();
                    lbl_value_total.Text = Attributes.AmountOfTotalCells.ToString();
                    lbl_value_Density.Text = (Math.Round(Attributes.Density * 100, 2)).ToString() + "%";
                }));
            }
            else {
                lbl_value_gen.Text = Attributes.Generation.ToString();
                lbl_value_living.Text = Attributes.AmountOfLivingCells.ToString();
                lbl_value_total.Text = Attributes.AmountOfTotalCells.ToString();
                lbl_value_Density.Text = (Math.Round(Attributes.Density * 100, 2)).ToString() + "%";
            }

        }





        // ***** The animation *****
        private System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(Attributes.StartAnimation));

        //Toggle animating
        private void btn_runtoggle_Click(object sender, EventArgs e)
        {
            if (Attributes.Cells != null) {
                //Update controls
                //this.btn_load.Enabled = !this.btn_load.Enabled;
                btn_clear.Enabled = !btn_clear.Enabled;
                btn_random.Enabled = !btn_random.Enabled;
                btn_settings.Enabled = !btn_settings.Enabled;
                btn_save.Enabled = !btn_save.Enabled;
                rb_toggle.Enabled = !rb_toggle.Enabled;

                rb_activate.Enabled = !rb_activate.Enabled;
                rb_deactivate.Enabled = !rb_deactivate.Enabled;
                lbl_inputmode.Enabled = !lbl_inputmode.Enabled;

                if (!Attributes.IsActive) {
                    thread = new System.Threading.Thread(new System.Threading.ThreadStart(Attributes.StartAnimation));
                    thread.Start();

                    btn_runtoggle.Text = "Stop";
                    TheFieldOfLife.InputEnabled = false;
                }
                else {
                    thread.Interrupt();
                    Attributes.AbortAnimation();
                    btn_runtoggle.Text = "Run";
                    TheFieldOfLife.InputEnabled = true;
                }
            }
        }

        //Do one step
        private void btn_next_Click(object sender, EventArgs e) => Attributes.CalculateNextGen();

        //Undo last step
        private void btn_previous_Click(object sender, EventArgs e) => Attributes.CalculatePreviousGen();

        //Gets handled when the Cells change while the animation is active
        private void NewGenCalculated(bool[,] cells, bool IsNext)
        {
            Attributes.Cells = cells;
            Attributes.CurrentCellStack.Push(cells);
            TheFieldOfLife.Invalidate();
            if (IsNext) {
                Attributes.Generation++;
            }
            else {
                Attributes.Generation--;
            }

            Invoke(new Action(() => lbl_value_gen.Text = Attributes.Generation.ToString()));
        }





        //Resize
        private const int WM_WINDOWPOSCHANGING = 0x46;

        [System.Diagnostics.DebuggerStepThrough()]
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_WINDOWPOSCHANGING) {
                var wp = new WINDOWPOS();
                wp = (WINDOWPOS)(Marshal.PtrToStructure(m.LParam, typeof(WINDOWPOS)));

                if (wp.cx > 0 && borderright > 0 && borderbottom > 0) {
                    wp.cy = wp.cx - borderright + borderbottom;
                    TheFieldOfLife.Size = new Size(wp.cx - borderright - TheFieldOfLife.Location.X, wp.cy - borderbottom - TheFieldOfLife.Location.Y);
                    TheFieldOfLife.Invalidate();

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
