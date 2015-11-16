using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Organizer
{
    class Layout
    {
        /// <summary>
        /// Choose a background image.
        /// </summary>
        public void chooseBG()
        {
            OpenFileDialog bgImage = new OpenFileDialog();
            bgImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            DialogResult result = bgImage.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.BackgroundImage = bgImage.FileName;
                Properties.Settings.Default.Save(); // Saves settings in application configuration file
            }
        }
        
        /// <summary>
        /// Choose a profile picture.
        /// </summary>
        public void chooseProfilePicture()
        {
            OpenFileDialog Image = new OpenFileDialog();
            Image.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            DialogResult result = Image.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.ProfilePicture = Image.FileName;
                Properties.Settings.Default.Save(); // Saves settings in application configuration file
            }
        }
    }
}
