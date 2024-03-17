namespace oti2018_national
{
    partial class Centenar_Start
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
            this.vizlectiiBtn = new System.Windows.Forms.Button();
            this.authBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vizlectiiBtn
            // 
            this.vizlectiiBtn.Location = new System.Drawing.Point(130, 48);
            this.vizlectiiBtn.Name = "vizlectiiBtn";
            this.vizlectiiBtn.Size = new System.Drawing.Size(156, 36);
            this.vizlectiiBtn.TabIndex = 0;
            this.vizlectiiBtn.Text = "Vizualizare Lectii";
            this.vizlectiiBtn.UseVisualStyleBackColor = true;
            this.vizlectiiBtn.Click += new System.EventHandler(this.vizlectiiBtn_Click);
            // 
            // authBtn
            // 
            this.authBtn.Location = new System.Drawing.Point(130, 105);
            this.authBtn.Name = "authBtn";
            this.authBtn.Size = new System.Drawing.Size(156, 37);
            this.authBtn.TabIndex = 1;
            this.authBtn.Text = "Autentificare";
            this.authBtn.UseVisualStyleBackColor = true;
            this.authBtn.Click += new System.EventHandler(this.authBtn_Click);
            // 
            // Centenar_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 198);
            this.Controls.Add(this.authBtn);
            this.Controls.Add(this.vizlectiiBtn);
            this.Name = "Centenar_Start";
            this.Text = "Centenar Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vizlectiiBtn;
        private System.Windows.Forms.Button authBtn;
    }
}

