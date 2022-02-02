namespace GameOfLife.Forms
{
	partial class RandomCellsForm
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
			this.lbl_Text = new System.Windows.Forms.Label();
			this.Density = new System.Windows.Forms.NumericUpDown();
			this.lbl_percent = new System.Windows.Forms.Label();
			this.btn_ok = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Density)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_Text
			// 
			this.lbl_Text.AutoSize = true;
			this.lbl_Text.Location = new System.Drawing.Point(12, 22);
			this.lbl_Text.Name = "lbl_Text";
			this.lbl_Text.Size = new System.Drawing.Size(167, 14);
			this.lbl_Text.TabIndex = 0;
			this.lbl_Text.Text = "Density (used as probability):";
			// 
			// Density
			// 
			this.Density.DecimalPlaces = 1;
			this.Density.Location = new System.Drawing.Point(185, 20);
			this.Density.Name = "Density";
			this.Density.Size = new System.Drawing.Size(92, 22);
			this.Density.TabIndex = 2;
			this.Density.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.Density.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
			// 
			// lbl_percent
			// 
			this.lbl_percent.AutoSize = true;
			this.lbl_percent.Location = new System.Drawing.Point(283, 22);
			this.lbl_percent.Name = "lbl_percent";
			this.lbl_percent.Size = new System.Drawing.Size(16, 14);
			this.lbl_percent.TabIndex = 3;
			this.lbl_percent.Text = "%";
			// 
			// btn_ok
			// 
			this.btn_ok.Location = new System.Drawing.Point(271, 55);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(83, 23);
			this.btn_ok.TabIndex = 4;
			this.btn_ok.Text = "Apply";
			this.btn_ok.UseVisualStyleBackColor = true;
			// 
			// btn_cancel
			// 
			this.btn_cancel.Location = new System.Drawing.Point(182, 55);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(83, 23);
			this.btn_cancel.TabIndex = 5;
			this.btn_cancel.Text = "Cancel";
			this.btn_cancel.UseVisualStyleBackColor = true;
			// 
			// RandomCellsForm
			// 
			this.AcceptButton = this.btn_ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(366, 90);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_ok);
			this.Controls.Add(this.lbl_percent);
			this.Controls.Add(this.Density);
			this.Controls.Add(this.lbl_Text);
			this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "RandomCellsForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Add Random Cells";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.Density)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.Label lbl_Text;
		internal System.Windows.Forms.NumericUpDown Density;
		internal System.Windows.Forms.Label lbl_percent;
		internal System.Windows.Forms.Button btn_ok;


		#endregion
		internal System.Windows.Forms.Button btn_cancel;


	}
}