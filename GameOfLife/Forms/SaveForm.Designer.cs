namespace GameOfLife.Forms
{
    partial class SaveForm
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
			this.btn_save = new System.Windows.Forms.Button();
			this.nud_gen = new System.Windows.Forms.NumericUpDown();
			this.lbl_gen = new System.Windows.Forms.Label();
			this.btn_browse = new System.Windows.Forms.Button();
			this.lbl_path = new System.Windows.Forms.Label();
			this.txt_path = new System.Windows.Forms.TextBox();
			this.rb_bmp = new System.Windows.Forms.RadioButton();
			this.rb_gif = new System.Windows.Forms.RadioButton();
			this.rb_data = new System.Windows.Forms.RadioButton();
			this.btn_cancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nud_gen)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_save
			// 
			this.btn_save.Location = new System.Drawing.Point(500, 85);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(82, 28);
			this.btn_save.TabIndex = 7;
			this.btn_save.Text = "Save";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// nud_gen
			// 
			this.nud_gen.Location = new System.Drawing.Point(249, 51);
			this.nud_gen.Name = "nud_gen";
			this.nud_gen.Size = new System.Drawing.Size(79, 22);
			this.nud_gen.TabIndex = 4;
			this.nud_gen.TabStop = false;
			this.nud_gen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nud_gen.ValueChanged += new System.EventHandler(this.nud_gen_ValueChanged);
			// 
			// lbl_gen
			// 
			this.lbl_gen.AutoSize = true;
			this.lbl_gen.Location = new System.Drawing.Point(172, 53);
			this.lbl_gen.Name = "lbl_gen";
			this.lbl_gen.Size = new System.Drawing.Size(71, 14);
			this.lbl_gen.TabIndex = 3;
			this.lbl_gen.Text = "Generation:";
			// 
			// btn_browse
			// 
			this.btn_browse.Location = new System.Drawing.Point(511, 17);
			this.btn_browse.Name = "btn_browse";
			this.btn_browse.Size = new System.Drawing.Size(70, 24);
			this.btn_browse.TabIndex = 2;
			this.btn_browse.TabStop = false;
			this.btn_browse.Text = "Browse";
			this.btn_browse.UseVisualStyleBackColor = true;
			this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
			// 
			// lbl_path
			// 
			this.lbl_path.AutoSize = true;
			this.lbl_path.Location = new System.Drawing.Point(172, 22);
			this.lbl_path.Name = "lbl_path";
			this.lbl_path.Size = new System.Drawing.Size(34, 14);
			this.lbl_path.TabIndex = 1;
			this.lbl_path.Text = "Path:";
			// 
			// txt_path
			// 
			this.txt_path.Location = new System.Drawing.Point(212, 19);
			this.txt_path.Name = "txt_path";
			this.txt_path.Size = new System.Drawing.Size(292, 22);
			this.txt_path.TabIndex = 0;
			this.txt_path.TabStop = false;
			this.txt_path.TextChanged += new System.EventHandler(this.txt_path_TextChanged);
			// 
			// rb_bmp
			// 
			this.rb_bmp.AutoSize = true;
			this.rb_bmp.Location = new System.Drawing.Point(17, 17);
			this.rb_bmp.Margin = new System.Windows.Forms.Padding(8);
			this.rb_bmp.Name = "rb_bmp";
			this.rb_bmp.Size = new System.Drawing.Size(108, 18);
			this.rb_bmp.TabIndex = 2;
			this.rb_bmp.Text = "Save as Bitmap";
			this.rb_bmp.UseVisualStyleBackColor = true;
			this.rb_bmp.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// rb_gif
			// 
			this.rb_gif.AutoSize = true;
			this.rb_gif.Location = new System.Drawing.Point(17, 51);
			this.rb_gif.Margin = new System.Windows.Forms.Padding(8);
			this.rb_gif.Name = "rb_gif";
			this.rb_gif.Size = new System.Drawing.Size(86, 18);
			this.rb_gif.TabIndex = 3;
			this.rb_gif.Text = "Safe as GIF";
			this.rb_gif.UseVisualStyleBackColor = true;
			this.rb_gif.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// rb_data
			// 
			this.rb_data.AutoSize = true;
			this.rb_data.Location = new System.Drawing.Point(17, 85);
			this.rb_data.Margin = new System.Windows.Forms.Padding(8);
			this.rb_data.Name = "rb_data";
			this.rb_data.Size = new System.Drawing.Size(111, 18);
			this.rb_data.TabIndex = 4;
			this.rb_data.Text = "Save as datafile";
			this.rb_data.UseVisualStyleBackColor = true;
			this.rb_data.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
			// 
			// btn_cancel
			// 
			this.btn_cancel.Location = new System.Drawing.Point(412, 85);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(82, 28);
			this.btn_cancel.TabIndex = 8;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			// 
			// SaveForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 121);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.rb_data);
			this.Controls.Add(this.lbl_gen);
			this.Controls.Add(this.nud_gen);
			this.Controls.Add(this.rb_gif);
			this.Controls.Add(this.rb_bmp);
			this.Controls.Add(this.btn_browse);
			this.Controls.Add(this.lbl_path);
			this.Controls.Add(this.txt_path);
			this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "SaveForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Save";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.SaveForm_Load);
			this.Shown += new System.EventHandler(this.SaveForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.nud_gen)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		internal System.Windows.Forms.NumericUpDown nud_gen;
		internal System.Windows.Forms.Label lbl_gen;
		internal System.Windows.Forms.Button btn_browse;
		internal System.Windows.Forms.Label lbl_path;
		internal System.Windows.Forms.TextBox txt_path;
		internal System.Windows.Forms.Button btn_save;
		internal System.Windows.Forms.RadioButton rb_bmp;
		internal System.Windows.Forms.RadioButton rb_gif;
		internal System.Windows.Forms.RadioButton rb_data;

        #endregion
		internal System.Windows.Forms.Button btn_cancel;
    }
}