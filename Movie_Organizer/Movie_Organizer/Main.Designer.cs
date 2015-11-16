namespace Movie_Organizer
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.SideBar = new System.Windows.Forms.Panel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.UnassignedButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.TvShowsButton = new System.Windows.Forms.Button();
            this.MoviesButton = new System.Windows.Forms.Button();
            this.pfPicture = new System.Windows.Forms.PictureBox();
            this.ProfileContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.bestandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiesMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.afluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opmaakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.achtergondToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sideBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profielPlaatjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemBoxMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SearchMovieMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMovieMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContentPanel = new Movie_Organizer.MyPanel();
            this.GenresText = new System.Windows.Forms.Label();
            this.GenresLabel = new System.Windows.Forms.Label();
            this.SummaryText = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemBox = new System.Windows.Forms.ListBox();
            this.ItemPicture = new System.Windows.Forms.PictureBox();
            this.SideBar.SuspendLayout();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pfPicture)).BeginInit();
            this.ProfileContextMenu.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.ItemBoxMenuStrip.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.White;
            this.SideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SideBar.Controls.Add(this.ButtonPanel);
            this.SideBar.Controls.Add(this.pfPicture);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 24);
            this.SideBar.Margin = new System.Windows.Forms.Padding(0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(200, 580);
            this.SideBar.TabIndex = 1;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonPanel.Controls.Add(this.UnassignedButton);
            this.ButtonPanel.Controls.Add(this.QuitButton);
            this.ButtonPanel.Controls.Add(this.TvShowsButton);
            this.ButtonPanel.Controls.Add(this.MoviesButton);
            this.ButtonPanel.Location = new System.Drawing.Point(0, 377);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(200, 201);
            this.ButtonPanel.TabIndex = 4;
            // 
            // UnassignedButton
            // 
            this.UnassignedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UnassignedButton.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnassignedButton.Location = new System.Drawing.Point(0, 1);
            this.UnassignedButton.Margin = new System.Windows.Forms.Padding(0);
            this.UnassignedButton.Name = "UnassignedButton";
            this.UnassignedButton.Size = new System.Drawing.Size(200, 50);
            this.UnassignedButton.TabIndex = 0;
            this.UnassignedButton.Text = "Unassigned";
            this.UnassignedButton.UseVisualStyleBackColor = true;
            this.UnassignedButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.QuitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuitButton.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.QuitButton.Location = new System.Drawing.Point(0, 151);
            this.QuitButton.Margin = new System.Windows.Forms.Padding(0);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(200, 50);
            this.QuitButton.TabIndex = 3;
            this.QuitButton.Text = "Afsluiten";
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // TvShowsButton
            // 
            this.TvShowsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TvShowsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TvShowsButton.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TvShowsButton.Location = new System.Drawing.Point(0, 101);
            this.TvShowsButton.Margin = new System.Windows.Forms.Padding(0);
            this.TvShowsButton.Name = "TvShowsButton";
            this.TvShowsButton.Size = new System.Drawing.Size(200, 50);
            this.TvShowsButton.TabIndex = 1;
            this.TvShowsButton.Text = "Series";
            this.TvShowsButton.UseVisualStyleBackColor = true;
            this.TvShowsButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // MoviesButton
            // 
            this.MoviesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MoviesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoviesButton.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Bold);
            this.MoviesButton.Location = new System.Drawing.Point(0, 51);
            this.MoviesButton.Margin = new System.Windows.Forms.Padding(0);
            this.MoviesButton.Name = "MoviesButton";
            this.MoviesButton.Size = new System.Drawing.Size(200, 50);
            this.MoviesButton.TabIndex = 0;
            this.MoviesButton.Text = "Films";
            this.MoviesButton.UseVisualStyleBackColor = true;
            this.MoviesButton.Click += new System.EventHandler(this.Button_Click);
            // 
            // pfPicture
            // 
            this.pfPicture.BackColor = System.Drawing.Color.White;
            this.pfPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pfPicture.ContextMenuStrip = this.ProfileContextMenu;
            this.pfPicture.InitialImage = null;
            this.pfPicture.Location = new System.Drawing.Point(9, 9);
            this.pfPicture.Name = "pfPicture";
            this.pfPicture.Size = new System.Drawing.Size(180, 180);
            this.pfPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pfPicture.TabIndex = 2;
            this.pfPicture.TabStop = false;
            // 
            // ProfileContextMenu
            // 
            this.ProfileContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.ProfileContextMenu.Name = "ProfileContextMenu";
            this.ProfileContextMenu.Size = new System.Drawing.Size(108, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.ProfilePictureEdit_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteProfileImage_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bestandToolStripMenuItem,
            this.opmaakToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // bestandToolStripMenuItem
            // 
            this.bestandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.herladenToolStripMenuItem,
            this.kiesMapToolStripMenuItem,
            this.toolStripSeparator1,
            this.afluitenToolStripMenuItem});
            this.bestandToolStripMenuItem.Name = "bestandToolStripMenuItem";
            this.bestandToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.bestandToolStripMenuItem.Text = "Bestand";
            // 
            // herladenToolStripMenuItem
            // 
            this.herladenToolStripMenuItem.Name = "herladenToolStripMenuItem";
            this.herladenToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.herladenToolStripMenuItem.Text = "Herladen";
            // 
            // kiesMapToolStripMenuItem
            // 
            this.kiesMapToolStripMenuItem.Name = "kiesMapToolStripMenuItem";
            this.kiesMapToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.kiesMapToolStripMenuItem.Text = "Kies Map";
            this.kiesMapToolStripMenuItem.Click += new System.EventHandler(this.ChooseFolderButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(119, 6);
            // 
            // afluitenToolStripMenuItem
            // 
            this.afluitenToolStripMenuItem.Name = "afluitenToolStripMenuItem";
            this.afluitenToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.afluitenToolStripMenuItem.Text = "Afluiten";
            this.afluitenToolStripMenuItem.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // opmaakToolStripMenuItem
            // 
            this.opmaakToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.achtergondToolStripMenuItem,
            this.sideBarToolStripMenuItem,
            this.profielPlaatjeToolStripMenuItem});
            this.opmaakToolStripMenuItem.Name = "opmaakToolStripMenuItem";
            this.opmaakToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.opmaakToolStripMenuItem.Text = "Opmaak";
            // 
            // achtergondToolStripMenuItem
            // 
            this.achtergondToolStripMenuItem.Name = "achtergondToolStripMenuItem";
            this.achtergondToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.achtergondToolStripMenuItem.Text = "Achtergond Plaatje";
            this.achtergondToolStripMenuItem.Click += new System.EventHandler(this.changeBG_Click);
            // 
            // sideBarToolStripMenuItem
            // 
            this.sideBarToolStripMenuItem.Name = "sideBarToolStripMenuItem";
            this.sideBarToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.sideBarToolStripMenuItem.Text = "Side Bar";
            this.sideBarToolStripMenuItem.Click += new System.EventHandler(this.SideBarColor_Click);
            // 
            // profielPlaatjeToolStripMenuItem
            // 
            this.profielPlaatjeToolStripMenuItem.Name = "profielPlaatjeToolStripMenuItem";
            this.profielPlaatjeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.profielPlaatjeToolStripMenuItem.Text = "Profiel Plaatje";
            this.profielPlaatjeToolStripMenuItem.Click += new System.EventHandler(this.ProfilePictureEdit_Click);
            // 
            // ItemBoxMenuStrip
            // 
            this.ItemBoxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SearchMovieMenuItem,
            this.DeleteMovieMenuItem});
            this.ItemBoxMenuStrip.Name = "ItemBoxMenuStrip";
            this.ItemBoxMenuStrip.Size = new System.Drawing.Size(110, 48);
            // 
            // SearchMovieMenuItem
            // 
            this.SearchMovieMenuItem.Name = "SearchMovieMenuItem";
            this.SearchMovieMenuItem.Size = new System.Drawing.Size(109, 22);
            this.SearchMovieMenuItem.Text = "Search";
            this.SearchMovieMenuItem.Click += new System.EventHandler(this.SearchMovieMenuItem_Click);
            // 
            // DeleteMovieMenuItem
            // 
            this.DeleteMovieMenuItem.Name = "DeleteMovieMenuItem";
            this.DeleteMovieMenuItem.Size = new System.Drawing.Size(109, 22);
            this.DeleteMovieMenuItem.Text = "Delete";
            this.DeleteMovieMenuItem.Click += new System.EventHandler(this.DeleteMovieMenuItem_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ContentPanel.Controls.Add(this.GenresText);
            this.ContentPanel.Controls.Add(this.GenresLabel);
            this.ContentPanel.Controls.Add(this.SummaryText);
            this.ContentPanel.Controls.Add(this.Title);
            this.ContentPanel.Controls.Add(this.label1);
            this.ContentPanel.Controls.Add(this.ItemBox);
            this.ContentPanel.Controls.Add(this.ItemPicture);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Location = new System.Drawing.Point(200, 24);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(984, 580);
            this.ContentPanel.TabIndex = 3;
            // 
            // GenresText
            // 
            this.GenresText.AutoSize = true;
            this.GenresText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenresText.Location = new System.Drawing.Point(60, 325);
            this.GenresText.Name = "GenresText";
            this.GenresText.Size = new System.Drawing.Size(71, 18);
            this.GenresText.TabIndex = 9;
            this.GenresText.Text = "Genres...";
            this.GenresText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GenresText.Visible = false;
            // 
            // GenresLabel
            // 
            this.GenresLabel.AutoSize = true;
            this.GenresLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenresLabel.Location = new System.Drawing.Point(60, 292);
            this.GenresLabel.Name = "GenresLabel";
            this.GenresLabel.Size = new System.Drawing.Size(70, 19);
            this.GenresLabel.TabIndex = 8;
            this.GenresLabel.Text = "Genres:";
            this.GenresLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GenresLabel.Visible = false;
            // 
            // SummaryText
            // 
            this.SummaryText.AllowDrop = true;
            this.SummaryText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryText.Location = new System.Drawing.Point(60, 140);
            this.SummaryText.Name = "SummaryText";
            this.SummaryText.Size = new System.Drawing.Size(600, 18);
            this.SummaryText.TabIndex = 7;
            this.SummaryText.Text = "Summary";
            this.SummaryText.Visible = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(50, 50);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(122, 56);
            this.Title.TabIndex = 6;
            this.Title.Text = "Title";
            this.Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(772, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose one:";
            // 
            // ItemBox
            // 
            this.ItemBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemBox.BackColor = System.Drawing.SystemColors.Window;
            this.ItemBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemBox.FormattingEnabled = true;
            this.ItemBox.Location = new System.Drawing.Point(772, 356);
            this.ItemBox.Margin = new System.Windows.Forms.Padding(0);
            this.ItemBox.Name = "ItemBox";
            this.ItemBox.Size = new System.Drawing.Size(200, 210);
            this.ItemBox.TabIndex = 4;
            this.ItemBox.SelectedIndexChanged += new System.EventHandler(this.ItemBox_SelectedIndexChanged);
            this.ItemBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ItemBox_MouseUp);
            // 
            // ItemPicture
            // 
            this.ItemPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemPicture.Location = new System.Drawing.Point(772, 10);
            this.ItemPicture.Name = "ItemPicture";
            this.ItemPicture.Size = new System.Drawing.Size(200, 300);
            this.ItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ItemPicture.TabIndex = 0;
            this.ItemPicture.TabStop = false;
            this.ItemPicture.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 604);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.menuStrip);
            this.MinimumSize = new System.Drawing.Size(1200, 643);
            this.Name = "Main";
            this.Text = "Movie Organizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SideBar.ResumeLayout(false);
            this.ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pfPicture)).EndInit();
            this.ProfileContextMenu.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ItemBoxMenuStrip.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.PictureBox pfPicture;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem bestandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opmaakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herladenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiesMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem achtergondToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sideBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profielPlaatjeToolStripMenuItem;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Button TvShowsButton;
        private System.Windows.Forms.Button MoviesButton;
        private System.Windows.Forms.ContextMenuStrip ProfileContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Button UnassignedButton;
        private MyPanel ContentPanel;
        private System.Windows.Forms.PictureBox ItemPicture;
        private System.Windows.Forms.ListBox ItemBox;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label GenresText;
        private System.Windows.Forms.Label GenresLabel;
        private System.Windows.Forms.Label SummaryText;
        private System.Windows.Forms.ContextMenuStrip ItemBoxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem SearchMovieMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteMovieMenuItem;
    }
}

