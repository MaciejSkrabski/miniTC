namespace MiniTC
{
    partial class miniTCPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.path = new System.Windows.Forms.TextBox();
            this.drives = new System.Windows.Forms.ComboBox();
            this.files = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(3, 3);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(335, 20);
            this.path.TabIndex = 0;
            this.path.TextChanged += new System.EventHandler(this.path_TextChanged);
            // 
            // drives
            // 
            this.drives.FormattingEnabled = true;
            this.drives.Location = new System.Drawing.Point(251, 29);
            this.drives.Name = "drives";
            this.drives.Size = new System.Drawing.Size(87, 21);
            this.drives.TabIndex = 1;
            this.drives.SelectedIndexChanged += new System.EventHandler(this.drives_SelectedIndexChanged);
            // 
            // files
            // 
            this.files.FormattingEnabled = true;
            this.files.Location = new System.Drawing.Point(4, 52);
            this.files.Name = "files";
            this.files.Size = new System.Drawing.Size(334, 342);
            this.files.TabIndex = 2;
            this.files.SelectedIndexChanged += new System.EventHandler(this.files_SelectedIndexChanged);
            // 
            // miniTCPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.files);
            this.Controls.Add(this.drives);
            this.Controls.Add(this.path);
            this.Name = "miniTCPanel";
            this.Size = new System.Drawing.Size(341, 395);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.ComboBox drives;
        private System.Windows.Forms.ListBox files;
    }
}
