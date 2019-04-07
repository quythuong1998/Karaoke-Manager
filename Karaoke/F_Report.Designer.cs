namespace Karaoke
{
    partial class F_Report
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabelxxx = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dataGridView_ALLBILL = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime_Date = new MetroFramework.Controls.MetroDateTime();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel_date = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel_date2 = new MetroFramework.Controls.MetroLabel();
            this.metroTile_totalRevenue = new MetroFramework.Controls.MetroTile();
            this.metroTile_EXPORT_REPORT = new MetroFramework.Controls.MetroTile();
            this.flowLayoutPanel_Service = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanel_ServicesInfo = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroTile_total_Inventory_Money = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ALLBILL)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 107);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1352, 736);
            this.metroTabControl1.TabIndex = 7;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroTile_EXPORT_REPORT);
            this.metroTabPage1.Controls.Add(this.metroTile_totalRevenue);
            this.metroTabPage1.Controls.Add(this.metroLabel_date2);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.metroLabel_date);
            this.metroTabPage1.Controls.Add(this.metroLabelxxx);
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.metroDateTime_Date);
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1344, 694);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "REVENUE";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // metroLabelxxx
            // 
            this.metroLabelxxx.AutoSize = true;
            this.metroLabelxxx.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabelxxx.Location = new System.Drawing.Point(40, 88);
            this.metroLabelxxx.Name = "metroLabelxxx";
            this.metroLabelxxx.Size = new System.Drawing.Size(214, 25);
            this.metroLabelxxx.TabIndex = 10;
            this.metroLabelxxx.Text = "You\'re viewing all bills in: ";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dataGridView_ALLBILL);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(40, 128);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(877, 504);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dataGridView_ALLBILL
            // 
            this.dataGridView_ALLBILL.AllowUserToAddRows = false;
            this.dataGridView_ALLBILL.AllowUserToDeleteRows = false;
            this.dataGridView_ALLBILL.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_ALLBILL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_ALLBILL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ALLBILL.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView_ALLBILL.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_ALLBILL.Name = "dataGridView_ALLBILL";
            this.dataGridView_ALLBILL.ReadOnly = true;
            this.dataGridView_ALLBILL.RowTemplate.Height = 24;
            this.dataGridView_ALLBILL.Size = new System.Drawing.Size(869, 498);
            this.dataGridView_ALLBILL.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(40, 42);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(128, 25);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "CHOOSE DAY:";
            // 
            // metroDateTime_Date
            // 
            this.metroDateTime_Date.Location = new System.Drawing.Point(174, 42);
            this.metroDateTime_Date.MinimumSize = new System.Drawing.Size(0, 30);
            this.metroDateTime_Date.Name = "metroDateTime_Date";
            this.metroDateTime_Date.Size = new System.Drawing.Size(308, 30);
            this.metroDateTime_Date.TabIndex = 7;
            this.metroDateTime_Date.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroTile1);
            this.metroTabPage2.Controls.Add(this.metroTile_total_Inventory_Money);
            this.metroTabPage2.Controls.Add(this.metroLabel4);
            this.metroTabPage2.Controls.Add(this.flowLayoutPanel_ServicesInfo);
            this.metroTabPage2.Controls.Add(this.metroLabel14);
            this.metroTabPage2.Controls.Add(this.flowLayoutPanel_Service);
            this.metroTabPage2.Controls.Add(this.metroLabel15);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1344, 694);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "INVENTORY";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel_date
            // 
            this.metroLabel_date.AutoSize = true;
            this.metroLabel_date.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel_date.Location = new System.Drawing.Point(249, 88);
            this.metroLabel_date.Name = "metroLabel_date";
            this.metroLabel_date.Size = new System.Drawing.Size(0, 0);
            this.metroLabel_date.TabIndex = 11;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(946, 128);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(153, 25);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "TOTAL REVENUE:";
            // 
            // metroLabel_date2
            // 
            this.metroLabel_date2.AutoSize = true;
            this.metroLabel_date2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel_date2.Location = new System.Drawing.Point(1105, 128);
            this.metroLabel_date2.Name = "metroLabel_date2";
            this.metroLabel_date2.Size = new System.Drawing.Size(45, 25);
            this.metroLabel_date2.TabIndex = 13;
            this.metroLabel_date2.Text = "###";
            // 
            // metroTile_totalRevenue
            // 
            this.metroTile_totalRevenue.ActiveControl = null;
            this.metroTile_totalRevenue.Cursor = System.Windows.Forms.Cursors.No;
            this.metroTile_totalRevenue.Location = new System.Drawing.Point(1019, 178);
            this.metroTile_totalRevenue.Name = "metroTile_totalRevenue";
            this.metroTile_totalRevenue.Size = new System.Drawing.Size(247, 87);
            this.metroTile_totalRevenue.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile_totalRevenue.TabIndex = 14;
            this.metroTile_totalRevenue.Text = "total revenue";
            this.metroTile_totalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_totalRevenue.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_totalRevenue.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile_totalRevenue.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_totalRevenue.UseSelectable = true;
            // 
            // metroTile_EXPORT_REPORT
            // 
            this.metroTile_EXPORT_REPORT.ActiveControl = null;
            this.metroTile_EXPORT_REPORT.Location = new System.Drawing.Point(605, 644);
            this.metroTile_EXPORT_REPORT.Name = "metroTile_EXPORT_REPORT";
            this.metroTile_EXPORT_REPORT.Size = new System.Drawing.Size(224, 47);
            this.metroTile_EXPORT_REPORT.TabIndex = 15;
            this.metroTile_EXPORT_REPORT.Text = "EXPORT REVENUE REPORT";
            this.metroTile_EXPORT_REPORT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_EXPORT_REPORT.UseSelectable = true;
            this.metroTile_EXPORT_REPORT.Click += new System.EventHandler(this.metroTile_EXPORT_REPORT_Click);
            // 
            // flowLayoutPanel_Service
            // 
            this.flowLayoutPanel_Service.AutoScroll = true;
            this.flowLayoutPanel_Service.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel_Service.Location = new System.Drawing.Point(3, 41);
            this.flowLayoutPanel_Service.Name = "flowLayoutPanel_Service";
            this.flowLayoutPanel_Service.Size = new System.Drawing.Size(286, 592);
            this.flowLayoutPanel_Service.TabIndex = 8;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.Location = new System.Drawing.Point(3, 13);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(125, 25);
            this.metroLabel15.TabIndex = 9;
            this.metroLabel15.Text = "LIST SERVICES";
            // 
            // flowLayoutPanel_ServicesInfo
            // 
            this.flowLayoutPanel_ServicesInfo.AutoScroll = true;
            this.flowLayoutPanel_ServicesInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel_ServicesInfo.Location = new System.Drawing.Point(295, 41);
            this.flowLayoutPanel_ServicesInfo.Name = "flowLayoutPanel_ServicesInfo";
            this.flowLayoutPanel_ServicesInfo.Size = new System.Drawing.Size(632, 592);
            this.flowLayoutPanel_ServicesInfo.TabIndex = 12;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel14.Location = new System.Drawing.Point(295, 13);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(204, 25);
            this.metroLabel14.TabIndex = 11;
            this.metroLabel14.Text = "SERVICE INFORMATION";
            // 
            // metroTile_total_Inventory_Money
            // 
            this.metroTile_total_Inventory_Money.ActiveControl = null;
            this.metroTile_total_Inventory_Money.Cursor = System.Windows.Forms.Cursors.No;
            this.metroTile_total_Inventory_Money.Location = new System.Drawing.Point(1033, 91);
            this.metroTile_total_Inventory_Money.Name = "metroTile_total_Inventory_Money";
            this.metroTile_total_Inventory_Money.Size = new System.Drawing.Size(247, 87);
            this.metroTile_total_Inventory_Money.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTile_total_Inventory_Money.TabIndex = 17;
            this.metroTile_total_Inventory_Money.Text = "total inventory money";
            this.metroTile_total_Inventory_Money.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_total_Inventory_Money.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_total_Inventory_Money.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile_total_Inventory_Money.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.metroTile_total_Inventory_Money.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(960, 41);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(236, 25);
            this.metroLabel4.TabIndex = 15;
            this.metroLabel4.Text = "TOTAL INVENTORY MONEY";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(605, 644);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(224, 47);
            this.metroTile1.TabIndex = 18;
            this.metroTile1.Text = "EXPORT INVENTORY REPORT";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            // 
            // F_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 860);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "F_Report";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "REPORT";
            this.Load += new System.EventHandler(this.F_Report_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ALLBILL)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabelxxx;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.DataGridView dataGridView_ALLBILL;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime metroDateTime_Date;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel_date;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel_date2;
        private MetroFramework.Controls.MetroTile metroTile_totalRevenue;
        private MetroFramework.Controls.MetroTile metroTile_EXPORT_REPORT;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Service;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_ServicesInfo;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTile metroTile_total_Inventory_Money;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}