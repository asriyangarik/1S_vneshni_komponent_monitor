namespace V8ClientMonitor.Forms
{
    partial class Main_Form
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
            this.City_picture = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BonusTB = new System.Windows.Forms.Label();
            this.BalansTB = new System.Windows.Forms.Label();
            this.BonCardText = new System.Windows.Forms.Label();
            this.CardNameTB = new System.Windows.Forms.Label();
            this.BonusT = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.GroupBox();
            this.item_countTB = new System.Windows.Forms.Label();
            this.ItemTB = new System.Windows.Forms.Label();
            this.f = new System.Windows.Forms.GroupBox();
            this.TotalText = new System.Windows.Forms.Label();
            this.TotalTB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.City_picture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.g.SuspendLayout();
            this.f.SuspendLayout();
            this.SuspendLayout();
            // 
            // City_picture
            // 
            this.City_picture.BackgroundImage = global::V8ClientMonitor.Properties.Resources.Bonus_Chisht;
            this.City_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.City_picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.City_picture.ErrorImage = null;
            this.City_picture.InitialImage = null;
            this.City_picture.Location = new System.Drawing.Point(0, 12);
            this.City_picture.Name = "City_picture";
            this.City_picture.Size = new System.Drawing.Size(1009, 368);
            this.City_picture.TabIndex = 15;
            this.City_picture.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.BonusTB);
            this.groupBox1.Controls.Add(this.BalansTB);
            this.groupBox1.Controls.Add(this.BonCardText);
            this.groupBox1.Controls.Add(this.CardNameTB);
            this.groupBox1.Controls.Add(this.BonusT);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(-2, 546);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 170);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // BonusTB
            // 
            this.BonusTB.AutoSize = true;
            this.BonusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BonusTB.ForeColor = System.Drawing.Color.Black;
            this.BonusTB.Location = new System.Drawing.Point(282, 115);
            this.BonusTB.Name = "BonusTB";
            this.BonusTB.Size = new System.Drawing.Size(112, 33);
            this.BonusTB.TabIndex = 7;
            this.BonusTB.Text = "Бонус1";
            // 
            // BalansTB
            // 
            this.BalansTB.AutoSize = true;
            this.BalansTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BalansTB.ForeColor = System.Drawing.Color.Black;
            this.BalansTB.Location = new System.Drawing.Point(282, 24);
            this.BalansTB.Name = "BalansTB";
            this.BalansTB.Size = new System.Drawing.Size(114, 33);
            this.BalansTB.TabIndex = 6;
            this.BalansTB.Text = "Баланс";
            // 
            // BonCardText
            // 
            this.BonCardText.AutoSize = true;
            this.BonCardText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BonCardText.ForeColor = System.Drawing.Color.Black;
            this.BonCardText.Location = new System.Drawing.Point(9, 27);
            this.BonCardText.Name = "BonCardText";
            this.BonCardText.Size = new System.Drawing.Size(127, 38);
            this.BonCardText.TabIndex = 3;
            this.BonCardText.Text = "Քարտ:";
            // 
            // CardNameTB
            // 
            this.CardNameTB.AutoSize = true;
            this.CardNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardNameTB.ForeColor = System.Drawing.Color.Black;
            this.CardNameTB.Location = new System.Drawing.Point(6, 71);
            this.CardNameTB.MaximumSize = new System.Drawing.Size(460, 31);
            this.CardNameTB.Name = "CardNameTB";
            this.CardNameTB.Size = new System.Drawing.Size(170, 31);
            this.CardNameTB.TabIndex = 5;
            this.CardNameTB.Text = "L_QartAnun";
            // 
            // BonusT
            // 
            this.BonusT.AutoSize = true;
            this.BonusT.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BonusT.ForeColor = System.Drawing.Color.Black;
            this.BonusT.Location = new System.Drawing.Point(6, 115);
            this.BonusT.Name = "BonusT";
            this.BonusT.Size = new System.Drawing.Size(203, 33);
            this.BonusT.TabIndex = 4;
            this.BonusT.Text = "Բոնուս/Զեղչ:";
            // 
            // g
            // 
            this.g.BackColor = System.Drawing.SystemColors.Control;
            this.g.Controls.Add(this.item_countTB);
            this.g.Controls.Add(this.ItemTB);
            this.g.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.g.Location = new System.Drawing.Point(0, 380);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(1019, 161);
            this.g.TabIndex = 13;
            this.g.TabStop = false;
            // 
            // item_countTB
            // 
            this.item_countTB.AutoSize = true;
            this.item_countTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.item_countTB.ForeColor = System.Drawing.Color.Blue;
            this.item_countTB.Location = new System.Drawing.Point(21, 94);
            this.item_countTB.Name = "item_countTB";
            this.item_countTB.Size = new System.Drawing.Size(203, 46);
            this.item_countTB.TabIndex = 1;
            this.item_countTB.Text = "ItemCount";
            // 
            // ItemTB
            // 
            this.ItemTB.AutoSize = true;
            this.ItemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemTB.ForeColor = System.Drawing.Color.Blue;
            this.ItemTB.Location = new System.Drawing.Point(38, 30);
            this.ItemTB.Name = "ItemTB";
            this.ItemTB.Size = new System.Drawing.Size(96, 46);
            this.ItemTB.TabIndex = 0;
            this.ItemTB.Text = "Item";
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.SystemColors.Control;
            this.f.Controls.Add(this.TotalText);
            this.f.Controls.Add(this.TotalTB);
            this.f.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.f.Location = new System.Drawing.Point(435, 547);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(574, 170);
            this.f.TabIndex = 12;
            this.f.TabStop = false;
            // 
            // TotalText
            // 
            this.TotalText.AutoSize = true;
            this.TotalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalText.ForeColor = System.Drawing.Color.Black;
            this.TotalText.Location = new System.Drawing.Point(6, 10);
            this.TotalText.Name = "TotalText";
            this.TotalText.Size = new System.Drawing.Size(323, 73);
            this.TotalText.TabIndex = 2;
            this.TotalText.Text = "ԳՈՒՄԱՐ:";
            // 
            // TotalTB
            // 
            this.TotalTB.AutoSize = true;
            this.TotalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalTB.ForeColor = System.Drawing.Color.Black;
            this.TotalTB.Location = new System.Drawing.Point(6, 88);
            this.TotalTB.Name = "TotalTB";
            this.TotalTB.Size = new System.Drawing.Size(243, 73);
            this.TotalTB.TabIndex = 1;
            this.TotalTB.Text = "Сумма";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 729);
            this.Controls.Add(this.City_picture);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.g);
            this.Controls.Add(this.f);
            this.Name = "Main_Form";
            this.Text = "Main_Form";
            ((System.ComponentModel.ISupportInitialize)(this.City_picture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.g.ResumeLayout(false);
            this.g.PerformLayout();
            this.f.ResumeLayout(false);
            this.f.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox City_picture;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label BonusTB;
        public System.Windows.Forms.Label BalansTB;
        public System.Windows.Forms.Label BonCardText;
        public System.Windows.Forms.Label CardNameTB;
        public System.Windows.Forms.Label BonusT;
        private System.Windows.Forms.GroupBox g;
        public System.Windows.Forms.Label item_countTB;
        public System.Windows.Forms.Label ItemTB;
        private System.Windows.Forms.GroupBox f;
        public System.Windows.Forms.Label TotalText;
        public System.Windows.Forms.Label TotalTB;
    }
}