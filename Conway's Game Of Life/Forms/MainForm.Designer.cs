namespace GameOfLife
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Information = new System.Windows.Forms.GroupBox();
			this.lbl_value_destiny = new System.Windows.Forms.Label();
			this.lbl_value_total = new System.Windows.Forms.Label();
			this.lbl_value_living = new System.Windows.Forms.Label();
			this.lbl_value_gen = new System.Windows.Forms.Label();
			this.lbl_destiny = new System.Windows.Forms.Label();
			this.lbl_total = new System.Windows.Forms.Label();
			this.lbl_living = new System.Windows.Forms.Label();
			this.lbl_generation = new System.Windows.Forms.Label();
			this.btn_runtoggle = new System.Windows.Forms.Button();
			this.btn_clear = new System.Windows.Forms.Button();
			this.btn_random = new System.Windows.Forms.Button();
			this.btn_settings = new System.Windows.Forms.Button();
			this.rb_toggle = new System.Windows.Forms.RadioButton();
			this.rb_activate = new System.Windows.Forms.RadioButton();
			this.rb_deactivate = new System.Windows.Forms.RadioButton();
			this.lbl_inputmode = new System.Windows.Forms.Label();
			this.btn_load = new System.Windows.Forms.Button();
			this.btn_previous = new System.Windows.Forms.Button();
			this.btn_next = new System.Windows.Forms.Button();
			this.btn_save = new System.Windows.Forms.Button();
			this.TheFieldOfLife = new GameOfLife.UI.FieldOfLifeUI();
			this.Information.SuspendLayout();
			this.SuspendLayout();
			// 
			// Information
			// 
			this.Information.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Information.Controls.Add(this.lbl_value_destiny);
			this.Information.Controls.Add(this.lbl_value_total);
			this.Information.Controls.Add(this.lbl_value_living);
			this.Information.Controls.Add(this.lbl_value_gen);
			this.Information.Controls.Add(this.lbl_destiny);
			this.Information.Controls.Add(this.lbl_total);
			this.Information.Controls.Add(this.lbl_living);
			this.Information.Controls.Add(this.lbl_generation);
			this.Information.Location = new System.Drawing.Point(435, 12);
			this.Information.Name = "Information";
			this.Information.Size = new System.Drawing.Size(204, 123);
			this.Information.TabIndex = 1;
			this.Information.TabStop = false;
			this.Information.Text = "Information";
			// 
			// lbl_value_destiny
			// 
			this.lbl_value_destiny.AutoSize = true;
			this.lbl_value_destiny.Location = new System.Drawing.Point(144, 100);
			this.lbl_value_destiny.Name = "lbl_value_destiny";
			this.lbl_value_destiny.Size = new System.Drawing.Size(22, 14);
			this.lbl_value_destiny.TabIndex = 7;
			this.lbl_value_destiny.Text = "0%";
			this.lbl_value_destiny.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_value_total
			// 
			this.lbl_value_total.AutoSize = true;
			this.lbl_value_total.Location = new System.Drawing.Point(144, 76);
			this.lbl_value_total.Name = "lbl_value_total";
			this.lbl_value_total.Size = new System.Drawing.Size(13, 14);
			this.lbl_value_total.TabIndex = 6;
			this.lbl_value_total.Text = "0";
			this.lbl_value_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_value_living
			// 
			this.lbl_value_living.AutoSize = true;
			this.lbl_value_living.Location = new System.Drawing.Point(144, 52);
			this.lbl_value_living.Name = "lbl_value_living";
			this.lbl_value_living.Size = new System.Drawing.Size(13, 14);
			this.lbl_value_living.TabIndex = 5;
			this.lbl_value_living.Text = "0";
			this.lbl_value_living.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_value_gen
			// 
			this.lbl_value_gen.AutoSize = true;
			this.lbl_value_gen.Location = new System.Drawing.Point(144, 28);
			this.lbl_value_gen.Name = "lbl_value_gen";
			this.lbl_value_gen.Size = new System.Drawing.Size(13, 14);
			this.lbl_value_gen.TabIndex = 4;
			this.lbl_value_gen.Text = "0";
			this.lbl_value_gen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbl_destiny
			// 
			this.lbl_destiny.AutoSize = true;
			this.lbl_destiny.Location = new System.Drawing.Point(21, 100);
			this.lbl_destiny.Margin = new System.Windows.Forms.Padding(5);
			this.lbl_destiny.Name = "lbl_destiny";
			this.lbl_destiny.Size = new System.Drawing.Size(50, 14);
			this.lbl_destiny.TabIndex = 3;
			this.lbl_destiny.Text = "Destiny:";
			// 
			// lbl_total
			// 
			this.lbl_total.AutoSize = true;
			this.lbl_total.Location = new System.Drawing.Point(21, 76);
			this.lbl_total.Margin = new System.Windows.Forms.Padding(5);
			this.lbl_total.Name = "lbl_total";
			this.lbl_total.Size = new System.Drawing.Size(37, 14);
			this.lbl_total.TabIndex = 2;
			this.lbl_total.Text = "Total:";
			// 
			// lbl_living
			// 
			this.lbl_living.AutoSize = true;
			this.lbl_living.Location = new System.Drawing.Point(21, 52);
			this.lbl_living.Margin = new System.Windows.Forms.Padding(5);
			this.lbl_living.Name = "lbl_living";
			this.lbl_living.Size = new System.Drawing.Size(71, 14);
			this.lbl_living.TabIndex = 1;
			this.lbl_living.Text = "Living Cells:";
			// 
			// lbl_generation
			// 
			this.lbl_generation.AutoSize = true;
			this.lbl_generation.Location = new System.Drawing.Point(21, 28);
			this.lbl_generation.Margin = new System.Windows.Forms.Padding(5);
			this.lbl_generation.Name = "lbl_generation";
			this.lbl_generation.Size = new System.Drawing.Size(71, 14);
			this.lbl_generation.TabIndex = 0;
			this.lbl_generation.Text = "Generation:";
			// 
			// btn_runtoggle
			// 
			this.btn_runtoggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_runtoggle.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_runtoggle.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_runtoggle.Location = new System.Drawing.Point(443, 157);
			this.btn_runtoggle.Name = "btn_runtoggle";
			this.btn_runtoggle.Size = new System.Drawing.Size(192, 53);
			this.btn_runtoggle.TabIndex = 2;
			this.btn_runtoggle.TabStop = false;
			this.btn_runtoggle.Text = "Run";
			this.btn_runtoggle.UseVisualStyleBackColor = true;
			this.btn_runtoggle.Click += new System.EventHandler(this.btn_runtoggle_Click);
			// 
			// btn_clear
			// 
			this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_clear.Location = new System.Drawing.Point(467, 263);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(145, 30);
			this.btn_clear.TabIndex = 4;
			this.btn_clear.TabStop = false;
			this.btn_clear.Text = "Reset";
			this.btn_clear.UseVisualStyleBackColor = true;
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// btn_random
			// 
			this.btn_random.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_random.Location = new System.Drawing.Point(467, 299);
			this.btn_random.Name = "btn_random";
			this.btn_random.Size = new System.Drawing.Size(145, 30);
			this.btn_random.TabIndex = 5;
			this.btn_random.TabStop = false;
			this.btn_random.Text = "Random";
			this.btn_random.UseVisualStyleBackColor = true;
			this.btn_random.Click += new System.EventHandler(this.btn_random_Click);
			// 
			// btn_settings
			// 
			this.btn_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_settings.Location = new System.Drawing.Point(467, 419);
			this.btn_settings.Name = "btn_settings";
			this.btn_settings.Size = new System.Drawing.Size(145, 30);
			this.btn_settings.TabIndex = 6;
			this.btn_settings.TabStop = false;
			this.btn_settings.Text = "Settings";
			this.btn_settings.UseVisualStyleBackColor = true;
			this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
			// 
			// rb_toggle
			// 
			this.rb_toggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.rb_toggle.AutoSize = true;
			this.rb_toggle.Location = new System.Drawing.Point(110, 435);
			this.rb_toggle.Name = "rb_toggle";
			this.rb_toggle.Size = new System.Drawing.Size(60, 18);
			this.rb_toggle.TabIndex = 8;
			this.rb_toggle.Text = "Toggle";
			this.rb_toggle.UseVisualStyleBackColor = true;
			this.rb_toggle.CheckedChanged += new System.EventHandler(this.InputMode_CheckedChanged);
			// 
			// rb_activate
			// 
			this.rb_activate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.rb_activate.AutoSize = true;
			this.rb_activate.Location = new System.Drawing.Point(229, 435);
			this.rb_activate.Name = "rb_activate";
			this.rb_activate.Size = new System.Drawing.Size(67, 18);
			this.rb_activate.TabIndex = 9;
			this.rb_activate.Text = "Activate";
			this.rb_activate.UseVisualStyleBackColor = true;
			this.rb_activate.CheckedChanged += new System.EventHandler(this.InputMode_CheckedChanged);
			// 
			// rb_deactivate
			// 
			this.rb_deactivate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.rb_deactivate.AutoSize = true;
			this.rb_deactivate.Location = new System.Drawing.Point(347, 435);
			this.rb_deactivate.Name = "rb_deactivate";
			this.rb_deactivate.Size = new System.Drawing.Size(82, 18);
			this.rb_deactivate.TabIndex = 10;
			this.rb_deactivate.Text = "Deactivate";
			this.rb_deactivate.UseVisualStyleBackColor = true;
			this.rb_deactivate.CheckedChanged += new System.EventHandler(this.InputMode_CheckedChanged);
			// 
			// lbl_inputmode
			// 
			this.lbl_inputmode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.lbl_inputmode.AutoSize = true;
			this.lbl_inputmode.Location = new System.Drawing.Point(12, 437);
			this.lbl_inputmode.Name = "lbl_inputmode";
			this.lbl_inputmode.Size = new System.Drawing.Size(73, 14);
			this.lbl_inputmode.TabIndex = 11;
			this.lbl_inputmode.Text = "Input Mode:";
			// 
			// btn_load
			// 
			this.btn_load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_load.Enabled = false;
			this.btn_load.Location = new System.Drawing.Point(467, 335);
			this.btn_load.Name = "btn_load";
			this.btn_load.Size = new System.Drawing.Size(145, 30);
			this.btn_load.TabIndex = 12;
			this.btn_load.TabStop = false;
			this.btn_load.Text = "Load";
			this.btn_load.UseVisualStyleBackColor = true;
			this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
			// 
			// btn_previous
			// 
			this.btn_previous.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_previous.Location = new System.Drawing.Point(467, 216);
			this.btn_previous.Name = "btn_previous";
			this.btn_previous.Size = new System.Drawing.Size(63, 27);
			this.btn_previous.TabIndex = 15;
			this.btn_previous.TabStop = false;
			this.btn_previous.Text = "Previous";
			this.btn_previous.UseVisualStyleBackColor = true;
			this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
			// 
			// btn_next
			// 
			this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_next.Location = new System.Drawing.Point(549, 216);
			this.btn_next.Name = "btn_next";
			this.btn_next.Size = new System.Drawing.Size(63, 27);
			this.btn_next.TabIndex = 16;
			this.btn_next.TabStop = false;
			this.btn_next.Text = "Next";
			this.btn_next.UseVisualStyleBackColor = true;
			this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
			// 
			// btn_save
			// 
			this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_save.Location = new System.Drawing.Point(467, 371);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(145, 30);
			this.btn_save.TabIndex = 17;
			this.btn_save.TabStop = false;
			this.btn_save.Text = "Save";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// TheFieldOfLife
			// 
			this.TheFieldOfLife.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.TheFieldOfLife.CellFigureDistance = 1;
			this.TheFieldOfLife.CellStyle = GameOfLife.UI.FieldOfLifeUI.CellStyles.Square;
			this.TheFieldOfLife.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.TheFieldOfLife.GridStyle = GameOfLife.UI.FieldOfLifeUI.GridStyles.Continuous;
			this.TheFieldOfLife.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(0)))));
			this.TheFieldOfLife.InputEnabled = true;
			this.TheFieldOfLife.LivingCellColor = System.Drawing.Color.LightBlue;
			this.TheFieldOfLife.Location = new System.Drawing.Point(12, 12);
			this.TheFieldOfLife.Name = "TheFieldOfLife";
			this.TheFieldOfLife.Size = new System.Drawing.Size(417, 417);
			this.TheFieldOfLife.TabIndex = 7;
			this.TheFieldOfLife.Text = "TheFieldOfLife";
			// 
			// MainForm
			// 
			this.AcceptButton = this.btn_runtoggle;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(649, 461);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.btn_next);
			this.Controls.Add(this.btn_previous);
			this.Controls.Add(this.btn_load);
			this.Controls.Add(this.lbl_inputmode);
			this.Controls.Add(this.rb_deactivate);
			this.Controls.Add(this.rb_activate);
			this.Controls.Add(this.rb_toggle);
			this.Controls.Add(this.TheFieldOfLife);
			this.Controls.Add(this.btn_settings);
			this.Controls.Add(this.btn_random);
			this.Controls.Add(this.btn_clear);
			this.Controls.Add(this.btn_runtoggle);
			this.Controls.Add(this.Information);
			this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Conway\'s Game Of Life";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Information.ResumeLayout(false);
			this.Information.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }


		internal System.Windows.Forms.GroupBox Information;
		internal System.Windows.Forms.Label lbl_value_destiny;
		internal System.Windows.Forms.Label lbl_value_total;
		internal System.Windows.Forms.Label lbl_value_living;
		internal System.Windows.Forms.Label lbl_value_gen;
		internal System.Windows.Forms.Label lbl_destiny;
		internal System.Windows.Forms.Label lbl_total;
		internal System.Windows.Forms.Label lbl_living;
		internal System.Windows.Forms.Label lbl_generation;
		internal System.Windows.Forms.Button btn_runtoggle;
		internal System.Windows.Forms.Button btn_clear;
		internal System.Windows.Forms.Button btn_random;
		internal System.Windows.Forms.Button btn_settings;
		internal GameOfLife.UI.FieldOfLifeUI TheFieldOfLife;
		internal System.Windows.Forms.RadioButton rb_toggle;
		internal System.Windows.Forms.RadioButton rb_activate;
		internal System.Windows.Forms.RadioButton rb_deactivate;
		internal System.Windows.Forms.Label lbl_inputmode;
		internal System.Windows.Forms.Button btn_load;
		internal System.Windows.Forms.Button btn_previous;
		internal System.Windows.Forms.Button btn_next;
		internal System.Windows.Forms.Button btn_save;

        #endregion
    }
}

