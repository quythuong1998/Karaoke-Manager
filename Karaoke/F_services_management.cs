using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Karaoke
{
    public partial class F_services_management : MetroFramework.Forms.MetroForm
    {
        public F_services_management()
        {
            InitializeComponent();
            Load_Room();
        }

        private void F_services_management_Load(object sender, EventArgs e)
        {



        }
        void Load_Room()
        {
            flowLayoutPanel_ROOM.Controls.Clear();
            List<DTO.RoomDTO> listroom = RoomBUS.GetRooms();
            int TableWidth = 370;
            int TableHeight = 175;

            foreach (DTO.RoomDTO item in listroom)
            {
                MetroFramework.Controls.MetroTile titRoom = new MetroFramework.Controls.MetroTile() { Width = TableWidth, Height = TableHeight };
                flowLayoutPanel_ROOM.Controls.Add(titRoom);
                titRoom.Theme = MetroFramework.MetroThemeStyle.Light;

                titRoom.UseTileImage = true;
                titRoom.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                titRoom.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
                //Button Btn = new Button() { Width = TableWidth, Height = TableHeight };
                //flowLayoutPanel_Room.Controls.Add(Btn);

                

                string stt = "";
                if (item.Status == 0)
                {
                    stt = "Available";
                }
                else if(item.Status == 1)
                {
                    stt = "Active";
                }
                else
                {
                    stt = "Fixing";
                }

                titRoom.Text = item.Name + Environment.NewLine + stt;



                titRoom.Click += titRoom_Click;
                titRoom.Tag = item; //luu cai room cua minh vo tag, no la kiiu du lieu obj

                switch (item.Status)
                {
                    case 0:
                        titRoom.Style = MetroFramework.MetroColorStyle.Green;
                        titRoom.TileImage = global::Karaoke.Properties.Resources.room;
                        break;
                    case 2:
                        titRoom.Style = MetroFramework.MetroColorStyle.Silver;
                        titRoom.TileImage = global::Karaoke.Properties.Resources.fix;
                        break;
                    default:
                        titRoom.Style = MetroFramework.MetroColorStyle.Orange;
                        titRoom.TileImage = global::Karaoke.Properties.Resources.kara;
                        break;
                }

                if (item.Kind_Of_Room == 1)
                {
                    titRoom.TileImage = global::Karaoke.Properties.Resources.vip;
                }
            }
        }

        private void titRoom_Click(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile tit = sender as MetroFramework.Controls.MetroTile;
            idCurrent = (tit.Tag as DTO.RoomDTO).IdRoom;
            metroTextBox_id.Text = ((tit.Tag as DTO.RoomDTO).IdRoom).ToString();
            metroTextBox_id.Enabled = false;

            metroTextBox_name.Text = ((tit.Tag as DTO.RoomDTO).Name).ToString();

            //CultureInfo culture = new CultureInfo("vi-VN");
            metroTextBox_price.Text  = ((tit.Tag as DTO.RoomDTO).Price).ToString();

            int kind = (tit.Tag as DTO.RoomDTO).Kind_Of_Room;
            if (kind == 1)
            {
                metroRadioButton_roomPremium.Checked = true;
            }
            else
            {
                metroRadioButton_roomNormal.Checked = true;
            }

           

            int status = (tit.Tag as DTO.RoomDTO).Status;
            if (status == 0)
            {
                metroRadioButton_Available .Checked = true;
            }
            else if(status == 1)
            {
                metroRadioButton_NotAvailable.Checked = true;
            }
            else
            {
                metroRadioButton_Fixing.Checked = true;
            }

            

        }

        

        

        private void metroTile_add_Click(object sender, EventArgs e)
        {
            if (metroTextBox_name.Text == "")
            {
                MessageBox.Show("Please input room's name !");
                return;
            }

            
            DTO.RoomDTO r = new DTO.RoomDTO();
            r.Name = metroTextBox_name.Text;
            if (metroRadioButton_Available.Checked == true)
            {
                r.Status  = 0;
            }
            else if(metroRadioButton_NotAvailable.Checked == true)
            {
                r.Status = 1;
            }
            else
            {
                r.Status = 2;
            }

            if(metroRadioButton_roomNormal.Checked == true)
            {
                r.Kind_Of_Room = 0;
            }
            else
            {
                r.Kind_Of_Room = 1;
            }

            r.Price = int.Parse(metroTextBox_price.Text);

            if (RoomBUS.AddRoom(r) == false)
            {
                MessageBox.Show("Can't add this room !");
                return;
            }           
            MessageBox.Show("Room was added !");
            Load_Room();
        }

        private void metroTile_BACK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        private void metroTile_Edit_Click(object sender, EventArgs e)
        {

            if (metroTextBox_name.Text == "")
            {
                MessageBox.Show("Please input room's name !");
                return;
            }


            DTO.RoomDTO r = new DTO.RoomDTO();
            r.IdRoom = int.Parse(metroTextBox_id.Text);
            r.Name = metroTextBox_name.Text;
            if (metroRadioButton_Available.Checked == true)
            {
                r.Status = 0;
            }
            else if (metroRadioButton_NotAvailable.Checked == true)
            {
                r.Status = 1;
            }
            else
            {
                r.Status = 2;
            }

            if (metroRadioButton_roomNormal.Checked == true)
            {
                r.Kind_Of_Room = 0;
            }
            else
            {
                r.Kind_Of_Room = 1;
            }

            r.Price = int.Parse(metroTextBox_price.Text);

            if (RoomBUS.EditRoom(r) == true)
            {
                MessageBox.Show("Room was updated !");
                Load_Room();
            }
            else
            {
                MessageBox.Show("Can't update this room !");
            }
        }


        int idCurrent;

        private void metroTile_Delete_Click(object sender, EventArgs e)
        {
        
            if (RoomBUS.DeleteRoom(idCurrent) == true)
            {
                MessageBox.Show("Room was deleted !");
                Load_Room();
            }
            else
            {
                MessageBox.Show("Can't delete this room !");
            }
        }
    }
}
