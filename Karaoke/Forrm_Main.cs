using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;



namespace Karaoke
{
    public partial class Forrm_Main : MetroFramework.Forms.MetroForm
    {
        public Forrm_Main()
        {
            InitializeComponent();
            Load_Room();
            Load_Kind();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<DTO.Drink_DTO> listkind = Drink_BUS.GetDrinks();
            //dataGridView1.DataSource = listkind;
            //List<DTO.Drink_DTO> listkind = Drink_BUS.GetDrinksById(3);
            //dataGridView1.DataSource = listkind;


        }

        void Load_Kind()
        {
            List<DTO.Kind_DTO> listKind = Kind_BUS.Getkinds();
            int TableWidth = 125;
            int TableHeight = 70;

            foreach (DTO.Kind_DTO item in listKind)
            {
                MetroFramework.Controls.MetroTile tit_kind = new MetroFramework.Controls.MetroTile() { Width = TableWidth, Height = TableHeight };
                flowLayoutPanel_Kind.Controls.Add(tit_kind);
                tit_kind.Theme = MetroFramework.MetroThemeStyle.Light;
                tit_kind.UseTileImage = true;
                tit_kind.Style = MetroFramework.MetroColorStyle.Green;
                tit_kind.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                //tit_kind.TileImage = global::Karaoke.Properties.Resources.wine;
                tit_kind.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
                tit_kind.Text = item.Name;

                tit_kind.Click += tit_kind_Click;
                tit_kind.Tag = item;

               
            }
        }

        void Load_Menu_By_ID(int id)
        {
            flowLayoutPanel_item.Controls.Clear();
            List<DTO.Menu_DTO> listMenu = menu_BUS.GetMenus(id);
            int TableWidth = 125;
            int TableHeight = 50;

            foreach (DTO.Menu_DTO item in listMenu)
            {
                MetroFramework.Controls.MetroTile tit_kind = new MetroFramework.Controls.MetroTile() { Width = TableWidth, Height = TableHeight };
                flowLayoutPanel_item.Controls.Add(tit_kind);
                tit_kind.Theme = MetroFramework.MetroThemeStyle.Light;
                tit_kind.UseTileImage = true;
                tit_kind.Style = MetroFramework.MetroColorStyle.Teal;
                tit_kind.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                tit_kind.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
                tit_kind.Text = item.Name;
            }
        } 

        void Load_Room()
        {
            flowLayoutPanel_ROOM.Controls.Clear();
            List<DTO.RoomDTO> listroom = RoomBUS.GetRooms();
            int TableWidth = 175;
            int TableHeight = 175;

            foreach (DTO.RoomDTO item in listroom)
            {
                MetroFramework.Controls.MetroTile tit = new MetroFramework.Controls.MetroTile() { Width = TableWidth, Height = TableHeight };
                flowLayoutPanel_ROOM.Controls.Add(tit);
                tit.Theme = MetroFramework.MetroThemeStyle.Light;
                
                tit.UseTileImage = true;
                tit.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                tit.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;

                


                //Button Btn = new Button() { Width = TableWidth, Height = TableHeight };
                //flowLayoutPanel_Room.Controls.Add(Btn);

                string stt = "";
                if (item.Status == 0)
                {
                    stt = "Available";
                }
                else
                {
                    stt = "Active";
                }

                tit.Text = item.Name + Environment.NewLine + stt;
               


                ////Btn.Click += Btn_Click;
                ////tn.Tag = item; //luu cai room cua minh vo tag, no la kiiu du lieu obj

                switch (item.Status)
                {
                    case 0:
                        tit.Style = MetroFramework.MetroColorStyle.Green;
                        tit.TileImage = global::Karaoke.Properties.Resources.room;
                        break;
                    default:
                        tit.Style = MetroFramework.MetroColorStyle.Orange;
                        tit.TileImage = global::Karaoke.Properties.Resources.kara;
                        break;
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        

        public void tit_kind_Click(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile tit = sender as MetroFramework.Controls.MetroTile;
            int idKind = (tit.Tag as Kind_DTO).Id;       
            Load_Menu_By_ID(idKind);
            string title = ((sender as MetroFramework.Controls.MetroTile).Tag as Kind_DTO).Name;
            metroLabel_tit.Text = "List of " + title;
        }

        private void metroScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
