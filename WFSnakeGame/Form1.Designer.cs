namespace WFSnakeGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel = new System.Windows.Forms.Panel();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureUp = new System.Windows.Forms.PictureBox();
            this.pictureRgt = new System.Windows.Forms.PictureBox();
            this.pictureDown = new System.Windows.Forms.PictureBox();
            this.pictureLft = new System.Windows.Forms.PictureBox();
            this.lblSkor = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRgt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLft)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Black;
            this.panel.Location = new System.Drawing.Point(13, 13);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(420, 420);
            this.panel.TabIndex = 0;
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.LightGray;
            this.btnBaslat.FlatAppearance.BorderSize = 0;
            this.btnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaslat.Location = new System.Drawing.Point(440, 12);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(70, 30);
            this.btnBaslat.TabIndex = 1;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.LightGray;
            this.btnDurdur.FlatAppearance.BorderSize = 0;
            this.btnDurdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurdur.Location = new System.Drawing.Point(520, 12);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(70, 30);
            this.btnDurdur.TabIndex = 2;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = false;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.Color.LightGray;
            this.btnYeniOyun.FlatAppearance.BorderSize = 0;
            this.btnYeniOyun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniOyun.Location = new System.Drawing.Point(440, 48);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(150, 30);
            this.btnYeniOyun.TabIndex = 3;
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pictureUp, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureRgt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureDown, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureLft, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(440, 84);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 150);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // pictureUp
            // 
            this.pictureUp.BackColor = System.Drawing.Color.LightGray;
            this.pictureUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureUp.Image = ((System.Drawing.Image)(resources.GetObject("pictureUp.Image")));
            this.pictureUp.Location = new System.Drawing.Point(52, 3);
            this.pictureUp.Name = "pictureUp";
            this.pictureUp.Size = new System.Drawing.Size(43, 43);
            this.pictureUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureUp.TabIndex = 0;
            this.pictureUp.TabStop = false;
            this.pictureUp.Click += new System.EventHandler(this.pictureUp_Click);
            // 
            // pictureRgt
            // 
            this.pictureRgt.BackColor = System.Drawing.Color.LightGray;
            this.pictureRgt.Image = ((System.Drawing.Image)(resources.GetObject("pictureRgt.Image")));
            this.pictureRgt.Location = new System.Drawing.Point(101, 52);
            this.pictureRgt.Name = "pictureRgt";
            this.pictureRgt.Size = new System.Drawing.Size(44, 43);
            this.pictureRgt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureRgt.TabIndex = 1;
            this.pictureRgt.TabStop = false;
            this.pictureRgt.Click += new System.EventHandler(this.pictureRgt_Click);
            // 
            // pictureDown
            // 
            this.pictureDown.BackColor = System.Drawing.Color.LightGray;
            this.pictureDown.Image = ((System.Drawing.Image)(resources.GetObject("pictureDown.Image")));
            this.pictureDown.Location = new System.Drawing.Point(52, 101);
            this.pictureDown.Name = "pictureDown";
            this.pictureDown.Size = new System.Drawing.Size(43, 44);
            this.pictureDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureDown.TabIndex = 2;
            this.pictureDown.TabStop = false;
            this.pictureDown.Click += new System.EventHandler(this.pictureDown_Click);
            // 
            // pictureLft
            // 
            this.pictureLft.BackColor = System.Drawing.Color.LightGray;
            this.pictureLft.Image = ((System.Drawing.Image)(resources.GetObject("pictureLft.Image")));
            this.pictureLft.Location = new System.Drawing.Point(3, 52);
            this.pictureLft.Name = "pictureLft";
            this.pictureLft.Size = new System.Drawing.Size(43, 43);
            this.pictureLft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureLft.TabIndex = 3;
            this.pictureLft.TabStop = false;
            this.pictureLft.Click += new System.EventHandler(this.pictureLft_Click);
            // 
            // lblSkor
            // 
            this.lblSkor.BackColor = System.Drawing.Color.OliveDrab;
            this.lblSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSkor.Location = new System.Drawing.Point(440, 237);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(150, 49);
            this.lblSkor.TabIndex = 5;
            this.lblSkor.Text = "0";
            this.lblSkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 443);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnYeniOyun);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.panel);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yılan Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRgt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLft)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureUp;
        private System.Windows.Forms.PictureBox pictureRgt;
        private System.Windows.Forms.PictureBox pictureDown;
        private System.Windows.Forms.PictureBox pictureLft;
        private System.Windows.Forms.Label lblSkor;
        private System.Windows.Forms.Timer timer;
    }
}

