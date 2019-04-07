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
    public partial class F_PaymentInfo : MetroFramework.Forms.MetroForm
    {
        private int idBill;
        private string roomName;
        private string customerName;
        private string timeIn;
        private string timeOut;
        private string timeUse;
        private float totalServicesFee;
        private float roomFee;
        private float vat;
        private string totalMoney;
        private float discount;

        public F_PaymentInfo()
        {
            InitializeComponent();
           
        }

       

        public int IdBill { get => idBill; set => idBill = value; }
        public string RoomName { get => roomName; set => roomName = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string TimeIn { get => timeIn; set => timeIn = value; }
        public string TimeOut { get => timeOut; set => timeOut = value; }
        public string TimeUse { get => timeUse; set => timeUse = value; }
        public float TotalServicesFee { get => totalServicesFee; set => totalServicesFee = value; }
        public float RoomFee { get => roomFee; set => roomFee = value; }
        public float Vat { get => vat; set => vat = value; }
        public string TotalMoney { get => totalMoney; set => totalMoney = value; }
        public float Discount { get => discount; set => discount = value; }

        private void metroTile_PrintBill_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon !");
            this.Close();
        }

        private void F_PaymentInfo_Load(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            metroLabel_id.Text = idBill.ToString();
            metroLabel_roomName.Text = roomName.ToString();
            if(customerName == "")
                metroLabel_customerName.Text = "Anonymous Guest";
            else
                metroLabel_customerName.Text = customerName.ToString();

            metroLabel_timeIn.Text = timeIn;
            metroLabel_timeOut.Text = timeOut;
            metroLabel_TimeUse.Text = timeUse;

            label_totalServicesFee.Text = totalServicesFee.ToString("c", culture);
            label_roomFee.Text = roomFee.ToString("c", culture);
            label_VAT.Text = vat.ToString("c", culture);
            label_TotalMoney.Text = totalMoney;

            if(discount.ToString() == "")
                label_discount.Text = "None";
            else
                label_discount.Text = discount.ToString("c", culture);
        }

        public void LoadItemOfRoomJustPaid() //hien hoa don cua room nao do
        {
            
            List<DTO.itemInBill_DTO> listItem = BUS.itemInBill_BUS.LoadItemOfRoomJustPaid();
            foreach (DTO.itemInBill_DTO item in listItem)
            {
                ListViewItem lvit = new ListViewItem(item.Name.ToString());
                lvit.SubItems.Add(item.Amout.ToString());
                lvit.SubItems.Add(item.Price.ToString());
                lvit.SubItems.Add(item.ToMoney.ToString());
                //serviceFee = serviceFee + item.ToMoney;
                listViewItem.Items.Add(lvit);
              
            }
           

        }

    }
}
