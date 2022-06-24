namespace GameLouncher
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.Label();
            this.LayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bgImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.UpdateBut = new System.Windows.Forms.Button();
            this.waylable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft PhagsPa", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(877, 599);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(182, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запустить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textName
            // 
            this.textName.AutoSize = true;
            this.textName.BackColor = System.Drawing.Color.Black;
            this.textName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textName.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textName.Location = new System.Drawing.Point(12, 103);
            this.textName.Name = "textName";
            this.textName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textName.Size = new System.Drawing.Size(158, 55);
            this.textName.TabIndex = 2;
            this.textName.Text = "label1";
            this.textName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.textName.Click += new System.EventHandler(this.label1_Click);
            // 
            // LayoutPanel1
            // 
            this.LayoutPanel1.AutoScroll = true;
            this.LayoutPanel1.AutoScrollMargin = new System.Drawing.Size(2000, 119);
            this.LayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.LayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LayoutPanel1.BackgroundImage")));
            this.LayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.LayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.LayoutPanel1.Name = "LayoutPanel1";
            this.LayoutPanel1.Size = new System.Drawing.Size(1071, 65);
            this.LayoutPanel1.TabIndex = 3;
            this.LayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.LayoutPanel1_Paint);
            // 
            // bgImage
            // 
            this.bgImage.BackColor = System.Drawing.Color.DimGray;
            this.bgImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bgImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgImage.Image = ((System.Drawing.Image)(resources.GetObject("bgImage.Image")));
            this.bgImage.ImageLocation = "";
            this.bgImage.Location = new System.Drawing.Point(0, 0);
            this.bgImage.Name = "bgImage";
            this.bgImage.Size = new System.Drawing.Size(1071, 698);
            this.bgImage.TabIndex = 5;
            this.bgImage.TabStop = false;
            this.bgImage.Click += new System.EventHandler(this.bgImage_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(435, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 372);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(71, 173);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(308, 235);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(71, 425);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(308, 235);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(804, 620);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 55);
            this.button2.TabIndex = 9;
            this.button2.Text = "Добавить\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UpdateBut
            // 
            this.UpdateBut.Location = new System.Drawing.Point(984, 71);
            this.UpdateBut.Name = "UpdateBut";
            this.UpdateBut.Size = new System.Drawing.Size(75, 23);
            this.UpdateBut.TabIndex = 11;
            this.UpdateBut.Text = "обновить";
            this.UpdateBut.UseVisualStyleBackColor = true;
            this.UpdateBut.Click += new System.EventHandler(this.UpdateBut_Click);
            // 
            // waylable
            // 
            this.waylable.AutoSize = true;
            this.waylable.BackColor = System.Drawing.Color.Black;
            this.waylable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.waylable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.waylable.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.waylable.Location = new System.Drawing.Point(12, 672);
            this.waylable.Name = "waylable";
            this.waylable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.waylable.Size = new System.Drawing.Size(52, 17);
            this.waylable.TabIndex = 12;
            this.waylable.Text = "label1";
            this.waylable.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1071, 698);
            this.Controls.Add(this.waylable);
            this.Controls.Add(this.UpdateBut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LayoutPanel1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bgImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label textName;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanel1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.PictureBox bgImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button UpdateBut;
        private System.Windows.Forms.Label waylable;
    }
}

