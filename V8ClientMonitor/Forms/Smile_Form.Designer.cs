namespace V8ClientMonitor.Forms
{
    partial class Smile_Form
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
            this.TitelL = new System.Windows.Forms.Label();
            this.TitelGB = new System.Windows.Forms.GroupBox();
            this.SmileGB = new System.Windows.Forms.GroupBox();
            this.GoodL = new System.Windows.Forms.Label();
            this.NormalL = new System.Windows.Forms.Label();
            this.BadL = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GoodBT = new System.Windows.Forms.Button();
            this.BadBT = new System.Windows.Forms.Button();
            this.NormalBT = new System.Windows.Forms.Button();
            this.TitelGB.SuspendLayout();
            this.SmileGB.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitelL
            // 
            this.TitelL.AutoSize = true;
            this.TitelL.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitelL.Location = new System.Drawing.Point(26, 28);
            this.TitelL.Name = "TitelL";
            this.TitelL.Size = new System.Drawing.Size(967, 42);
            this.TitelL.TabIndex = 0;
            this.TitelL.Text = "Խնդրում ենք գնահատել գանձապահի աշխատանքը";
            // 
            // TitelGB
            // 
            this.TitelGB.Controls.Add(this.TitelL);
            this.TitelGB.Location = new System.Drawing.Point(4, 12);
            this.TitelGB.Name = "TitelGB";
            this.TitelGB.Size = new System.Drawing.Size(1010, 112);
            this.TitelGB.TabIndex = 1;
            this.TitelGB.TabStop = false;
            // 
            // SmileGB
            // 
            this.SmileGB.BackColor = System.Drawing.Color.White;
            this.SmileGB.Controls.Add(this.GoodL);
            this.SmileGB.Controls.Add(this.NormalL);
            this.SmileGB.Controls.Add(this.BadL);
            this.SmileGB.Controls.Add(this.GoodBT);
            this.SmileGB.Controls.Add(this.BadBT);
            this.SmileGB.Controls.Add(this.NormalBT);
            this.SmileGB.Location = new System.Drawing.Point(4, 130);
            this.SmileGB.Name = "SmileGB";
            this.SmileGB.Size = new System.Drawing.Size(1010, 347);
            this.SmileGB.TabIndex = 5;
            this.SmileGB.TabStop = false;
            // 
            // GoodL
            // 
            this.GoodL.AutoSize = true;
            this.GoodL.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GoodL.Location = new System.Drawing.Point(779, 292);
            this.GoodL.Name = "GoodL";
            this.GoodL.Size = new System.Drawing.Size(93, 42);
            this.GoodL.TabIndex = 6;
            this.GoodL.Text = "Լավ";
            // 
            // NormalL
            // 
            this.NormalL.AutoSize = true;
            this.NormalL.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NormalL.Location = new System.Drawing.Point(418, 287);
            this.NormalL.Name = "NormalL";
            this.NormalL.Size = new System.Drawing.Size(153, 42);
            this.NormalL.TabIndex = 5;
            this.NormalL.Text = "Նորմալ";
            // 
            // BadL
            // 
            this.BadL.AutoSize = true;
            this.BadL.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BadL.Location = new System.Drawing.Point(112, 286);
            this.BadL.Name = "BadL";
            this.BadL.Size = new System.Drawing.Size(110, 42);
            this.BadL.TabIndex = 4;
            this.BadL.Text = "Վատ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(4, 548);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1010, 144);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(163, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(692, 46);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ձեր կարծիքը էական է մեզ համար";
            // 
            // GoodBT
            // 
            this.GoodBT.BackgroundImage = global::V8ClientMonitor.Properties.Resources.Рисунок4;
            this.GoodBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GoodBT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.GoodBT.FlatAppearance.BorderSize = 2;
            this.GoodBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoodBT.Location = new System.Drawing.Point(690, 19);
            this.GoodBT.Name = "GoodBT";
            this.GoodBT.Size = new System.Drawing.Size(270, 270);
            this.GoodBT.TabIndex = 1;
            this.GoodBT.UseVisualStyleBackColor = true;
            this.GoodBT.Click += new System.EventHandler(this.GoodBT_Click);
            // 
            // BadBT
            // 
            this.BadBT.BackgroundImage = global::V8ClientMonitor.Properties.Resources.Рисунок2;
            this.BadBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BadBT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BadBT.FlatAppearance.BorderSize = 2;
            this.BadBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BadBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BadBT.Location = new System.Drawing.Point(32, 16);
            this.BadBT.Margin = new System.Windows.Forms.Padding(0);
            this.BadBT.Name = "BadBT";
            this.BadBT.Size = new System.Drawing.Size(270, 270);
            this.BadBT.TabIndex = 3;
            this.BadBT.UseVisualStyleBackColor = true;
            this.BadBT.Click += new System.EventHandler(this.BadBT_Click);
            // 
            // NormalBT
            // 
            this.NormalBT.BackgroundImage = global::V8ClientMonitor.Properties.Resources.Рисунок3;
            this.NormalBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.NormalBT.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NormalBT.FlatAppearance.BorderSize = 2;
            this.NormalBT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NormalBT.Location = new System.Drawing.Point(359, 16);
            this.NormalBT.Name = "NormalBT";
            this.NormalBT.Size = new System.Drawing.Size(270, 270);
            this.NormalBT.TabIndex = 2;
            this.NormalBT.UseVisualStyleBackColor = true;
            this.NormalBT.Click += new System.EventHandler(this.NormalBT_Click);
            // 
            // Smile_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.SmileGB);
            this.Controls.Add(this.TitelGB);
            this.Name = "Smile_Form";
            this.Text = "Smile_Form";
            this.TitelGB.ResumeLayout(false);
            this.TitelGB.PerformLayout();
            this.SmileGB.ResumeLayout(false);
            this.SmileGB.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitelL;
        private System.Windows.Forms.GroupBox TitelGB;
        private System.Windows.Forms.GroupBox SmileGB;
        private System.Windows.Forms.Label GoodL;
        private System.Windows.Forms.Label NormalL;
        private System.Windows.Forms.Label BadL;
        private System.Windows.Forms.Button GoodBT;
        private System.Windows.Forms.Button BadBT;
        private System.Windows.Forms.Button NormalBT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
    }
}