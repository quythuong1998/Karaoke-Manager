using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke
{
    public partial class F_BackUpAndRestore : MetroFramework.Forms.MetroForm
    {
        public F_BackUpAndRestore()
        {
            InitializeComponent();
        }

        private void F_BackUpAndRestore_Load(object sender, EventArgs e)
        {
            
        }

        private void metroTile_restore_Click(object sender, EventArgs e)
        {
            OpenFileDialog pathFolder = new OpenFileDialog();
            pathFolder.Filter = "*.bak|*.bak";
            pathFolder.Title = "Select file to restore (.bak)";
            if (pathFolder.ShowDialog() == DialogResult.OK &&
            pathFolder.CheckFileExists == true)
            {
                string path = pathFolder.FileName;
                if (BUS.BackUpAndRestore_BUS.Restore(path) == true)
                    MessageBox.Show("Restore Successfully !");
                else
                    MessageBox.Show("Can't restore!");
            }
        }

        private void metroTile_BackUp_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog pathFolder = new FolderBrowserDialog();
            pathFolder.Description = "Select the save path";
            if (pathFolder.ShowDialog() == DialogResult.OK)
            {
                string path = pathFolder.SelectedPath;
                if (BUS.BackUpAndRestore_BUS.Backup(path) == true)
                    MessageBox.Show("Backup Successfully, file was saved at " + path);
                else
                    MessageBox.Show("Can't backup !" + Environment.NewLine + "You can try again by re-select path to save file");
            }
        }
    }
}
