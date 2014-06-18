namespace GameOfLife.Forms
{
	partial class SettingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.gb_design = new System.Windows.Forms.GroupBox();
			this.lbl_hovercolor = new System.Windows.Forms.Label();
			this.btn_hovercolor = new System.Windows.Forms.Button();
			this.lbl_fieldsizevalue = new System.Windows.Forms.Label();
			this.tb_fieldsize = new System.Windows.Forms.TrackBar();
			this.lbl_fieldsize = new System.Windows.Forms.Label();
			this.lbl_distance = new System.Windows.Forms.Label();
			this.nud_distance = new System.Windows.Forms.NumericUpDown();
			this.lbl_CellStyle = new System.Windows.Forms.Label();
			this.cb_cellstyle = new System.Windows.Forms.ComboBox();
			this.lbl_gridstyle = new System.Windows.Forms.Label();
			this.cb_gridstyle = new System.Windows.Forms.ComboBox();
			this.lbl_gridcolor = new System.Windows.Forms.Label();
			this.lbl_livingcolor = new System.Windows.Forms.Label();
			this.lbl_backcolor = new System.Windows.Forms.Label();
			this.btn_backcolor = new System.Windows.Forms.Button();
			this.btn_gridcolor = new System.Windows.Forms.Button();
			this.btn_livingcolor = new System.Windows.Forms.Button();
			this.btn_reset = new System.Windows.Forms.Button();
			this.lbl_refreshrate = new System.Windows.Forms.Label();
			this.nud_refreshrate = new System.Windows.Forms.NumericUpDown();
			this.lbl_ms = new System.Windows.Forms.Label();
			this.gb_animation = new System.Windows.Forms.GroupBox();
			this.btnrow_born = new GameOfLife.UI.RuleButtonRow();
			this.btnrow_survive = new GameOfLife.UI.RuleButtonRow();
			this.cb_torus = new System.Windows.Forms.CheckBox();
			this.lbl_rules = new System.Windows.Forms.Label();
			this.cb_rules = new System.Windows.Forms.ComboBox();
			this.lbl_surviverule = new System.Windows.Forms.Label();
			this.lbl_bornrule = new System.Windows.Forms.Label();
			this.gb_design.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tb_fieldsize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_distance)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_refreshrate)).BeginInit();
			this.gb_animation.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_Save
			// 
			this.btn_Save.Location = new System.Drawing.Point(437, 375);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.Size = new System.Drawing.Size(75, 23);
			this.btn_Save.TabIndex = 0;
			this.btn_Save.Text = "Save";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cancel.Location = new System.Drawing.Point(356, 375);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 1;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			// 
			// gb_design
			// 
			this.gb_design.Controls.Add(this.lbl_hovercolor);
			this.gb_design.Controls.Add(this.btn_hovercolor);
			this.gb_design.Controls.Add(this.lbl_fieldsizevalue);
			this.gb_design.Controls.Add(this.tb_fieldsize);
			this.gb_design.Controls.Add(this.lbl_fieldsize);
			this.gb_design.Controls.Add(this.lbl_distance);
			this.gb_design.Controls.Add(this.nud_distance);
			this.gb_design.Controls.Add(this.lbl_CellStyle);
			this.gb_design.Controls.Add(this.cb_cellstyle);
			this.gb_design.Controls.Add(this.lbl_gridstyle);
			this.gb_design.Controls.Add(this.cb_gridstyle);
			this.gb_design.Controls.Add(this.lbl_gridcolor);
			this.gb_design.Controls.Add(this.lbl_livingcolor);
			this.gb_design.Controls.Add(this.lbl_backcolor);
			this.gb_design.Controls.Add(this.btn_backcolor);
			this.gb_design.Controls.Add(this.btn_gridcolor);
			this.gb_design.Controls.Add(this.btn_livingcolor);
			this.gb_design.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gb_design.Location = new System.Drawing.Point(12, 12);
			this.gb_design.Name = "gb_design";
			this.gb_design.Padding = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.gb_design.Size = new System.Drawing.Size(500, 208);
			this.gb_design.TabIndex = 2;
			this.gb_design.TabStop = false;
			this.gb_design.Text = "Design of the GameField";
			// 
			// lbl_hovercolor
			// 
			this.lbl_hovercolor.AutoSize = true;
			this.lbl_hovercolor.Location = new System.Drawing.Point(323, 111);
			this.lbl_hovercolor.Name = "lbl_hovercolor";
			this.lbl_hovercolor.Size = new System.Drawing.Size(68, 14);
			this.lbl_hovercolor.TabIndex = 18;
			this.lbl_hovercolor.Text = "Hovercolor:";
			// 
			// btn_hovercolor
			// 
			this.btn_hovercolor.Location = new System.Drawing.Point(443, 107);
			this.btn_hovercolor.Name = "btn_hovercolor";
			this.btn_hovercolor.Size = new System.Drawing.Size(51, 23);
			this.btn_hovercolor.TabIndex = 17;
			this.btn_hovercolor.Text = " ";
			this.btn_hovercolor.UseVisualStyleBackColor = true;
			this.btn_hovercolor.Click += new System.EventHandler(this.btn_hovercolor_Click);
			// 
			// lbl_fieldsizevalue
			// 
			this.lbl_fieldsizevalue.Location = new System.Drawing.Point(457, 170);
			this.lbl_fieldsizevalue.Name = "lbl_fieldsizevalue";
			this.lbl_fieldsizevalue.Size = new System.Drawing.Size(37, 14);
			this.lbl_fieldsizevalue.TabIndex = 16;
			this.lbl_fieldsizevalue.Text = "0";
			this.lbl_fieldsizevalue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tb_fieldsize
			// 
			this.tb_fieldsize.LargeChange = 10;
			this.tb_fieldsize.Location = new System.Drawing.Point(148, 157);
			this.tb_fieldsize.Maximum = 100;
			this.tb_fieldsize.Minimum = 5;
			this.tb_fieldsize.Name = "tb_fieldsize";
			this.tb_fieldsize.Size = new System.Drawing.Size(303, 45);
			this.tb_fieldsize.SmallChange = 5;
			this.tb_fieldsize.TabIndex = 14;
			this.tb_fieldsize.TickFrequency = 5;
			this.tb_fieldsize.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.tb_fieldsize.Value = 5;
			this.tb_fieldsize.ValueChanged += new System.EventHandler(this.tb_fieldsize_ValueChanged);
			// 
			// lbl_fieldsize
			// 
			this.lbl_fieldsize.AutoSize = true;
			this.lbl_fieldsize.Location = new System.Drawing.Point(6, 170);
			this.lbl_fieldsize.Name = "lbl_fieldsize";
			this.lbl_fieldsize.Size = new System.Drawing.Size(83, 14);
			this.lbl_fieldsize.TabIndex = 15;
			this.lbl_fieldsize.Text = "Cells per line:";
			// 
			// lbl_distance
			// 
			this.lbl_distance.AutoSize = true;
			this.lbl_distance.Location = new System.Drawing.Point(6, 109);
			this.lbl_distance.Name = "lbl_distance";
			this.lbl_distance.Size = new System.Drawing.Size(127, 14);
			this.lbl_distance.TabIndex = 11;
			this.lbl_distance.Text = "Distance Cell <-> Grid:";
			// 
			// nud_distance
			// 
			this.nud_distance.Location = new System.Drawing.Point(148, 107);
			this.nud_distance.Name = "nud_distance";
			this.nud_distance.Size = new System.Drawing.Size(105, 22);
			this.nud_distance.TabIndex = 10;
			this.nud_distance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nud_distance.ValueChanged += new System.EventHandler(this.nud_distance_ValueChanged);
			// 
			// lbl_CellStyle
			// 
			this.lbl_CellStyle.AutoSize = true;
			this.lbl_CellStyle.Location = new System.Drawing.Point(6, 67);
			this.lbl_CellStyle.Name = "lbl_CellStyle";
			this.lbl_CellStyle.Size = new System.Drawing.Size(57, 14);
			this.lbl_CellStyle.TabIndex = 9;
			this.lbl_CellStyle.Text = "CellStyle:";
			// 
			// cb_cellstyle
			// 
			this.cb_cellstyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_cellstyle.FormattingEnabled = true;
			this.cb_cellstyle.Location = new System.Drawing.Point(148, 64);
			this.cb_cellstyle.Name = "cb_cellstyle";
			this.cb_cellstyle.Size = new System.Drawing.Size(105, 22);
			this.cb_cellstyle.TabIndex = 8;
			this.cb_cellstyle.SelectedIndexChanged += new System.EventHandler(this.cb_cellstyle_SelectedIndexChanged);
			// 
			// lbl_gridstyle
			// 
			this.lbl_gridstyle.AutoSize = true;
			this.lbl_gridstyle.Location = new System.Drawing.Point(6, 24);
			this.lbl_gridstyle.Name = "lbl_gridstyle";
			this.lbl_gridstyle.Size = new System.Drawing.Size(59, 14);
			this.lbl_gridstyle.TabIndex = 7;
			this.lbl_gridstyle.Text = "Gridstyle:";
			// 
			// cb_gridstyle
			// 
			this.cb_gridstyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_gridstyle.FormattingEnabled = true;
			this.cb_gridstyle.Location = new System.Drawing.Point(148, 20);
			this.cb_gridstyle.Name = "cb_gridstyle";
			this.cb_gridstyle.Size = new System.Drawing.Size(105, 22);
			this.cb_gridstyle.TabIndex = 6;
			this.cb_gridstyle.SelectedIndexChanged += new System.EventHandler(this.cb_gridstyle_SelectedIndexChanged);
			// 
			// lbl_gridcolor
			// 
			this.lbl_gridcolor.AutoSize = true;
			this.lbl_gridcolor.Location = new System.Drawing.Point(324, 53);
			this.lbl_gridcolor.Name = "lbl_gridcolor";
			this.lbl_gridcolor.Size = new System.Drawing.Size(60, 14);
			this.lbl_gridcolor.TabIndex = 5;
			this.lbl_gridcolor.Text = "Gridcolor:";
			// 
			// lbl_livingcolor
			// 
			this.lbl_livingcolor.AutoSize = true;
			this.lbl_livingcolor.Location = new System.Drawing.Point(324, 82);
			this.lbl_livingcolor.Name = "lbl_livingcolor";
			this.lbl_livingcolor.Size = new System.Drawing.Size(96, 14);
			this.lbl_livingcolor.TabIndex = 4;
			this.lbl_livingcolor.Text = "Living Cell Color:";
			// 
			// lbl_backcolor
			// 
			this.lbl_backcolor.AutoSize = true;
			this.lbl_backcolor.Location = new System.Drawing.Point(323, 24);
			this.lbl_backcolor.Name = "lbl_backcolor";
			this.lbl_backcolor.Size = new System.Drawing.Size(100, 14);
			this.lbl_backcolor.TabIndex = 3;
			this.lbl_backcolor.Text = "Backgroundcolor:";
			// 
			// btn_backcolor
			// 
			this.btn_backcolor.Location = new System.Drawing.Point(444, 20);
			this.btn_backcolor.Name = "btn_backcolor";
			this.btn_backcolor.Size = new System.Drawing.Size(51, 23);
			this.btn_backcolor.TabIndex = 2;
			this.btn_backcolor.Text = " ";
			this.btn_backcolor.UseVisualStyleBackColor = true;
			this.btn_backcolor.Click += new System.EventHandler(this.btn_backcolor_Click);
			// 
			// btn_gridcolor
			// 
			this.btn_gridcolor.Location = new System.Drawing.Point(444, 48);
			this.btn_gridcolor.Name = "btn_gridcolor";
			this.btn_gridcolor.Size = new System.Drawing.Size(51, 23);
			this.btn_gridcolor.TabIndex = 1;
			this.btn_gridcolor.Text = " ";
			this.btn_gridcolor.UseVisualStyleBackColor = true;
			this.btn_gridcolor.Click += new System.EventHandler(this.btn_gridcolor_Click);
			// 
			// btn_livingcolor
			// 
			this.btn_livingcolor.Location = new System.Drawing.Point(444, 78);
			this.btn_livingcolor.Name = "btn_livingcolor";
			this.btn_livingcolor.Size = new System.Drawing.Size(51, 23);
			this.btn_livingcolor.TabIndex = 0;
			this.btn_livingcolor.Text = " ";
			this.btn_livingcolor.UseVisualStyleBackColor = true;
			this.btn_livingcolor.Click += new System.EventHandler(this.btn_livingcolor_Click);
			// 
			// btn_reset
			// 
			this.btn_reset.Location = new System.Drawing.Point(12, 375);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(75, 23);
			this.btn_reset.TabIndex = 3;
			this.btn_reset.Text = "Reset";
			this.btn_reset.UseVisualStyleBackColor = true;
			this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
			// 
			// lbl_refreshrate
			// 
			this.lbl_refreshrate.AutoSize = true;
			this.lbl_refreshrate.Location = new System.Drawing.Point(6, 18);
			this.lbl_refreshrate.Name = "lbl_refreshrate";
			this.lbl_refreshrate.Size = new System.Drawing.Size(160, 14);
			this.lbl_refreshrate.TabIndex = 4;
			this.lbl_refreshrate.Text = "Time to the next generation:";
			// 
			// nud_refreshrate
			// 
			this.nud_refreshrate.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nud_refreshrate.Location = new System.Drawing.Point(175, 16);
			this.nud_refreshrate.Name = "nud_refreshrate";
			this.nud_refreshrate.Size = new System.Drawing.Size(78, 22);
			this.nud_refreshrate.TabIndex = 5;
			this.nud_refreshrate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nud_refreshrate.ValueChanged += new System.EventHandler(this.nud_refreshrate_ValueChanged);
			// 
			// lbl_ms
			// 
			this.lbl_ms.AutoSize = true;
			this.lbl_ms.Location = new System.Drawing.Point(259, 18);
			this.lbl_ms.Name = "lbl_ms";
			this.lbl_ms.Size = new System.Drawing.Size(23, 14);
			this.lbl_ms.TabIndex = 6;
			this.lbl_ms.Text = "ms";
			// 
			// gb_animation
			// 
			this.gb_animation.Controls.Add(this.btnrow_born);
			this.gb_animation.Controls.Add(this.btnrow_survive);
			this.gb_animation.Controls.Add(this.cb_torus);
			this.gb_animation.Controls.Add(this.lbl_rules);
			this.gb_animation.Controls.Add(this.cb_rules);
			this.gb_animation.Controls.Add(this.lbl_surviverule);
			this.gb_animation.Controls.Add(this.lbl_bornrule);
			this.gb_animation.Controls.Add(this.lbl_ms);
			this.gb_animation.Controls.Add(this.nud_refreshrate);
			this.gb_animation.Controls.Add(this.lbl_refreshrate);
			this.gb_animation.Location = new System.Drawing.Point(12, 226);
			this.gb_animation.Name = "gb_animation";
			this.gb_animation.Padding = new System.Windows.Forms.Padding(3, 8, 3, 3);
			this.gb_animation.Size = new System.Drawing.Size(500, 143);
			this.gb_animation.TabIndex = 7;
			this.gb_animation.TabStop = false;
			this.gb_animation.Text = "Animation";
			// 
			// btnrow_born
			// 
			this.btnrow_born.Location = new System.Drawing.Point(148, 111);
			this.btnrow_born.Name = "btnrow_born";
			this.btnrow_born.Rule = "";
			this.btnrow_born.Size = new System.Drawing.Size(213, 22);
			this.btnrow_born.TabIndex = 36;
			this.btnrow_born.Click += new System.EventHandler(this.btnrow_Click);
			// 
			// btnrow_survive
			// 
			this.btnrow_survive.Location = new System.Drawing.Point(148, 83);
			this.btnrow_survive.Name = "btnrow_survive";
			this.btnrow_survive.Rule = "";
			this.btnrow_survive.Size = new System.Drawing.Size(213, 22);
			this.btnrow_survive.TabIndex = 35;
			this.btnrow_survive.Click += new System.EventHandler(this.btnrow_Click);
			// 
			// cb_torus
			// 
			this.cb_torus.AutoSize = true;
			this.cb_torus.Location = new System.Drawing.Point(326, 18);
			this.cb_torus.Name = "cb_torus";
			this.cb_torus.Size = new System.Drawing.Size(115, 18);
			this.cb_torus.TabIndex = 34;
			this.cb_torus.Text = "Allow torus map";
			this.cb_torus.UseVisualStyleBackColor = true;
			this.cb_torus.CheckedChanged += new System.EventHandler(this.cb_torus_CheckedChanged);
			// 
			// lbl_rules
			// 
			this.lbl_rules.AutoSize = true;
			this.lbl_rules.Location = new System.Drawing.Point(6, 58);
			this.lbl_rules.Name = "lbl_rules";
			this.lbl_rules.Size = new System.Drawing.Size(78, 14);
			this.lbl_rules.TabIndex = 31;
			this.lbl_rules.Text = "Selelct rules:";
			// 
			// cb_rules
			// 
			this.cb_rules.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_rules.FormattingEnabled = true;
			this.cb_rules.Items.AddRange(new object[] {
            "Conway\'s preset rules [23|3]",
            "Anticonway [01234678|0123478]",
            "Copyworld [1357|1357]",
            "Anti-Copyworld [02468|02468]",
            "The 3/3 - World [3|3]",
            "The 13/3 - World [13|3]",
            "Expanded 13/3 - World [135|35]",
            "The 24/3 - World [24|3]",
            "The 24/35 - World [24|35]",
            "The 245/3 - World [245|3]",
            "The 34/3 - World [34|3]",
            "Anti-4G3 World [01234678|0123678]",
            "The 35/3 - World [35|3]",
            "The 125/36 - World [125|36]",
            "Exploding - World [236|3]",
            "Expanding - World [012345678|1357]",
            "Labyrinthworld [12345|3]",
            "Blinkyworld [0123|01234]",
            "Custom"});
			this.cb_rules.Location = new System.Drawing.Point(148, 55);
			this.cb_rules.Name = "cb_rules";
			this.cb_rules.Size = new System.Drawing.Size(213, 22);
			this.cb_rules.TabIndex = 30;
			this.cb_rules.SelectedIndexChanged += new System.EventHandler(this.cb_rules_SelectedIndexChanged);
			// 
			// lbl_surviverule
			// 
			this.lbl_surviverule.AutoSize = true;
			this.lbl_surviverule.Location = new System.Drawing.Point(6, 86);
			this.lbl_surviverule.Name = "lbl_surviverule";
			this.lbl_surviverule.Size = new System.Drawing.Size(121, 14);
			this.lbl_surviverule.TabIndex = 19;
			this.lbl_surviverule.Text = "Neighbors to survive:";
			// 
			// lbl_bornrule
			// 
			this.lbl_bornrule.AutoSize = true;
			this.lbl_bornrule.Location = new System.Drawing.Point(6, 114);
			this.lbl_bornrule.Name = "lbl_bornrule";
			this.lbl_bornrule.Size = new System.Drawing.Size(125, 14);
			this.lbl_bornrule.TabIndex = 7;
			this.lbl_bornrule.Text = "Neighbors to be born:";
			// 
			// SettingsForm
			// 
			this.AcceptButton = this.btn_Save;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 410);
			this.Controls.Add(this.btn_reset);
			this.Controls.Add(this.btn_Cancel);
			this.Controls.Add(this.btn_Save);
			this.Controls.Add(this.gb_animation);
			this.Controls.Add(this.gb_design);
			this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SettingsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Settings";
			this.Load += new System.EventHandler(this.SettingsForm_Load);
			this.gb_design.ResumeLayout(false);
			this.gb_design.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tb_fieldsize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_distance)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_refreshrate)).EndInit();
			this.gb_animation.ResumeLayout(false);
			this.gb_animation.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal System.Windows.Forms.Button btn_Save;
		internal System.Windows.Forms.Button btn_Cancel;
		internal System.Windows.Forms.GroupBox gb_design;
		internal System.Windows.Forms.Label lbl_distance;
		internal System.Windows.Forms.NumericUpDown nud_distance;
		internal System.Windows.Forms.Label lbl_CellStyle;
		internal System.Windows.Forms.ComboBox cb_cellstyle;
		internal System.Windows.Forms.Label lbl_gridcolor;
		internal System.Windows.Forms.Label lbl_livingcolor;
		internal System.Windows.Forms.Label lbl_backcolor;
		internal System.Windows.Forms.Button btn_backcolor;
		internal System.Windows.Forms.Button btn_gridcolor;
		internal System.Windows.Forms.Button btn_livingcolor;
		internal System.Windows.Forms.Button btn_reset;
		internal System.Windows.Forms.Label lbl_refreshrate;
		internal System.Windows.Forms.NumericUpDown nud_refreshrate;
		internal System.Windows.Forms.Label lbl_ms;
		internal System.Windows.Forms.GroupBox gb_animation;
		internal System.Windows.Forms.Label lbl_fieldsizevalue;
		internal System.Windows.Forms.TrackBar tb_fieldsize;
		internal System.Windows.Forms.Label lbl_fieldsize;
		internal System.Windows.Forms.Label lbl_bornrule;
		internal System.Windows.Forms.Label lbl_gridstyle;
		internal System.Windows.Forms.ComboBox cb_gridstyle;
		internal System.Windows.Forms.Label lbl_rules;
		internal System.Windows.Forms.ComboBox cb_rules;
		internal System.Windows.Forms.Label lbl_surviverule;
		internal System.Windows.Forms.CheckBox cb_torus;
		internal System.Windows.Forms.Label lbl_hovercolor;
		internal System.Windows.Forms.Button btn_hovercolor;
		private UI.RuleButtonRow btnrow_born;
		private UI.RuleButtonRow btnrow_survive;

	}
}