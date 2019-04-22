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
    public partial class F_Main : MetroFramework.Forms.MetroForm
    {
        public string nameUserCurrent;
        public int permissionUserCurent;

        public F_Main()
        {
            InitializeComponent();
        }

        private void F_Main_Load(object sender, EventArgs e)
        {
            //F_Login lg = new F_Login();
            lb_loginas.Text = "Login as: " + nameUserCurrent.ToString();

            if(permissionUserCurent != 1)
            {
                metroTile_SERVICES_MANAGEMENT.Enabled = false;
                metroTile_SERVICES_MANAGEMENT.Text = "SERVICES MANAGEMENT" + Environment.NewLine + "you do not have access";
                metroTile_SERVICES_MANAGEMENT.Style = MetroFramework.MetroColorStyle.Silver;

                metroTile_editUser.Enabled = false;
                metroTile_editUser.Text = "USERS MAMAGEMENT" + Environment.NewLine + "you do not have access";
                metroTile_editUser.Style = MetroFramework.MetroColorStyle.Silver;

                metroTile_BackUpAndRestore.Enabled = false;
                metroTile_BackUpAndRestore.Text = "BACKUP AND RESTORE" + Environment.NewLine + "you do not have access";
                metroTile_BackUpAndRestore.Style = MetroFramework.MetroColorStyle.Silver;
                
            }
        }

        private void metroTile_karaokeManager_Click(object sender, EventArgs e)
        {
            F_Karaoke k = new F_Karaoke();
            k.Show();
            
        }

        private void metroTile_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTile_SERVICES_MANAGEMENT_Click(object sender, EventArgs e)
        {
            F_services_management f = new F_services_management();
            f.ShowDialog();
        }

        private void metroTile_REPORTS_Click(object sender, EventArgs e)
        {
            F_Report f = new F_Report();
            f.ShowDialog();
        }

        private void metroTile_editUser_Click(object sender, EventArgs e)
        {
            F_EditUser f = new F_EditUser();
            f.ShowDialog();
        }

        private void metroTile_BackUpAndRestore_Click(object sender, EventArgs e)
        {
            F_BackUpAndRestore f = new F_BackUpAndRestore();
            f.ShowDialog();
        }

        private void metroTile_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            F_Login f = new F_Login();
            f.ShowDialog();
        }
    }
}
