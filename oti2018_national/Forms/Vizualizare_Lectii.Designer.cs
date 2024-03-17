namespace oti2018_national.Forms
{
    partial class Vizualizare_Lectii
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.createlessonBtn = new System.Windows.Forms.Button();
            this.gentraseuBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Afiseaza";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(34, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(174, 284);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lectii:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(270, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(475, 255);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(270, 332);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(291, 89);
            this.textBox2.TabIndex = 7;
            // 
            // createlessonBtn
            // 
            this.createlessonBtn.Location = new System.Drawing.Point(270, 12);
            this.createlessonBtn.Name = "createlessonBtn";
            this.createlessonBtn.Size = new System.Drawing.Size(142, 38);
            this.createlessonBtn.TabIndex = 8;
            this.createlessonBtn.Text = "Creare Lectie";
            this.createlessonBtn.UseVisualStyleBackColor = true;
            this.createlessonBtn.Click += new System.EventHandler(this.createlessonBtn_Click);
            // 
            // gentraseuBtn
            // 
            this.gentraseuBtn.Location = new System.Drawing.Point(423, 12);
            this.gentraseuBtn.Name = "gentraseuBtn";
            this.gentraseuBtn.Size = new System.Drawing.Size(138, 38);
            this.gentraseuBtn.TabIndex = 10;
            this.gentraseuBtn.Text = "Generare Traseu";
            this.gentraseuBtn.UseVisualStyleBackColor = true;
            this.gentraseuBtn.Click += new System.EventHandler(this.gentraseuBtn_Click);
            // 
            // Vizualizare_Lectii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gentraseuBtn);
            this.Controls.Add(this.createlessonBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Name = "Vizualizare_Lectii";
            this.Text = "Vizualizare Lectii";
            this.Load += new System.EventHandler(this.Vizualizare_Lectii_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button createlessonBtn;
        private System.Windows.Forms.Button gentraseuBtn;
    }
}