namespace Karaoke
{
    partial class F_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Login));
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.textBoxPass = new MetroFramework.Controls.MetroTextBox();
            this.metroTile_login = new MetroFramework.Controls.MetroTile();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.textBoxID = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.textBoxPass);
            this.metroPanel1.Controls.Add(this.metroTile_login);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.textBoxID);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 6;
            this.metroPanel1.Location = new System.Drawing.Point(22, 67);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(660, 209);
            this.metroPanel1.TabIndex = 6;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 7;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackgroundImage = global::Karaoke.Properties.Resources.karaoke_2;
            this.metroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(12, 54);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(101, 100);
            this.metroPanel2.TabIndex = 9;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // textBoxPass
            // 
            // 
            // 
            // 
            this.textBoxPass.CustomButton.Image = null;
            this.textBoxPass.CustomButton.Location = new System.Drawing.Point(149, 2);
            this.textBoxPass.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPass.CustomButton.Name = "";
            this.textBoxPass.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.textBoxPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxPass.CustomButton.TabIndex = 1;
            this.textBoxPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxPass.CustomButton.UseSelectable = true;
            this.textBoxPass.CustomButton.Visible = false;
            this.textBoxPass.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.textBoxPass.Lines = new string[0];
            this.textBoxPass.Location = new System.Drawing.Point(232, 114);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPass.MaxLength = 32767;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxPass.SelectedText = "";
            this.textBoxPass.SelectionLength = 0;
            this.textBoxPass.SelectionStart = 0;
            this.textBoxPass.ShortcutsEnabled = true;
            this.textBoxPass.Size = new System.Drawing.Size(187, 40);
            this.textBoxPass.TabIndex = 8;
            this.textBoxPass.UseSelectable = true;
            this.textBoxPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile_login
            // 
            this.metroTile_login.ActiveControl = null;
            this.metroTile_login.Location = new System.Drawing.Point(448, 114);
            this.metroTile_login.Name = "metroTile_login";
            this.metroTile_login.Size = new System.Drawing.Size(175, 40);
            this.metroTile_login.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile_login.TabIndex = 7;
            this.metroTile_login.Text = "LOGIN";
            this.metroTile_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile_login.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroTile_login.UseSelectable = true;
            this.metroTile_login.UseTileImage = true;
            this.metroTile_login.Click += new System.EventHandler(this.metroTile_login_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(136, 125);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(82, 20);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "PASSWORD";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(196, 74);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(22, 20);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "ID";
            // 
            // textBoxID
            // 
            // 
            // 
            // 
            this.textBoxID.CustomButton.Image = null;
            this.textBoxID.CustomButton.Location = new System.Drawing.Point(149, 2);
            this.textBoxID.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.CustomButton.Name = "";
            this.textBoxID.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.textBoxID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBoxID.CustomButton.TabIndex = 1;
            this.textBoxID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBoxID.CustomButton.UseSelectable = true;
            this.textBoxID.CustomButton.Visible = false;
            this.textBoxID.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.textBoxID.Lines = new string[0];
            this.textBoxID.Location = new System.Drawing.Point(232, 54);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxID.MaxLength = 32767;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.PasswordChar = '\0';
            this.textBoxID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxID.SelectedText = "";
            this.textBoxID.SelectionLength = 0;
            this.textBoxID.SelectionStart = 0;
            this.textBoxID.ShortcutsEnabled = true;
            this.textBoxID.Size = new System.Drawing.Size(187, 40);
            this.textBoxID.TabIndex = 1;
            this.textBoxID.UseSelectable = true;
            this.textBoxID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBoxID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // F_Login
            // 
            this.AcceptButton = this.metroTile_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 298);
            this.Controls.Add(this.metroPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Login";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.F_Login_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox textBoxPass;
        private MetroFramework.Controls.MetroTile metroTile_login;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox textBoxID;
        private MetroFramework.Controls.MetroPanel metroPanel2;
    }
}