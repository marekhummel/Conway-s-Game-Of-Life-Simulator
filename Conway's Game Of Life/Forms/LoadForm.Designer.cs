namespace GameOfLife.Forms
{
    partial class LoadForm
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
			System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Conway\'s preset rules [23|3]");
			System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Anticonway [01234678|0123478]");
			System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Copyworld [1357|1357]");
			System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Anti-Copyworld [02468|02468]");
			System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("The 3/3 - World [3|3]");
			System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("The 13/3 - World [13|3]");
			System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Expanded 13/3 - World [135|35]");
			System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("The 24/3 - World [24|3]");
			System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("The 24/35 - World [24|35]");
			System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("The 245/3 - World [245|3]");
			System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("The 34/3 - World [34|3]");
			System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Anti-4G3 World [01234678|0123678]");
			System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("The 35/3 - World [35|3]");
			System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("The 125/36 - World [125|36]");
			System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Exploding - World [236|3]");
			System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Expanding - World [012345678|1357]");
			System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Labyrinthworld [12345|3]");
			System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Blinkyworld [0123|01234]");
			System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Other");
			this.btn_apply = new System.Windows.Forms.Button();
			this.tree_data = new System.Windows.Forms.TreeView();
			this.btn_browse = new System.Windows.Forms.Button();
			this.txt_path = new System.Windows.Forms.TextBox();
			this.lbl_path = new System.Windows.Forms.Label();
			this.gb_add = new System.Windows.Forms.GroupBox();
			this.btn_add = new System.Windows.Forms.Button();
			this.gb_add.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_apply
			// 
			this.btn_apply.Location = new System.Drawing.Point(144, 303);
			this.btn_apply.Name = "btn_apply";
			this.btn_apply.Size = new System.Drawing.Size(123, 30);
			this.btn_apply.TabIndex = 1;
			this.btn_apply.Text = "Apply";
			this.btn_apply.UseVisualStyleBackColor = true;
			// 
			// tree_data
			// 
			this.tree_data.AllowDrop = true;
			this.tree_data.Location = new System.Drawing.Point(12, 93);
			this.tree_data.Name = "tree_data";
			treeNode20.Name = "node_23_3";
			treeNode20.Text = "Conway\'s preset rules [23|3]";
			treeNode21.Name = "node_01234678_0123478";
			treeNode21.Text = "Anticonway [01234678|0123478]";
			treeNode22.Name = "node_1357_1357";
			treeNode22.Text = "Copyworld [1357|1357]";
			treeNode23.Name = "node_02468_02468";
			treeNode23.Text = "Anti-Copyworld [02468|02468]";
			treeNode24.Name = "node_3_3";
			treeNode24.Text = "The 3/3 - World [3|3]";
			treeNode25.Name = "node_13_3";
			treeNode25.Text = "The 13/3 - World [13|3]";
			treeNode26.Name = "node_135_35";
			treeNode26.Text = "Expanded 13/3 - World [135|35]";
			treeNode27.Name = "node_24_3";
			treeNode27.Text = "The 24/3 - World [24|3]";
			treeNode28.Name = "node_24_35";
			treeNode28.Text = "The 24/35 - World [24|35]";
			treeNode29.Name = "node_245_3";
			treeNode29.Text = "The 245/3 - World [245|3]";
			treeNode30.Name = "node_34_3";
			treeNode30.Text = "The 34/3 - World [34|3]";
			treeNode31.Name = "node_01234678_0123678";
			treeNode31.Text = "Anti-4G3 World [01234678|0123678]";
			treeNode32.Name = "node_35_3";
			treeNode32.Text = "The 35/3 - World [35|3]";
			treeNode33.Name = "node_125_36";
			treeNode33.Text = "The 125/36 - World [125|36]";
			treeNode34.Name = "node_236_3";
			treeNode34.Text = "Exploding - World [236|3]";
			treeNode35.Name = "node_012345678_1357";
			treeNode35.Text = "Expanding - World [012345678|1357]";
			treeNode36.Name = "node_12345_3";
			treeNode36.Text = "Labyrinthworld [12345|3]";
			treeNode37.Name = "node_0123_01234";
			treeNode37.Text = "Blinkyworld [0123|01234]";
			treeNode38.Name = "Knoten18";
			treeNode38.Text = "Other";
			this.tree_data.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35,
            treeNode36,
            treeNode37,
            treeNode38});
			this.tree_data.Size = new System.Drawing.Size(386, 204);
			this.tree_data.TabIndex = 2;
			this.tree_data.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_data_AfterSelect);
			// 
			// btn_browse
			// 
			this.btn_browse.Location = new System.Drawing.Point(319, 18);
			this.btn_browse.Name = "btn_browse";
			this.btn_browse.Size = new System.Drawing.Size(61, 23);
			this.btn_browse.TabIndex = 3;
			this.btn_browse.Text = "Browse";
			this.btn_browse.UseVisualStyleBackColor = true;
			// 
			// txt_path
			// 
			this.txt_path.Location = new System.Drawing.Point(46, 19);
			this.txt_path.Name = "txt_path";
			this.txt_path.Size = new System.Drawing.Size(267, 22);
			this.txt_path.TabIndex = 4;
			// 
			// lbl_path
			// 
			this.lbl_path.AutoSize = true;
			this.lbl_path.Location = new System.Drawing.Point(6, 22);
			this.lbl_path.Name = "lbl_path";
			this.lbl_path.Size = new System.Drawing.Size(34, 14);
			this.lbl_path.TabIndex = 5;
			this.lbl_path.Text = "Path:";
			// 
			// gb_add
			// 
			this.gb_add.Controls.Add(this.btn_add);
			this.gb_add.Controls.Add(this.lbl_path);
			this.gb_add.Controls.Add(this.btn_browse);
			this.gb_add.Controls.Add(this.txt_path);
			this.gb_add.Location = new System.Drawing.Point(12, 12);
			this.gb_add.Name = "gb_add";
			this.gb_add.Size = new System.Drawing.Size(386, 75);
			this.gb_add.TabIndex = 6;
			this.gb_add.TabStop = false;
			this.gb_add.Text = "Add to TreeView";
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(319, 47);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(61, 23);
			this.btn_add.TabIndex = 6;
			this.btn_add.Text = "Add";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// LoadForm
			// 
			this.AcceptButton = this.btn_apply;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(411, 338);
			this.Controls.Add(this.gb_add);
			this.Controls.Add(this.tree_data);
			this.Controls.Add(this.btn_apply);
			this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "LoadForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "LoadForm";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.LoadForm_Load);
			this.gb_add.ResumeLayout(false);
			this.gb_add.PerformLayout();
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Button btn_apply;
		internal System.Windows.Forms.TreeView tree_data;
		internal System.Windows.Forms.Button btn_browse;
		internal System.Windows.Forms.TextBox txt_path;
		internal System.Windows.Forms.Label lbl_path;
		internal System.Windows.Forms.GroupBox gb_add;
		internal System.Windows.Forms.Button btn_add;


        #endregion
    }
}