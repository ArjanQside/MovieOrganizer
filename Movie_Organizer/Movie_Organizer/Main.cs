using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Organizer
{
    //LOLOLOLOLOLOLLOLOLOOLOOLOL
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        //this will be the list of folder paths and clear names of the movies and tvshow
        IDictionary<string, string> NameAndFolderPath = new Dictionary<string, string>();
        
        //load form
        private void Form1_Load(object sender, EventArgs e)
        {
            //als het bestand "folderPath.txt" niet bestaat in de debug folder dan maakt hij die aan.
            while (Properties.Settings.Default.BaseFolder == "")
                newBaseFolder();
            //Load Content background image
            ContentPanel.BackgroundImage = Image.FromFile(Properties.Settings.Default.BackgroundImage);
            //Load Profile Picture
            pfPicture.Image = Image.FromFile(Properties.Settings.Default.ProfilePicture);
            //Load sidebar color
            SideBar.BackColor = Color.FromArgb(Properties.Settings.Default.SideBar);
            //laad home
            loadHome();

        }


        //Change background of Content
        private void changeBG_Click(object sender, EventArgs e)
        {
            var layout = new Movie_Organizer.Layout();
            layout.chooseBG();
            ContentPanel.BackgroundImage = Image.FromFile(Properties.Settings.Default.BackgroundImage);
        }      
        //Quit program
        private void QuitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }       
        //Edit profile picture
        private void ProfilePictureEdit_Click(object sender, EventArgs e)
        {
            var layout = new Movie_Organizer.Layout();
            layout.chooseProfilePicture();
            pfPicture.Image = Image.FromFile(Properties.Settings.Default.ProfilePicture);
        }    
        //Delete current profile picture
        private void DeleteProfileImage_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ProfilePicture = "pf.png";
            Properties.Settings.Default.Save();
            pfPicture.Image = Image.FromFile(Properties.Settings.Default.ProfilePicture);
        }      
        //Edit color of the SideBar
        private void SideBarColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                int color = dialog.Color.ToArgb();
                Properties.Settings.Default.SideBar = color;
                Properties.Settings.Default.Save();
                SideBar.BackColor = Color.FromArgb(color);
            }
        }
        //ChooseFolderButton click event
        private void ChooseFolderButton_Click(object sender, EventArgs e)
        {
            newBaseFolder();
        }        
        //Method for new baseFolder
        private void newBaseFolder()
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.BaseFolder = dialog.SelectedPath;
                Properties.Settings.Default.Save();
                loadHome();
            }
        }
        //load home
        private void loadHome(){

        }
        //Left click event on item in listbox
        private void ItemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Title.Text = ItemBox.GetItemText(ItemBox.SelectedItem);
            Title.Visible = true;
            SummaryText.Text = "Deze video/serie is nog niet gevonden door het programme. zoek de video/serie door er met uw rechter muis knop op te klikken";
            SummaryText.Visible = true;
            string name = ItemBox.GetItemText(ItemBox.SelectedItem);
            string NFOFilePath = NameAndFolderPath[name] + "\\movie.nfo";
            if (File.Exists(NFOFilePath)) {
                Movie m = NFO.ReadMovieNFO(NFOFilePath);
                SummaryText.Text = m.summary;
                ItemPicture.Visible = true;
                ItemPicture.Image = Image.FromFile(NameAndFolderPath[name] + "\\movie.jpg");
            }
        }
        //Right click event on item in listbox
        private void ItemBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var item = ItemBox.IndexFromPoint(e.Location);
                if (item >= 0)
                {
                    ItemBox.SelectedIndex = item;
                    ItemBoxMenuStrip.Show(ItemBox, e.Location);
                }
            }
        }

        private void SearchMovieMenuItem_Click(object sender, EventArgs e)
        {
            string name = (ItemBox.GetItemText(ItemBox.SelectedItem));
            var NameAndPath = new KeyValuePair<string, string>(name, NameAndFolderPath[name]);
            Form f = new SearchForm(NameAndPath);
            f.Show();   
        }

        private void DeleteMovieMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            NameAndFolderPath.Clear();
            ItemBox.Items.Clear();
            //maak een lijstje van alle folders in de basis folder
            string baseFolder = Properties.Settings.Default.BaseFolder;
            //zoek alle mappe in de basefolder
            var foldersInBase = Directory.GetDirectories(baseFolder, "*", SearchOption.TopDirectoryOnly);

            foreach (string folder in foldersInBase)
            {
                var name = folder.Substring(folder.LastIndexOf('\\') + 1);
                var cleanName = Extractor.ExtractMovieName(name);
                NameAndFolderPath[cleanName] = folder;
            }
            string caseSwitch = (sender as Button).Name;
            switch (caseSwitch)
            {
                case "UnassignedButton":
                    foreach (var items in NameAndFolderPath)
                    if (!File.Exists(items.Value + "\\movie.nfo") && !File.Exists(items.Value + "\\tvshow.nfo"))
                    {
                        ItemBox.Items.Add(items.Key);
                    }
                    break;
                case "MoviesButton":
                    foreach (var items in NameAndFolderPath)
                        if (File.Exists(items.Value + "\\movie.nfo"))
                        {
                            ItemBox.Items.Add(items.Key);
                        }
                    break;
                case "TvShowsButton":
                    foreach (var items in NameAndFolderPath)
                        if(File.Exists(items.Value + "\\tvshow.nfo"))
                        {
                            ItemBox.Items.Add(items.Key);
                        }
                    break;

            }
        }
    }
}
