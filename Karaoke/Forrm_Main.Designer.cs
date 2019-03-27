using System;

namespace Karaoke
{
    partial class Forrm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ROOMS = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel_ROOM = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroTextBox_timeIn = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_totalMoney = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox5 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_ServiceFee = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox_roomFee = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton_Payment = new MetroFramework.Controls.MetroButton();
            this.metroTextBox6 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.listViewItem = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_tit = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel_item = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel_Kind = new System.Windows.Forms.FlowLayoutPanel();
            this.numericUpDown_Count = new System.Windows.Forms.NumericUpDown();
            this.metroButton_addItem = new MetroFramework.Controls.MetroButton();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.ROOMS.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Count)).BeginInit();
            this.SuspendLayout();
            // 
            // ROOMS
            // 
            this.ROOMS.Controls.Add(this.flowLayoutPanel_ROOM);
            this.ROOMS.Location = new System.Drawing.Point(23, 107);
            this.ROOMS.Name = "ROOMS";
            this.ROOMS.Size = new System.Drawing.Size(780, 809);
            this.ROOMS.TabIndex = 1;
            this.ROOMS.TabStop = false;
            this.ROOMS.Text = "ROOMS LIST";
            // 
            // flowLayoutPanel_ROOM
            // 
            this.flowLayoutPanel_ROOM.Location = new System.Drawing.Point(6, 38);
            this.flowLayoutPanel_ROOM.Name = "flowLayoutPanel_ROOM";
            this.flowLayoutPanel_ROOM.Size = new System.Drawing.Size(768, 751);
            this.flowLayoutPanel_ROOM.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.metroTextBox_timeIn);
            this.groupBox1.Controls.Add(this.metroLabel9);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.metroTextBox6);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.listViewItem);
            this.groupBox1.Location = new System.Drawing.Point(1301, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 795);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ROOM DETAIL";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-109, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(344, 221);
            this.dataGridView1.TabIndex = 11;
            // 
            // metroTextBox_timeIn
            // 
            // 
            // 
            // 
            this.metroTextBox_timeIn.CustomButton.Image = null;
            this.metroTextBox_timeIn.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.metroTextBox_timeIn.CustomButton.Name = "";
            this.metroTextBox_timeIn.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_timeIn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_timeIn.CustomButton.TabIndex = 1;
            this.metroTextBox_timeIn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_timeIn.CustomButton.UseSelectable = true;
            this.metroTextBox_timeIn.CustomButton.Visible = false;
            this.metroTextBox_timeIn.Lines = new string[0];
            this.metroTextBox_timeIn.Location = new System.Drawing.Point(156, 93);
            this.metroTextBox_timeIn.MaxLength = 32767;
            this.metroTextBox_timeIn.Name = "metroTextBox_timeIn";
            this.metroTextBox_timeIn.PasswordChar = '\0';
            this.metroTextBox_timeIn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_timeIn.SelectedText = "";
            this.metroTextBox_timeIn.SelectionLength = 0;
            this.metroTextBox_timeIn.SelectionStart = 0;
            this.metroTextBox_timeIn.ShortcutsEnabled = true;
            this.metroTextBox_timeIn.Size = new System.Drawing.Size(191, 23);
            this.metroTextBox_timeIn.TabIndex = 10;
            this.metroTextBox_timeIn.UseSelectable = true;
            this.metroTextBox_timeIn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_timeIn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(79, 93);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(71, 25);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "Time in";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.metroLabel13);
            this.groupBox3.Controls.Add(this.metroTextBox1);
            this.groupBox3.Controls.Add(this.metroTextBox_totalMoney);
            this.groupBox3.Controls.Add(this.metroLabel2);
            this.groupBox3.Controls.Add(this.metroTextBox2);
            this.groupBox3.Controls.Add(this.metroLabel11);
            this.groupBox3.Controls.Add(this.metroLabel10);
            this.groupBox3.Controls.Add(this.metroTextBox5);
            this.groupBox3.Controls.Add(this.metroLabel7);
            this.groupBox3.Controls.Add(this.metroTextBox4);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Controls.Add(this.metroTextBox3);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.metroTextBox_ServiceFee);
            this.groupBox3.Controls.Add(this.metroLabel4);
            this.groupBox3.Controls.Add(this.metroTextBox_roomFee);
            this.groupBox3.Controls.Add(this.metroLabel3);
            this.groupBox3.Controls.Add(this.metroButton_Payment);
            this.groupBox3.Location = new System.Drawing.Point(6, 488);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(479, 301);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PAYMENT INFO";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.Location = new System.Drawing.Point(12, 237);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(135, 25);
            this.metroLabel11.TabIndex = 17;
            this.metroLabel11.Text = "TOTAL MONEY";
            // 
            // metroTextBox_totalMoney
            // 
            // 
            // 
            // 
            this.metroTextBox_totalMoney.CustomButton.Image = null;
            this.metroTextBox_totalMoney.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.metroTextBox_totalMoney.CustomButton.Name = "";
            this.metroTextBox_totalMoney.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_totalMoney.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_totalMoney.CustomButton.TabIndex = 1;
            this.metroTextBox_totalMoney.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_totalMoney.CustomButton.UseSelectable = true;
            this.metroTextBox_totalMoney.CustomButton.Visible = false;
            this.metroTextBox_totalMoney.Lines = new string[0];
            this.metroTextBox_totalMoney.Location = new System.Drawing.Point(153, 239);
            this.metroTextBox_totalMoney.MaxLength = 32767;
            this.metroTextBox_totalMoney.Name = "metroTextBox_totalMoney";
            this.metroTextBox_totalMoney.PasswordChar = '\0';
            this.metroTextBox_totalMoney.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_totalMoney.SelectedText = "";
            this.metroTextBox_totalMoney.SelectionLength = 0;
            this.metroTextBox_totalMoney.SelectionStart = 0;
            this.metroTextBox_totalMoney.ShortcutsEnabled = true;
            this.metroTextBox_totalMoney.Size = new System.Drawing.Size(191, 23);
            this.metroTextBox_totalMoney.TabIndex = 16;
            this.metroTextBox_totalMoney.UseSelectable = true;
            this.metroTextBox_totalMoney.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_totalMoney.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(66, 203);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(81, 25);
            this.metroLabel10.TabIndex = 15;
            this.metroLabel10.Text = "Discount";
            // 
            // metroTextBox5
            // 
            // 
            // 
            // 
            this.metroTextBox5.CustomButton.Image = null;
            this.metroTextBox5.CustomButton.Location = new System.Drawing.Point(97, 1);
            this.metroTextBox5.CustomButton.Name = "";
            this.metroTextBox5.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox5.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox5.CustomButton.TabIndex = 1;
            this.metroTextBox5.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox5.CustomButton.UseSelectable = true;
            this.metroTextBox5.CustomButton.Visible = false;
            this.metroTextBox5.Lines = new string[0];
            this.metroTextBox5.Location = new System.Drawing.Point(225, 203);
            this.metroTextBox5.MaxLength = 32767;
            this.metroTextBox5.Name = "metroTextBox5";
            this.metroTextBox5.PasswordChar = '\0';
            this.metroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox5.SelectedText = "";
            this.metroTextBox5.SelectionLength = 0;
            this.metroTextBox5.SelectionStart = 0;
            this.metroTextBox5.ShortcutsEnabled = true;
            this.metroTextBox5.Size = new System.Drawing.Size(119, 23);
            this.metroTextBox5.TabIndex = 14;
            this.metroTextBox5.UseSelectable = true;
            this.metroTextBox5.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox5.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(66, 211);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(0, 0);
            this.metroLabel7.TabIndex = 13;
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(153, 165);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(191, 23);
            this.metroTextBox4.TabIndex = 12;
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(56, 163);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(91, 25);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "Surcharge";
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Enabled = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(225, 129);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(119, 23);
            this.metroTextBox3.TabIndex = 10;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(102, 127);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(45, 25);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "VAT";
            // 
            // metroTextBox_ServiceFee
            // 
            // 
            // 
            // 
            this.metroTextBox_ServiceFee.CustomButton.Image = null;
            this.metroTextBox_ServiceFee.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.metroTextBox_ServiceFee.CustomButton.Name = "";
            this.metroTextBox_ServiceFee.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_ServiceFee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_ServiceFee.CustomButton.TabIndex = 1;
            this.metroTextBox_ServiceFee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_ServiceFee.CustomButton.UseSelectable = true;
            this.metroTextBox_ServiceFee.CustomButton.Visible = false;
            this.metroTextBox_ServiceFee.Lines = new string[0];
            this.metroTextBox_ServiceFee.Location = new System.Drawing.Point(153, 89);
            this.metroTextBox_ServiceFee.MaxLength = 32767;
            this.metroTextBox_ServiceFee.Name = "metroTextBox_ServiceFee";
            this.metroTextBox_ServiceFee.PasswordChar = '\0';
            this.metroTextBox_ServiceFee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_ServiceFee.SelectedText = "";
            this.metroTextBox_ServiceFee.SelectionLength = 0;
            this.metroTextBox_ServiceFee.SelectionStart = 0;
            this.metroTextBox_ServiceFee.ShortcutsEnabled = true;
            this.metroTextBox_ServiceFee.Size = new System.Drawing.Size(191, 23);
            this.metroTextBox_ServiceFee.TabIndex = 8;
            this.metroTextBox_ServiceFee.UseSelectable = true;
            this.metroTextBox_ServiceFee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_ServiceFee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(6, 87);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(141, 25);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Total service fee";
            // 
            // metroTextBox_roomFee
            // 
            // 
            // 
            // 
            this.metroTextBox_roomFee.CustomButton.Image = null;
            this.metroTextBox_roomFee.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.metroTextBox_roomFee.CustomButton.Name = "";
            this.metroTextBox_roomFee.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox_roomFee.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox_roomFee.CustomButton.TabIndex = 1;
            this.metroTextBox_roomFee.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox_roomFee.CustomButton.UseSelectable = true;
            this.metroTextBox_roomFee.CustomButton.Visible = false;
            this.metroTextBox_roomFee.Lines = new string[0];
            this.metroTextBox_roomFee.Location = new System.Drawing.Point(153, 51);
            this.metroTextBox_roomFee.MaxLength = 32767;
            this.metroTextBox_roomFee.Name = "metroTextBox_roomFee";
            this.metroTextBox_roomFee.PasswordChar = '\0';
            this.metroTextBox_roomFee.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox_roomFee.SelectedText = "";
            this.metroTextBox_roomFee.SelectionLength = 0;
            this.metroTextBox_roomFee.SelectionStart = 0;
            this.metroTextBox_roomFee.ShortcutsEnabled = true;
            this.metroTextBox_roomFee.Size = new System.Drawing.Size(191, 23);
            this.metroTextBox_roomFee.TabIndex = 6;
            this.metroTextBox_roomFee.UseSelectable = true;
            this.metroTextBox_roomFee.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox_roomFee.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(56, 49);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Room fee";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroButton_Payment
            // 
            this.metroButton_Payment.Highlight = true;
            this.metroButton_Payment.Location = new System.Drawing.Point(356, 201);
            this.metroButton_Payment.Name = "metroButton_Payment";
            this.metroButton_Payment.Size = new System.Drawing.Size(94, 61);
            this.metroButton_Payment.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton_Payment.TabIndex = 4;
            this.metroButton_Payment.Text = "PAYMENT";
            this.metroButton_Payment.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton_Payment.UseCustomBackColor = true;
            this.metroButton_Payment.UseCustomForeColor = true;
            this.metroButton_Payment.UseSelectable = true;
            this.metroButton_Payment.Click += new System.EventHandler(this.metroButton_Payment_Click);
            // 
            // metroTextBox6
            // 
            // 
            // 
            // 
            this.metroTextBox6.CustomButton.Image = null;
            this.metroTextBox6.CustomButton.Location = new System.Drawing.Point(169, 1);
            this.metroTextBox6.CustomButton.Name = "";
            this.metroTextBox6.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox6.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox6.CustomButton.TabIndex = 1;
            this.metroTextBox6.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox6.CustomButton.UseSelectable = true;
            this.metroTextBox6.CustomButton.Visible = false;
            this.metroTextBox6.Lines = new string[0];
            this.metroTextBox6.Location = new System.Drawing.Point(156, 47);
            this.metroTextBox6.MaxLength = 32767;
            this.metroTextBox6.Name = "metroTextBox6";
            this.metroTextBox6.PasswordChar = '\0';
            this.metroTextBox6.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox6.SelectedText = "";
            this.metroTextBox6.SelectionLength = 0;
            this.metroTextBox6.SelectionStart = 0;
            this.metroTextBox6.ShortcutsEnabled = true;
            this.metroTextBox6.Size = new System.Drawing.Size(191, 23);
            this.metroTextBox6.TabIndex = 8;
            this.metroTextBox6.UseSelectable = true;
            this.metroTextBox6.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox6.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(10, 47);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(140, 25);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "Customer name";
            // 
            // listViewItem
            // 
            this.listViewItem.AllowColumnReorder = true;
            this.listViewItem.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listViewItem.GridLines = true;
            this.listViewItem.Location = new System.Drawing.Point(5, 153);
            this.listViewItem.Margin = new System.Windows.Forms.Padding(2);
            this.listViewItem.Name = "listViewItem";
            this.listViewItem.Size = new System.Drawing.Size(480, 319);
            this.listViewItem.TabIndex = 3;
            this.listViewItem.Tag = "";
            this.listViewItem.UseCompatibleStateImageBehavior = false;
            this.listViewItem.View = System.Windows.Forms.View.Details;
            this.listViewItem.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Amount";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 112;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit price";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Into money";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 142;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.metroLabel_tit);
            this.groupBox2.Controls.Add(this.flowLayoutPanel_item);
            this.groupBox2.Controls.Add(this.flowLayoutPanel_Kind);
            this.groupBox2.Controls.Add(this.numericUpDown_Count);
            this.groupBox2.Controls.Add(this.metroButton_addItem);
            this.groupBox2.Location = new System.Drawing.Point(809, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(486, 809);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ADD ODERS";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(6, 18);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 25);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Category";
            // 
            // metroLabel_tit
            // 
            this.metroLabel_tit.AutoSize = true;
            this.metroLabel_tit.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel_tit.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel_tit.Location = new System.Drawing.Point(6, 405);
            this.metroLabel_tit.Name = "metroLabel_tit";
            this.metroLabel_tit.Size = new System.Drawing.Size(228, 25);
            this.metroLabel_tit.TabIndex = 8;
            this.metroLabel_tit.Text = "Select the category above";
            this.metroLabel_tit.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // flowLayoutPanel_item
            // 
            this.flowLayoutPanel_item.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel_item.Location = new System.Drawing.Point(6, 433);
            this.flowLayoutPanel_item.Name = "flowLayoutPanel_item";
            this.flowLayoutPanel_item.Size = new System.Drawing.Size(474, 272);
            this.flowLayoutPanel_item.TabIndex = 7;
            // 
            // flowLayoutPanel_Kind
            // 
            this.flowLayoutPanel_Kind.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_Kind.Location = new System.Drawing.Point(6, 50);
            this.flowLayoutPanel_Kind.Name = "flowLayoutPanel_Kind";
            this.flowLayoutPanel_Kind.Size = new System.Drawing.Size(474, 327);
            this.flowLayoutPanel_Kind.TabIndex = 6;
            // 
            // numericUpDown_Count
            // 
            this.numericUpDown_Count.Location = new System.Drawing.Point(118, 736);
            this.numericUpDown_Count.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDown_Count.Name = "numericUpDown_Count";
            this.numericUpDown_Count.Size = new System.Drawing.Size(63, 22);
            this.numericUpDown_Count.TabIndex = 4;
            // 
            // metroButton_addItem
            // 
            this.metroButton_addItem.Highlight = true;
            this.metroButton_addItem.Location = new System.Drawing.Point(200, 723);
            this.metroButton_addItem.Name = "metroButton_addItem";
            this.metroButton_addItem.Size = new System.Drawing.Size(154, 52);
            this.metroButton_addItem.Style = MetroFramework.MetroColorStyle.Green;
            this.metroButton_addItem.TabIndex = 3;
            this.metroButton_addItem.Text = "ADD ";
            this.metroButton_addItem.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton_addItem.UseCustomBackColor = true;
            this.metroButton_addItem.UseCustomForeColor = true;
            this.metroButton_addItem.UseSelectable = true;
            this.metroButton_addItem.Click += new System.EventHandler(this.MetroButton_addItem_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(1568, 9);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(149, 20);
            this.metroLabel12.TabIndex = 6;
            this.metroLabel12.Text = "Login as: Administrator";
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(17, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(153, 203);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(39, 23);
            this.metroTextBox2.TabIndex = 18;
            this.metroTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(198, 201);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(27, 25);
            this.metroLabel2.TabIndex = 19;
            this.metroLabel2.Text = "%";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.Location = new System.Drawing.Point(198, 127);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(27, 25);
            this.metroLabel13.TabIndex = 21;
            this.metroLabel13.Text = "%";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(17, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Enabled = false;
            this.metroTextBox1.Lines = new string[] {
        "10%"};
            this.metroTextBox1.Location = new System.Drawing.Point(153, 129);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(39, 23);
            this.metroTextBox1.TabIndex = 20;
            this.metroTextBox1.Text = "10%";
            this.metroTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Forrm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1802, 939);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.metroLabel12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ROOMS);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Forrm_Main";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "KARAOKE MANAGER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ROOMS.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void metroButton_addItem_Click(object sender, EventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.GroupBox ROOMS;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ROOM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton metroButton_addItem;
        private System.Windows.Forms.NumericUpDown numericUpDown_Count;
        public System.Windows.Forms.ListView listViewItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton_Payment;
        private MetroFramework.Controls.MetroTextBox metroTextBox_roomFee;
        private MetroFramework.Controls.MetroTextBox metroTextBox5;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox metroTextBox_ServiceFee;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox_timeIn;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox metroTextBox6;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox metroTextBox_totalMoney;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroLabel metroLabel_tit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_item;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Kind;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}

