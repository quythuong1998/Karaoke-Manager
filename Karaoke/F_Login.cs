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
    public partial class F_Login : MetroFramework.Forms.MetroForm
    {
        public F_Login()
        {
            InitializeComponent();
        }

        private void F_Login_Load(object sender, EventArgs e)
        {

        }

        //public string nameUserCurrent;
        //public int permissionUserCurent;
       
        private void metroTile_login_Click(object sender, EventArgs e)
        {


            
            string userName = textBoxID.Text;
            string passWord = textBoxPass.Text;

            F_Main m = new F_Main();
            
            if(textBoxID.Text == "" || textBoxPass.Text == "")
            {
                MessageBox.Show("Please type full information !");
                return;
            }

            if (BUS.User_BUS.Login(userName, passWord) == true)
            {

                List<DTO.User_DTO> user = BUS.User_BUS.GetUser(userName, passWord);
                foreach (DTO.User_DTO item in user)
                {
                    m.nameUserCurrent = item.NameUser;
                    m.permissionUserCurent = item.Permission;                   
                }

                MessageBox.Show("Login Successfully !");
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password or Your account has not exist !");
            }

        }
    
    }
}
