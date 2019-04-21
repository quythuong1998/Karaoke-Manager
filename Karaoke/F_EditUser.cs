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
    public partial class F_EditUser : MetroFramework.Forms.MetroForm
    {
        public F_EditUser()
        {
            InitializeComponent();
            Load_Users();
        }

        void Load_Users()
        {
            List<DTO.User_DTO> listUsers = BUS.User_BUS.GetAllUsers();
            int TableWidth = 490;
            int TableHeight = 150;

            //MessageBox.Show(listKind.Count.ToString());
            flowLayoutPanel_Users.Controls.Clear();
            foreach (DTO.User_DTO item in listUsers)
            {
                MetroFramework.Controls.MetroTile tit_User = new MetroFramework.Controls.MetroTile() { Width = TableWidth, Height = TableHeight };
                flowLayoutPanel_Users.Controls.Add(tit_User);
                tit_User.Theme = MetroFramework.MetroThemeStyle.Light;
                tit_User.UseTileImage = true;
                tit_User.Style = MetroFramework.MetroColorStyle.Yellow;
                tit_User.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                tit_User.TileImage = global::Karaoke.Properties.Resources.user_normal;
                tit_User.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
                tit_User.Text = "ID: " + item.Id + Environment.NewLine + "Name: " +item.NameUser + Environment.NewLine + "Permission: "+ item.NamePermission;
                tit_User.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
                tit_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                if(item.NamePermission.ToString() == "ADMIN")
                {
                    tit_User.TileImage = global::Karaoke.Properties.Resources.user_admin;
                }
                                
                tit_User.Click += tit_User_Click;
                tit_User.Tag = item;


            }
        }

        private void tit_User_Click(object sender, EventArgs e)
        {
           // u.id_User, u.username, u.password, u.nameUser, p.name_Permission
            MetroFramework.Controls.MetroTile tit = sender as MetroFramework.Controls.MetroTile;
            metroTextBox_ID.Text = ((tit.Tag as DTO.User_DTO).Id).ToString();
            metroTextBox_nameUser.Text = ((tit.Tag as DTO.User_DTO).NameUser).ToString();
            metroTextBox_userName.Text = ((tit.Tag as DTO.User_DTO).Username).ToString();
            metroTextBox_password.Text = "***";
            //int idPermission = ();
            if((tit.Tag as DTO.User_DTO).Permission == 1)
            {
                metroRadioButton_admin.Checked = true;             
            }
            else
            {
                metroRadioButton_staff.Checked = true;
            }
        }

        private void F_EditUser_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void metroTile_addUser_Click(object sender, EventArgs e)
        {
            if (metroTextBox_userName.Text == "")
            {
                MessageBox.Show("Please input username !");
                return;
            }

            if (metroTextBox_nameUser.Text == "")
            {
                MessageBox.Show("Please input user's name !");
                return;
            }


            DTO.User_DTO u = new DTO.User_DTO();
            u.Username = metroTextBox_userName.Text;
            u.NameUser = metroTextBox_nameUser.Text;

            if (metroRadioButton_admin.Checked == true)
            {
                u.Permission = 1;
            }
            else
            {
                u.Permission = 2;
            }

            if (BUS.User_BUS.AddUser(u) == false)
            {
                MessageBox.Show("Can't add this user !");
                return;
            }
            MessageBox.Show("User was added !" + Environment.NewLine + Environment.NewLine + "Username: " + metroTextBox_userName.Text + Environment.NewLine + "Default password: 123" + Environment.NewLine + "Remember change your password at the first login.");
            Load_Users();
        }

        private void metroTextBox_Permission_Click(object sender, EventArgs e)
        {

        }

        private void metroTile_DeleteUser_Click(object sender, EventArgs e)
        {
            DTO.User_DTO u = new DTO.User_DTO();
            u.Id = int.Parse(metroTextBox_ID.Text);
            if (BUS.User_BUS.DeleteUser(u) == true)
            {
                MessageBox.Show("User was deleted !");
                Load_Users();
            }
            else
            {
                MessageBox.Show("Can't delete this User !");
            }
        }

        private void metroTile_ChangePW_Click(object sender, EventArgs e)
        {
            //980 //1290
            this.ClientSize = new System.Drawing.Size(1290, 654);           
        }

        private void metroTile_comfirmChangePW_Click(object sender, EventArgs e)
        {
            
            string newPW = metroTextBox_newPW.Text;
            int id = int.Parse(metroTextBox_ID.Text);

            if(BUS.User_BUS.ChangePassword(newPW, id) == true)
            {
                MessageBox.Show("Password was updated !");
                Load_Users();
            }
            else
            {
                MessageBox.Show("Can't change password !");
            }
            this.ClientSize = new System.Drawing.Size(980, 654);

        }
    }
}
