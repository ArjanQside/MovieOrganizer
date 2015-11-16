namespace Movie_Organizer
{
    partial class SearchForm
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
            this.MovieResultBox = new System.Windows.Forms.ListBox();
            this.SearchCancelButton = new System.Windows.Forms.Button();
            this.SearchOkButton = new System.Windows.Forms.Button();
            this.TVShowResultBox = new System.Windows.Forms.ListBox();
            this.SearchTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SearchTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovieResultBox
            // 
            this.MovieResultBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieResultBox.FormattingEnabled = true;
            this.MovieResultBox.Location = new System.Drawing.Point(3, 3);
            this.MovieResultBox.Name = "MovieResultBox";
            this.MovieResultBox.Size = new System.Drawing.Size(236, 218);
            this.MovieResultBox.TabIndex = 0;
            // 
            // SearchCancelButton
            // 
            this.SearchCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SearchCancelButton.Location = new System.Drawing.Point(12, 267);
            this.SearchCancelButton.Name = "SearchCancelButton";
            this.SearchCancelButton.Size = new System.Drawing.Size(85, 32);
            this.SearchCancelButton.TabIndex = 2;
            this.SearchCancelButton.Text = "Annuleren";
            this.SearchCancelButton.UseVisualStyleBackColor = true;
            this.SearchCancelButton.Click += new System.EventHandler(this.SearchCancelButton_Click);
            // 
            // SearchOkButton
            // 
            this.SearchOkButton.Location = new System.Drawing.Point(147, 267);
            this.SearchOkButton.Name = "SearchOkButton";
            this.SearchOkButton.Size = new System.Drawing.Size(85, 32);
            this.SearchOkButton.TabIndex = 3;
            this.SearchOkButton.Text = "OK";
            this.SearchOkButton.Click += new System.EventHandler(this.SearchOkButton_Click);
            // 
            // TVShowResultBox
            // 
            this.TVShowResultBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TVShowResultBox.FormattingEnabled = true;
            this.TVShowResultBox.Location = new System.Drawing.Point(3, 3);
            this.TVShowResultBox.Name = "TVShowResultBox";
            this.TVShowResultBox.Size = new System.Drawing.Size(236, 218);
            this.TVShowResultBox.TabIndex = 4;
            // 
            // SearchTab
            // 
            this.SearchTab.Controls.Add(this.tabPage1);
            this.SearchTab.Controls.Add(this.tabPage2);
            this.SearchTab.Location = new System.Drawing.Point(0, 0);
            this.SearchTab.Name = "SearchTab";
            this.SearchTab.SelectedIndex = 0;
            this.SearchTab.Size = new System.Drawing.Size(250, 250);
            this.SearchTab.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MovieResultBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(242, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Films";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TVShowResultBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(242, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Series";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.SearchCancelButton;
            this.ClientSize = new System.Drawing.Size(249, 311);
            this.Controls.Add(this.SearchTab);
            this.Controls.Add(this.SearchOkButton);
            this.Controls.Add(this.SearchCancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchForm";
            this.Text = "Kies jouw Film/Serie";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.SearchTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox MovieResultBox;
        private System.Windows.Forms.Button SearchCancelButton;
        private System.Windows.Forms.Button SearchOkButton;
        private System.Windows.Forms.ListBox TVShowResultBox;
        private System.Windows.Forms.TabControl SearchTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}