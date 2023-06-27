namespace СomputerMaster
{
    partial class FormWorkFind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorkFind));
            this.Work1 = new System.Windows.Forms.Button();
            this.Work5 = new System.Windows.Forms.Button();
            this.Work4 = new System.Windows.Forms.Button();
            this.Work3 = new System.Windows.Forms.Button();
            this.Work2 = new System.Windows.Forms.Button();
            this.WorkFindBack = new System.Windows.Forms.Button();
            this.WorkDiscriptions = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // Work1
            // 
            this.Work1.BackColor = System.Drawing.SystemColors.Control;
            this.Work1.Location = new System.Drawing.Point(243, 72);
            this.Work1.Name = "Work1";
            this.Work1.Size = new System.Drawing.Size(138, 26);
            this.Work1.TabIndex = 8;
            this.Work1.Text = "Дворник 10$/День";
            this.Work1.UseVisualStyleBackColor = false;
            this.Work1.Click += new System.EventHandler(this.ComputerWorks_Click);
            this.Work1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ComputerWorks_MouseMove);
            // 
            // Work5
            // 
            this.Work5.BackColor = System.Drawing.SystemColors.Control;
            this.Work5.Location = new System.Drawing.Point(243, 343);
            this.Work5.Name = "Work5";
            this.Work5.Size = new System.Drawing.Size(138, 26);
            this.Work5.TabIndex = 12;
            this.Work5.Text = "Хакер 50$/День";
            this.Work5.UseVisualStyleBackColor = false;
            this.Work5.Click += new System.EventHandler(this.Happy_Click);
            this.Work5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Happy_MouseMove);
            // 
            // Work4
            // 
            this.Work4.BackColor = System.Drawing.SystemColors.Control;
            this.Work4.Location = new System.Drawing.Point(243, 273);
            this.Work4.Name = "Work4";
            this.Work4.Size = new System.Drawing.Size(138, 26);
            this.Work4.TabIndex = 11;
            this.Work4.Text = "Сис админ 40$/День";
            this.Work4.UseVisualStyleBackColor = false;
            this.Work4.Click += new System.EventHandler(this.FindWork_Click);
            this.Work4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FindWork_MouseMove);
            // 
            // Work3
            // 
            this.Work3.BackColor = System.Drawing.SystemColors.Control;
            this.Work3.Location = new System.Drawing.Point(243, 204);
            this.Work3.Name = "Work3";
            this.Work3.Size = new System.Drawing.Size(138, 26);
            this.Work3.TabIndex = 10;
            this.Work3.Text = "Программист 30$/День";
            this.Work3.UseVisualStyleBackColor = false;
            this.Work3.Click += new System.EventHandler(this.WorkBBS_Click);
            this.Work3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.WorkBBS_MouseMove);
            // 
            // Work2
            // 
            this.Work2.BackColor = System.Drawing.SystemColors.Control;
            this.Work2.Location = new System.Drawing.Point(243, 136);
            this.Work2.Name = "Work2";
            this.Work2.Size = new System.Drawing.Size(138, 26);
            this.Work2.TabIndex = 9;
            this.Work2.Text = "Слесарь 20$/День";
            this.Work2.UseVisualStyleBackColor = false;
            this.Work2.Click += new System.EventHandler(this.Programms_Click);
            this.Work2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Programms_MouseMove);
            // 
            // WorkFindBack
            // 
            this.WorkFindBack.BackColor = System.Drawing.SystemColors.Control;
            this.WorkFindBack.Location = new System.Drawing.Point(41, 343);
            this.WorkFindBack.Name = "WorkFindBack";
            this.WorkFindBack.Size = new System.Drawing.Size(138, 26);
            this.WorkFindBack.TabIndex = 14;
            this.WorkFindBack.Text = "Вернуться";
            this.WorkFindBack.UseVisualStyleBackColor = false;
            this.WorkFindBack.Click += new System.EventHandler(this.WorkFindBack_Click);
            // 
            // WorkDiscriptions
            // 
            this.WorkDiscriptions.BackColor = System.Drawing.SystemColors.HighlightText;
            this.WorkDiscriptions.Location = new System.Drawing.Point(41, 50);
            this.WorkDiscriptions.Name = "WorkDiscriptions";
            this.WorkDiscriptions.ReadOnly = true;
            this.WorkDiscriptions.Size = new System.Drawing.Size(138, 96);
            this.WorkDiscriptions.TabIndex = 15;
            this.WorkDiscriptions.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(215, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 343);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // FormWorkFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(444, 433);
            this.Controls.Add(this.WorkDiscriptions);
            this.Controls.Add(this.WorkFindBack);
            this.Controls.Add(this.Work1);
            this.Controls.Add(this.Work5);
            this.Controls.Add(this.Work4);
            this.Controls.Add(this.Work3);
            this.Controls.Add(this.Work2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWorkFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск работы";
            this.Load += new System.EventHandler(this.FormWorkFind_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Work1;
        private System.Windows.Forms.Button Work5;
        private System.Windows.Forms.Button Work4;
        private System.Windows.Forms.Button Work3;
        private System.Windows.Forms.Button Work2;
        private System.Windows.Forms.Button WorkFindBack;
        private System.Windows.Forms.RichTextBox WorkDiscriptions;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}