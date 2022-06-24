namespace GameLouncher
{
    partial class Form2
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
            this.nameAppLabel = new System.Windows.Forms.Label();
            this.nameWayLabel = new System.Windows.Forms.Label();
            this.nameApp = new System.Windows.Forms.TextBox();
            this.nameWay = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.mainWay = new System.Windows.Forms.TextBox();
            this.wayBut = new System.Windows.Forms.Button();
            this.okBut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.scrBut1 = new System.Windows.Forms.Button();
            this.scrBut2 = new System.Windows.Forms.Button();
            this.scrBut3 = new System.Windows.Forms.Button();
            this.scrBut4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameAppLabel
            // 
            this.nameAppLabel.AutoSize = true;
            this.nameAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameAppLabel.Location = new System.Drawing.Point(12, 83);
            this.nameAppLabel.Name = "nameAppLabel";
            this.nameAppLabel.Size = new System.Drawing.Size(176, 62);
            this.nameAppLabel.TabIndex = 0;
            this.nameAppLabel.Text = "Название \r\nприложения:\r\n";
            this.nameAppLabel.Click += new System.EventHandler(this.nameAppLabel_Click);
            // 
            // nameWayLabel
            // 
            this.nameWayLabel.AutoSize = true;
            this.nameWayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameWayLabel.Location = new System.Drawing.Point(12, 159);
            this.nameWayLabel.Name = "nameWayLabel";
            this.nameWayLabel.Size = new System.Drawing.Size(191, 62);
            this.nameWayLabel.TabIndex = 1;
            this.nameWayLabel.Text = "Путь к файлу:\r\n\r\n";
            // 
            // nameApp
            // 
            this.nameApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameApp.Location = new System.Drawing.Point(209, 107);
            this.nameApp.Name = "nameApp";
            this.nameApp.Size = new System.Drawing.Size(267, 38);
            this.nameApp.TabIndex = 2;
            this.nameApp.TextChanged += new System.EventHandler(this.nameApp_TextChanged);
            // 
            // nameWay
            // 
            this.nameWay.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameWay.Location = new System.Drawing.Point(209, 159);
            this.nameWay.Name = "nameWay";
            this.nameWay.Size = new System.Drawing.Size(416, 31);
            this.nameWay.TabIndex = 3;
            this.nameWay.TextChanged += new System.EventHandler(this.nameWay_TextChanged);
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(505, 203);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(75, 23);
            this.buttonGo.TabIndex = 4;
            this.buttonGo.Text = "Далее";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // mainWay
            // 
            this.mainWay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainWay.Location = new System.Drawing.Point(59, 27);
            this.mainWay.Name = "mainWay";
            this.mainWay.Size = new System.Drawing.Size(327, 23);
            this.mainWay.TabIndex = 5;
            this.mainWay.Text = "Путь для сохранения файлов";
            // 
            // wayBut
            // 
            this.wayBut.Location = new System.Drawing.Point(407, 26);
            this.wayBut.Name = "wayBut";
            this.wayBut.Size = new System.Drawing.Size(75, 23);
            this.wayBut.TabIndex = 6;
            this.wayBut.Text = "Обзор";
            this.wayBut.UseVisualStyleBackColor = true;
            this.wayBut.Click += new System.EventHandler(this.wayBut_Click);
            // 
            // okBut
            // 
            this.okBut.Location = new System.Drawing.Point(505, 26);
            this.okBut.Name = "okBut";
            this.okBut.Size = new System.Drawing.Size(75, 23);
            this.okBut.TabIndex = 7;
            this.okBut.Text = "Ok";
            this.okBut.UseVisualStyleBackColor = true;
            this.okBut.Click += new System.EventHandler(this.okBut_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scrBut1
            // 
            this.scrBut1.Location = new System.Drawing.Point(59, 290);
            this.scrBut1.Name = "scrBut1";
            this.scrBut1.Size = new System.Drawing.Size(96, 97);
            this.scrBut1.TabIndex = 9;
            this.scrBut1.Text = "Основной постер";
            this.scrBut1.UseVisualStyleBackColor = true;
            this.scrBut1.Visible = false;
            this.scrBut1.Click += new System.EventHandler(this.scrBut1_Click);
            // 
            // scrBut2
            // 
            this.scrBut2.Location = new System.Drawing.Point(182, 290);
            this.scrBut2.Name = "scrBut2";
            this.scrBut2.Size = new System.Drawing.Size(96, 97);
            this.scrBut2.TabIndex = 10;
            this.scrBut2.Text = "Скрин 1";
            this.scrBut2.UseVisualStyleBackColor = true;
            this.scrBut2.Visible = false;
            this.scrBut2.Click += new System.EventHandler(this.scrBut2_Click);
            // 
            // scrBut3
            // 
            this.scrBut3.Location = new System.Drawing.Point(308, 290);
            this.scrBut3.Name = "scrBut3";
            this.scrBut3.Size = new System.Drawing.Size(96, 97);
            this.scrBut3.TabIndex = 11;
            this.scrBut3.Text = "Скрин 2";
            this.scrBut3.UseVisualStyleBackColor = true;
            this.scrBut3.Visible = false;
            this.scrBut3.Click += new System.EventHandler(this.scrBut3_Click);
            // 
            // scrBut4
            // 
            this.scrBut4.Location = new System.Drawing.Point(431, 290);
            this.scrBut4.Name = "scrBut4";
            this.scrBut4.Size = new System.Drawing.Size(96, 97);
            this.scrBut4.TabIndex = 12;
            this.scrBut4.Text = "Скрин 3";
            this.scrBut4.UseVisualStyleBackColor = true;
            this.scrBut4.Visible = false;
            this.scrBut4.Click += new System.EventHandler(this.scrBut4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(57, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Не загружено";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(180, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Не загружено";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(306, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Не загружено";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(429, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Не загружено";
            this.label4.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(505, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Далее";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scrBut4);
            this.Controls.Add(this.scrBut3);
            this.Controls.Add(this.scrBut2);
            this.Controls.Add(this.scrBut1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.okBut);
            this.Controls.Add(this.wayBut);
            this.Controls.Add(this.mainWay);
            this.Controls.Add(this.buttonGo);
            this.Controls.Add(this.nameWay);
            this.Controls.Add(this.nameApp);
            this.Controls.Add(this.nameWayLabel);
            this.Controls.Add(this.nameAppLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameAppLabel;
        private System.Windows.Forms.Label nameWayLabel;
        private System.Windows.Forms.TextBox nameApp;
        private System.Windows.Forms.TextBox nameWay;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox mainWay;
        private System.Windows.Forms.Button wayBut;
        private System.Windows.Forms.Button okBut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button scrBut1;
        private System.Windows.Forms.Button scrBut2;
        private System.Windows.Forms.Button scrBut3;
        private System.Windows.Forms.Button scrBut4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}