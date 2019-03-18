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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // List<RoomDTO> listroom = RoomBUS.GetRooms();
            //dataGridView1.DataSource = listroom;
        }

        void Load_Room()
        {
            flowLayoutPanel_Room.Controls.Clear();
            List<DTO.RoomDTO> listroom = RoomBUS.GetRooms();
            int TableWidth = 175;
            int TableHeight = 175;

            foreach (DTO.RoomDTO item in listroom)
            {
                MetroFramework.Controls.MetroTile tit = new MetroFramework.Controls.MetroTile() { Width = TableWidth, Height = TableHeight };
                flowLayoutPanel_Room.Controls.Add(tit);
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

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }
    }
}
