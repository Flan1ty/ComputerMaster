namespace СomputerMaster
{
    partial class FormComputerWorks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComputerWorks));
            this.ComputerUpgrade = new System.Windows.Forms.Button();
            this.SoundBlasterBuy = new System.Windows.Forms.Button();
            this.ModemUpgrade = new System.Windows.Forms.Button();
            this.UpgradeCDROM = new System.Windows.Forms.Button();
            this.UpgradeCD = new System.Windows.Forms.Button();
            this.MemoryUpgrade = new System.Windows.Forms.Button();
            this.ComputersBack = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.CountUpgrade = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DiscriptionUpgrade = new System.Windows.Forms.RichTextBox();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComputerUpgrade
            // 
            this.ComputerUpgrade.BackColor = System.Drawing.SystemColors.Control;
            this.ComputerUpgrade.Location = new System.Drawing.Point(70, 49);
            this.ComputerUpgrade.Name = "ComputerUpgrade";
            this.ComputerUpgrade.Size = new System.Drawing.Size(138, 26);
            this.ComputerUpgrade.TabIndex = 8;
            this.ComputerUpgrade.Text = "Апгрейд компьютера";
            this.ComputerUpgrade.UseVisualStyleBackColor = false;
            this.ComputerUpgrade.Click += new System.EventHandler(this.ComputerUpgrade_Click);
            this.ComputerUpgrade.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ComputerUpgrade_Move);
            // 
            // SoundBlasterBuy
            // 
            this.SoundBlasterBuy.BackColor = System.Drawing.SystemColors.Control;
            this.SoundBlasterBuy.Location = new System.Drawing.Point(70, 313);
            this.SoundBlasterBuy.Name = "SoundBlasterBuy";
            this.SoundBlasterBuy.Size = new System.Drawing.Size(138, 26);
            this.SoundBlasterBuy.TabIndex = 13;
            this.SoundBlasterBuy.Text = "SoundBlaster";
            this.SoundBlasterBuy.UseVisualStyleBackColor = false;
            this.SoundBlasterBuy.Click += new System.EventHandler(this.SoundBlasterBuy_Click);
            this.SoundBlasterBuy.MouseMove += new System.Windows.Forms.MouseEventHandler(this.SoundBlasterBuy_MouseMove);
            // 
            // ModemUpgrade
            // 
            this.ModemUpgrade.BackColor = System.Drawing.SystemColors.Control;
            this.ModemUpgrade.Location = new System.Drawing.Point(70, 203);
            this.ModemUpgrade.Name = "ModemUpgrade";
            this.ModemUpgrade.Size = new System.Drawing.Size(138, 26);
            this.ModemUpgrade.TabIndex = 12;
            this.ModemUpgrade.Text = "Апгрейд модема";
            this.ModemUpgrade.UseVisualStyleBackColor = false;
            this.ModemUpgrade.Click += new System.EventHandler(this.ModemUpgrade_Click);
            this.ModemUpgrade.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ModemUpgrade_MouseMove);
            // 
            // UpgradeCDROM
            // 
            this.UpgradeCDROM.BackColor = System.Drawing.SystemColors.Control;
            this.UpgradeCDROM.Location = new System.Drawing.Point(70, 256);
            this.UpgradeCDROM.Name = "UpgradeCDROM";
            this.UpgradeCDROM.Size = new System.Drawing.Size(138, 26);
            this.UpgradeCDROM.TabIndex = 11;
            this.UpgradeCDROM.Text = "Апгрейд CDROM";
            this.UpgradeCDROM.UseVisualStyleBackColor = false;
            this.UpgradeCDROM.Click += new System.EventHandler(this.UpgradeCDROM_Click);
            this.UpgradeCDROM.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpgradeCDROM_MouseMove);
            // 
            // UpgradeCD
            // 
            this.UpgradeCD.BackColor = System.Drawing.SystemColors.Control;
            this.UpgradeCD.Location = new System.Drawing.Point(70, 154);
            this.UpgradeCD.Name = "UpgradeCD";
            this.UpgradeCD.Size = new System.Drawing.Size(138, 26);
            this.UpgradeCD.TabIndex = 10;
            this.UpgradeCD.Text = "Апгрейд винчестера";
            this.UpgradeCD.UseVisualStyleBackColor = false;
            this.UpgradeCD.Click += new System.EventHandler(this.UpgradeCD_Click);
            this.UpgradeCD.MouseMove += new System.Windows.Forms.MouseEventHandler(this.UpgradeCD_MouseMove);
            // 
            // MemoryUpgrade
            // 
            this.MemoryUpgrade.BackColor = System.Drawing.SystemColors.Control;
            this.MemoryUpgrade.Location = new System.Drawing.Point(70, 100);
            this.MemoryUpgrade.Name = "MemoryUpgrade";
            this.MemoryUpgrade.Size = new System.Drawing.Size(138, 26);
            this.MemoryUpgrade.TabIndex = 9;
            this.MemoryUpgrade.Text = "Апгрейд памяти";
            this.MemoryUpgrade.UseVisualStyleBackColor = false;
            this.MemoryUpgrade.Click += new System.EventHandler(this.MemoryUpgrade_Click);
            this.MemoryUpgrade.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MemoryUpgrade_MouseMove);
            // 
            // ComputersBack
            // 
            this.ComputersBack.BackColor = System.Drawing.SystemColors.Control;
            this.ComputersBack.Location = new System.Drawing.Point(259, 224);
            this.ComputersBack.Name = "ComputersBack";
            this.ComputersBack.Size = new System.Drawing.Size(146, 26);
            this.ComputersBack.TabIndex = 15;
            this.ComputersBack.Text = "Вернуться";
            this.ComputersBack.UseVisualStyleBackColor = false;
            this.ComputersBack.Click += new System.EventHandler(this.ComputersBack_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox2.Location = new System.Drawing.Point(296, 49);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(146, 77);
            this.richTextBox2.TabIndex = 16;
            this.richTextBox2.Text = "Здесь вы можете апгрейднуть своё железо, но для этого нужно поднакопить деньжат.";
            // 
            // CountUpgrade
            // 
            this.CountUpgrade.AutoSize = true;
            this.CountUpgrade.Location = new System.Drawing.Point(311, 154);
            this.CountUpgrade.Name = "CountUpgrade";
            this.CountUpgrade.Size = new System.Drawing.Size(0, 13);
            this.CountUpgrade.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox3.Controls.Add(this.DiscriptionUpgrade);
            this.groupBox3.Controls.Add(this.ComputersBack);
            this.groupBox3.Location = new System.Drawing.Point(37, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(426, 317);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            // 
            // DiscriptionUpgrade
            // 
            this.DiscriptionUpgrade.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DiscriptionUpgrade.Location = new System.Drawing.Point(259, 120);
            this.DiscriptionUpgrade.Name = "DiscriptionUpgrade";
            this.DiscriptionUpgrade.ReadOnly = true;
            this.DiscriptionUpgrade.Size = new System.Drawing.Size(146, 77);
            this.DiscriptionUpgrade.TabIndex = 17;
            this.DiscriptionUpgrade.Text = "";
            // 
            // FormComputerWorks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(503, 379);
            this.Controls.Add(this.CountUpgrade);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.ComputerUpgrade);
            this.Controls.Add(this.SoundBlasterBuy);
            this.Controls.Add(this.ModemUpgrade);
            this.Controls.Add(this.UpgradeCDROM);
            this.Controls.Add(this.UpgradeCD);
            this.Controls.Add(this.MemoryUpgrade);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormComputerWorks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Компьютерные дела";
            this.Load += new System.EventHandler(this.FormComputerWorks_Load);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ComputerUpgrade;
        private System.Windows.Forms.Button SoundBlasterBuy;
        private System.Windows.Forms.Button ModemUpgrade;
        private System.Windows.Forms.Button UpgradeCDROM;
        private System.Windows.Forms.Button UpgradeCD;
        private System.Windows.Forms.Button MemoryUpgrade;
        private System.Windows.Forms.Button ComputersBack;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label CountUpgrade;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox DiscriptionUpgrade;
    }
}