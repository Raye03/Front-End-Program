namespace Beta_conection_to_sql_server
{
    partial class main_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_page));
            this.Save_Page_button = new System.Windows.Forms.Button();
            this.Databasesearch_page_button = new System.Windows.Forms.Button();
            this.Title_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Save_Page_button
            // 
            this.Save_Page_button.Location = new System.Drawing.Point(111, 302);
            this.Save_Page_button.Margin = new System.Windows.Forms.Padding(2);
            this.Save_Page_button.Name = "Save_Page_button";
            this.Save_Page_button.Size = new System.Drawing.Size(89, 35);
            this.Save_Page_button.TabIndex = 0;
            this.Save_Page_button.Text = "Save Page";
            this.Save_Page_button.UseVisualStyleBackColor = true;
            this.Save_Page_button.Click += new System.EventHandler(this.Save_Page_button_Click);
            // 
            // Databasesearch_page_button
            // 
            this.Databasesearch_page_button.Location = new System.Drawing.Point(265, 302);
            this.Databasesearch_page_button.Margin = new System.Windows.Forms.Padding(2);
            this.Databasesearch_page_button.Name = "Databasesearch_page_button";
            this.Databasesearch_page_button.Size = new System.Drawing.Size(75, 35);
            this.Databasesearch_page_button.TabIndex = 1;
            this.Databasesearch_page_button.Text = "Database Search";
            this.Databasesearch_page_button.UseVisualStyleBackColor = true;
            this.Databasesearch_page_button.Click += new System.EventHandler(this.Databaseview_page_button_Click);
            // 
            // Title_label
            // 
            this.Title_label.AutoSize = true;
            this.Title_label.Location = new System.Drawing.Point(212, 9);
            this.Title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title_label.Name = "Title_label";
            this.Title_label.Size = new System.Drawing.Size(140, 13);
            this.Title_label.TabIndex = 2;
            this.Title_label.Text = "Beta Bid System Caclutation";
            this.Title_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(403, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 251);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(730, 487);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Title_label);
            this.Controls.Add(this.Databasesearch_page_button);
            this.Controls.Add(this.Save_Page_button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "main_page";
            this.Text = "main_page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_Page_button;
        private System.Windows.Forms.Button Databasesearch_page_button;
        private System.Windows.Forms.Label Title_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}