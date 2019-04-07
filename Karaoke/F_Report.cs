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
    public partial class F_Report : MetroFramework.Forms.MetroForm
    {
        public F_Report()
        {
            InitializeComponent();
            loadAllBills();
            Load_Kind();
            Load_Total_Inventory_Money();
        }

        private void F_Report_Load(object sender, EventArgs e)
        {
            
        }
        CultureInfo culture = new CultureInfo("vi-VN");
        private void loadAllBills()
        {
            string s = metroDateTime_Date.Value.Year + "/" + metroDateTime_Date.Value.Month + "/" + metroDateTime_Date.Value.Day;
            string date_displayed = metroDateTime_Date.Value.Day + "/" + metroDateTime_Date.Value.Month + "/" + metroDateTime_Date.Value.Year;
            metroLabel_date.Text = date_displayed;
            metroLabel_date2.Text = date_displayed;


            List<DTO.Bill_DTO> listBill = BUS.bill_BUS.GetAllBillByDate(s);
            dataGridView_ALLBILL.DataSource = listBill;
            dataGridView_ALLBILL.RowHeadersVisible = false;
            dataGridView_ALLBILL.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn col in dataGridView_ALLBILL.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }



            dataGridView_ALLBILL.Columns["Id"].HeaderText = "ID";
            dataGridView_ALLBILL.Columns["Id"].Width = 30;
            //dataGridView_ALLBILL.Columns["name"].HeaderText = "ROOM";

            dataGridView_ALLBILL.Columns["TimeIn"].HeaderText = "Time In";
            dataGridView_ALLBILL.Columns["TimeIn"].Width = 120;

            dataGridView_ALLBILL.Columns["TimeOut"].HeaderText = "Time Out";
            dataGridView_ALLBILL.Columns["TimeOut"].Width = 120;

            dataGridView_ALLBILL.Columns["PaymentStatus"].Visible = false;

            dataGridView_ALLBILL.Columns["TimeUse"].HeaderText = "Time Using (Min)";
            dataGridView_ALLBILL.Columns["Room_Fee"].HeaderText = "Room Fee";
            dataGridView_ALLBILL.Columns["Services_Fee"].HeaderText = "Services Fee";
            dataGridView_ALLBILL.Columns["Discount"].HeaderText = "Discount (%)";

            dataGridView_ALLBILL.Columns["Total_Money"].HeaderText = "TOTAL MONEY";
            dataGridView_ALLBILL.Columns["Total_Money"].Width = 190;

            

            float thanhtien = 0;
            for (int i = 0; i < dataGridView_ALLBILL.Rows.Count; i++)
                thanhtien += float.Parse(dataGridView_ALLBILL.Rows[i].Cells["Total_Money"].Value.ToString());
            metroTile_totalRevenue.Text = thanhtien.ToString("c", culture);
        }
        private void metroDateTime1_ValueChanged(object sender, EventArgs e)
        {
            string s = metroDateTime_Date.Value.Day + "/" + metroDateTime_Date.Value.Month + "/" + metroDateTime_Date.Value.Year;
            loadAllBills();
            metroLabel_date.Text = s;
            metroLabel_date2.Text = s;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile_EXPORT_REPORT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon !");
        }
        void Load_Kind()
        {
            List<DTO.Kind_DTO> listKind = BUS.Kind_BUS.Getkinds();
            int TableWidth = 260;
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

        private void tit_kind_Click(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTile tit = sender as MetroFramework.Controls.MetroTile;
            int idKind = (tit.Tag as DTO.Kind_DTO).Id;
            Load_Menu_By_ID(idKind);
        }

        void Load_Menu_By_ID(int id)
        {
            flowLayoutPanel_ServicesInfo.Controls.Clear();
            List<DTO.Menu_DTO> listMenu = BUS.menu_BUS.GetMenus(id);
            int TableWidth = 300;
            int TableHeight = 200;
            try
            {
                foreach (DTO.Menu_DTO item in listMenu)
                {
                    MetroFramework.Controls.MetroTile tit_Item = new MetroFramework.Controls.MetroTile() { Width = TableWidth, Height = TableHeight };
                    flowLayoutPanel_ServicesInfo.Controls.Add(tit_Item);
                    tit_Item.Theme = MetroFramework.MetroThemeStyle.Light;
                    tit_Item.UseTileImage = true;
                    tit_Item.Style = MetroFramework.MetroColorStyle.Teal;
                    tit_Item.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    tit_Item.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
                    tit_Item.Text = item.Name + Environment.NewLine + "Amout: " + item.Amout + Environment.NewLine + "Unit price: " + item.Price.ToString("c", culture) + Environment.NewLine + "Inventory money: " + (item.Price * item.Amout).ToString("c", culture);
                }
            }
            catch { }            
        }

        void Load_Total_Inventory_Money()
        {
            List<DTO.Menu_DTO> listMenu = BUS.menu_BUS.GetAllMenu();
            float total_Inventory_Money = 0;
            foreach (DTO.Menu_DTO item in listMenu)
            {
                total_Inventory_Money += (item.Amout * item.Price);
            }
            metroTile_total_Inventory_Money.Text = total_Inventory_Money.ToString("c", culture);
        }

        private void metroTile_BACK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile_export_inventory_Report_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comming soon !");
        }
    }
}
