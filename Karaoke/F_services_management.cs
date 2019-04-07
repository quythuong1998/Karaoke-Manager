using BUS;
using DTO;
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
            Load_Kind();
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
            idRoomCurrent = (tit.Tag as DTO.RoomDTO).IdRoom;
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


        int idRoomCurrent;

        private void metroTile_Delete_Click(object sender, EventArgs e)
        {
        
            if (RoomBUS.DeleteRoom(idRoomCurrent) == true)
            {
                MessageBox.Show("Room was deleted !");
                Load_Room();
            }
            else
            {
                MessageBox.Show("Can't delete this room because it's being used !");
            }
        }

        void Load_Kind()
        {
            List<DTO.Kind_DTO> listKind = Kind_BUS.Getkinds();
            int TableWidth = 323;
            int TableHeight = 150;

            //MessageBox.Show(listKind.Count.ToString());

            foreach (DTO.Kind_DTO item in listKind)
            {
                MetroFramework.Controls.MetroTile tit_kind = new MetroFramework.Controls.MetroTile() { Width = TableWidth, Height = TableHeight };
                flowLayoutPanel_Service.Controls.Add(tit_kind);
                tit_kind.Theme = MetroFramework.MetroThemeStyle.Light;
                tit_kind.UseTileImage = true;
                tit_kind.Style = MetroFramework.MetroColorStyle.Green;
                tit_kind.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                //tit_kind.TileImage = global::Karaoke.Properties.Resources.wine;
                tit_kind.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
                tit_kind.Text = item.Name;
                tit_kind.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;

                tit_kind.Click += tit_kind_Click;
                tit_kind.Tag = item;


            }
        }

        void Load_Menu_By_ID(int id)
        {
            flowLayoutPanel_ServicesInfo.Controls.Clear();
            List<DTO.Menu_DTO> listMenu = menu_BUS.GetMenus(id);
            //MessageBox.Show(listMenu.Count.ToString());
            int TableWidth = 144;
            int TableHeight = 100;

            foreach (DTO.Menu_DTO item in listMenu)
            {
                MetroFramework.Controls.MetroTile tit_Item = new MetroFramework.Controls.MetroTile() { Width = TableWidth, Height = TableHeight };
                flowLayoutPanel_ServicesInfo.Controls.Add(tit_Item);
                tit_Item.Theme = MetroFramework.MetroThemeStyle.Light;
                tit_Item.UseTileImage = true;
                tit_Item.Style = MetroFramework.MetroColorStyle.Teal;
                tit_Item.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                tit_Item.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
                tit_Item.Text = item.Name + Environment.NewLine + "Amout: " + item.Amout;

                tit_Item.Click += tit_Item_Click;
                tit_Item.Tag = item;
            }
        }


        
        public void tit_kind_Click(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile tit = sender as MetroFramework.Controls.MetroTile;
            int idKind = (tit.Tag as Kind_DTO).Id;
            Load_Menu_By_ID(idKind);
            //idKindCurent = idKind;
            //string title = ((sender as MetroFramework.Controls.MetroTile).Tag as Kind_DTO).Name;
            //metroLabel_tit.Text = "List of " + title;

            metroTextBox_IdKindOfMenu.Clear();
            metroTextBox_IDMenu.Clear();
            metroTextBox_NameMenu.Clear();
            metroTextBox_PriceMenu.Clear();
            metroTextBox_AmoutMenu.Clear();

            
        }

       
        private void tit_Item_Click(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile tit = sender as MetroFramework.Controls.MetroTile;
            //idRoomCurrent = (tit.Tag as DTO.RoomDTO).IdRoom;
            metroTextBox_IDMenu.Text = ((tit.Tag as DTO.Menu_DTO).Id).ToString();
            metroTextBox_id.Enabled = false;

            metroTextBox_NameMenu.Text = ((tit.Tag as DTO.Menu_DTO).Name).ToString();

            //CultureInfo culture = new CultureInfo("vi-VN");
            metroTextBox_PriceMenu.Text = ((tit.Tag as DTO.Menu_DTO).Price).ToString();
            metroTextBox_AmoutMenu.Text = ((tit.Tag as DTO.Menu_DTO).Amout).ToString();
            metroTextBox_AmoutMenu.Enabled = false;
            metroTextBox_IdKindOfMenu.Text = ((tit.Tag as DTO.Menu_DTO).Kind).ToString();

            int idMenuCurent = (tit.Tag as DTO.Menu_DTO).Id;          
        }

        private void metroTile_IMPORTGOODS_Click(object sender, EventArgs e)
        {
            //F_ImportGoods f = new F_ImportGoods();
            //f.ShowDialog();
            this.ClientSize = new System.Drawing.Size(1362, 834); //+100 height
            this.flowLayoutPanel_Service.Size = new System.Drawing.Size(680, 653);
            metroTabControl1.Size = new System.Drawing.Size(1316, 746);

            metroLabel_Import.Visible = true;
            metroTextBox_numNew.Visible = true;
            metroTile_Import.Visible = true;
            
        }

        private void metroTile_addMenu_Click(object sender, EventArgs e)
        {
            if (metroTextBox_NameMenu.Text == "" || metroTextBox_PriceMenu.Text == "")
            {
                MessageBox.Show("Please input Full menu's information !");
                return;
            }


            DTO.Menu_DTO m = new DTO.Menu_DTO();
            //m.Id = int.Parse(metroTextBox_IDMenu.Text);
            m.Name = metroTextBox_NameMenu.Text;
            m.Price = int.Parse(metroTextBox_PriceMenu.Text);
            m.Kind = int.Parse(metroTextBox_IdKindOfMenu.Text);
            m.Amout = 0; // default !

            if (menu_BUS.AddMenu(m) == false)
            {
                MessageBox.Show("Can't add this menu !");
                return;
            }
            MessageBox.Show("Menu was added !");

            Load_Menu_By_ID(int.Parse(metroTextBox_IdKindOfMenu.Text));
            //flowLayoutPanel_ServicesInfo.Refresh();

        }

        private void metroTile_DeleteMenu_Click(object sender, EventArgs e)
        {
            if (menu_BUS.DeleteMenu(int.Parse(metroTextBox_IDMenu.Text)) == true)
            {
                MessageBox.Show("Menu was deleted !");
                Load_Room();
            }
            else
            {
                MessageBox.Show("Can't delete this menu because it's being used !");
            }
            Load_Menu_By_ID(int.Parse(metroTextBox_IdKindOfMenu.Text));
        }

        private void metroTile_EditMenu_Click(object sender, EventArgs e)
        {
            if (metroTextBox_NameMenu.Text == "" || metroTextBox_PriceMenu.Text == "")
            {
                MessageBox.Show("Please input Full menu's information !");
                return;
            }

            DTO.Menu_DTO m = new DTO.Menu_DTO();
            m.Id = int.Parse(metroTextBox_IDMenu.Text);
            m.Name = metroTextBox_NameMenu.Text;
            m.Price = int.Parse(metroTextBox_PriceMenu.Text);
            m.Kind = int.Parse(metroTextBox_IdKindOfMenu.Text);
            m.Amout = int.Parse(metroTextBox_AmoutMenu.Text); // default !

            if (menu_BUS.EditMenu(m) == true)
            {
                MessageBox.Show("Menu was updated !");
                Load_Room();
            }
            else
            {
                MessageBox.Show("Can't update this menu !");
            }
            Load_Menu_By_ID(int.Parse(metroTextBox_IdKindOfMenu.Text));
        }

        private void metroTile_Import_Click(object sender, EventArgs e)
        {
            if(metroTextBox_numNew.Text == "")
            {
                MessageBox.Show("Please input number of menu that you want to import !");
                return;
            }
            int count = int.Parse(metroTextBox_numNew.Text);
            int idCurent = int.Parse(metroTextBox_IDMenu.Text);
            if (menu_BUS.ImportGoods(count, idCurent) == true)
            {
                MessageBox.Show("Menu was imported !");
                
            }
            else
            {
                MessageBox.Show("Can't import this menu !");
            }
            Load_Menu_By_ID(int.Parse(metroTextBox_IdKindOfMenu.Text));

            this.ClientSize = new System.Drawing.Size(1362, 734); //- 100 height
            this.flowLayoutPanel_Service.Size = new System.Drawing.Size(680, 553);
            metroTabControl1.Size = new System.Drawing.Size(1316, 646);

            metroLabel_Import.Visible = false;
            metroTextBox_numNew.Visible = false;
            metroTile_Import.Visible = false;
        }
    }


}
