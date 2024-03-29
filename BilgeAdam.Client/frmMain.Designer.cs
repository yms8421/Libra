﻿namespace BilgeAdam.Client
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tslblUserFullName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsBookCard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPeopleCard = new System.Windows.Forms.ToolStripMenuItem();
            this.tsList = new System.Windows.Forms.ToolStripMenuItem();
            this.msbBookList = new System.Windows.Forms.ToolStripMenuItem();
            this.okuyucuListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emanetKitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanımlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGroup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSchool = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBookShelf = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblUserFullName,
            this.tslblTime});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tslblUserFullName
            // 
            this.tslblUserFullName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tslblUserFullName.ForeColor = System.Drawing.Color.Coral;
            this.tslblUserFullName.Image = global::BilgeAdam.Client.Properties.Resources.user_16;
            this.tslblUserFullName.Name = "tslblUserFullName";
            this.tslblUserFullName.Size = new System.Drawing.Size(65, 17);
            this.tslblUserFullName.Text = "UserFull";
            // 
            // tslblTime
            // 
            this.tslblTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tslblTime.ForeColor = System.Drawing.Color.Crimson;
            this.tslblTime.Image = global::BilgeAdam.Client.Properties.Resources.date_go;
            this.tslblTime.Name = "tslblTime";
            this.tslblTime.Size = new System.Drawing.Size(50, 17);
            this.tslblTime.Text = "Time";
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(3, 3, 0, 5);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBookCard,
            this.tsPeopleCard,
            this.tsList,
            this.tanımlarToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 40);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsBookCard
            // 
            this.tsBookCard.Image = global::BilgeAdam.Client.Properties.Resources.addres_book;
            this.tsBookCard.Name = "tsBookCard";
            this.tsBookCard.Size = new System.Drawing.Size(118, 36);
            this.tsBookCard.Text = "Kitap Kartları";
            this.tsBookCard.Click += new System.EventHandler(this.tsBookCard_Click);
            // 
            // tsPeopleCard
            // 
            this.tsPeopleCard.Image = global::BilgeAdam.Client.Properties.Resources.Excellence_Folder___Users;
            this.tsPeopleCard.Name = "tsPeopleCard";
            this.tsPeopleCard.Size = new System.Drawing.Size(111, 36);
            this.tsPeopleCard.Text = "Üye Kartları";
            // 
            // tsList
            // 
            this.tsList.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msbBookList,
            this.okuyucuListesiToolStripMenuItem,
            this.emanetKitaplarToolStripMenuItem});
            this.tsList.Image = global::BilgeAdam.Client.Properties.Resources.report_32;
            this.tsList.Name = "tsList";
            this.tsList.Size = new System.Drawing.Size(88, 36);
            this.tsList.Text = "Listeler";
            // 
            // msbBookList
            // 
            this.msbBookList.Image = global::BilgeAdam.Client.Properties.Resources.text_list_bullets;
            this.msbBookList.Name = "msbBookList";
            this.msbBookList.Size = new System.Drawing.Size(173, 38);
            this.msbBookList.Text = "Kitap Listesi";
            this.msbBookList.Click += new System.EventHandler(this.msbBookList_Click);
            // 
            // okuyucuListesiToolStripMenuItem
            // 
            this.okuyucuListesiToolStripMenuItem.Image = global::BilgeAdam.Client.Properties.Resources.text_list_bullets;
            this.okuyucuListesiToolStripMenuItem.Name = "okuyucuListesiToolStripMenuItem";
            this.okuyucuListesiToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.okuyucuListesiToolStripMenuItem.Text = "Okuyucu Listesi";
            // 
            // emanetKitaplarToolStripMenuItem
            // 
            this.emanetKitaplarToolStripMenuItem.Image = global::BilgeAdam.Client.Properties.Resources.text_list_bullets;
            this.emanetKitaplarToolStripMenuItem.Name = "emanetKitaplarToolStripMenuItem";
            this.emanetKitaplarToolStripMenuItem.Size = new System.Drawing.Size(173, 38);
            this.emanetKitaplarToolStripMenuItem.Text = "Emanet Kitaplar";
            // 
            // tanımlarToolStripMenuItem
            // 
            this.tanımlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAuthor,
            this.tsGroup,
            this.tsSchool,
            this.tsBookShelf});
            this.tanımlarToolStripMenuItem.Image = global::BilgeAdam.Client.Properties.Resources.Add_Folder;
            this.tanımlarToolStripMenuItem.Name = "tanımlarToolStripMenuItem";
            this.tanımlarToolStripMenuItem.Size = new System.Drawing.Size(97, 36);
            this.tanımlarToolStripMenuItem.Text = "Tanımlar";
            // 
            // tsAuthor
            // 
            this.tsAuthor.Image = global::BilgeAdam.Client.Properties.Resources.add_16;
            this.tsAuthor.Name = "tsAuthor";
            this.tsAuthor.Size = new System.Drawing.Size(173, 38);
            this.tsAuthor.Text = "Yazar Tanım";
            this.tsAuthor.Click += new System.EventHandler(this.tsAuthor_Click);
            // 
            // tsGroup
            // 
            this.tsGroup.Image = global::BilgeAdam.Client.Properties.Resources.add_16;
            this.tsGroup.Name = "tsGroup";
            this.tsGroup.Size = new System.Drawing.Size(173, 38);
            this.tsGroup.Text = "Grup Tanım";
            // 
            // tsSchool
            // 
            this.tsSchool.Image = global::BilgeAdam.Client.Properties.Resources.add_16;
            this.tsSchool.Name = "tsSchool";
            this.tsSchool.Size = new System.Drawing.Size(173, 38);
            this.tsSchool.Text = "Okul Tanım";
            // 
            // tsBookShelf
            // 
            this.tsBookShelf.Image = global::BilgeAdam.Client.Properties.Resources.add_16;
            this.tsBookShelf.Name = "tsBookShelf";
            this.tsBookShelf.Size = new System.Drawing.Size(173, 38);
            this.tsBookShelf.Text = "Kitap Raf Tanım";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = ".:: Kütüphane Vers: 001";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tslblUserFullName;
        private System.Windows.Forms.ToolStripStatusLabel tslblTime;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsBookCard;
        private System.Windows.Forms.ToolStripMenuItem tsPeopleCard;
        private System.Windows.Forms.ToolStripMenuItem tsList;
        private System.Windows.Forms.ToolStripMenuItem tanımlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsAuthor;
        private System.Windows.Forms.ToolStripMenuItem msbBookList;
        private System.Windows.Forms.ToolStripMenuItem okuyucuListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emanetKitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsGroup;
        private System.Windows.Forms.ToolStripMenuItem tsSchool;
        private System.Windows.Forms.ToolStripMenuItem tsBookShelf;
    }
}

