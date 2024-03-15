namespace Login_testes
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
            this.label1 = new System.Windows.Forms.Label();
            this.EteLink = new System.Windows.Forms.LinkLabel();
            this.AvaLink = new System.Windows.Forms.LinkLabel();
            this.GitLink = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Para onde gostaria de ir?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // EteLink
            // 
            this.EteLink.AutoSize = true;
            this.EteLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EteLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.EteLink.Location = new System.Drawing.Point(12, 159);
            this.EteLink.Name = "EteLink";
            this.EteLink.Size = new System.Drawing.Size(153, 32);
            this.EteLink.TabIndex = 1;
            this.EteLink.TabStop = true;
            this.EteLink.Text = "Site da Ete";
            this.EteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EteLinkClicked);
            // 
            // AvaLink
            // 
            this.AvaLink.AutoSize = true;
            this.AvaLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvaLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AvaLink.Location = new System.Drawing.Point(12, 231);
            this.AvaLink.Name = "AvaLink";
            this.AvaLink.Size = new System.Drawing.Size(128, 32);
            this.AvaLink.TabIndex = 2;
            this.AvaLink.TabStop = true;
            this.AvaLink.Text = "Site AVA";
            this.AvaLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AvaLink_LinkClicked);
            // 
            // GitLink
            // 
            this.GitLink.AutoSize = true;
            this.GitLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GitLink.LinkColor = System.Drawing.Color.Purple;
            this.GitLink.Location = new System.Drawing.Point(12, 307);
            this.GitLink.Name = "GitLink";
            this.GitLink.Size = new System.Drawing.Size(103, 32);
            this.GitLink.TabIndex = 3;
            this.GitLink.TabStop = true;
            this.GitLink.Text = "GitHub";
            this.GitLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitLink_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Login_testes.Properties.Resources.logo_logo_hv_branca_pequena;
            this.pictureBox1.Location = new System.Drawing.Point(152, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 47);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(467, 467);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GitLink);
            this.Controls.Add(this.AvaLink);
            this.Controls.Add(this.EteLink);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel EteLink;
        private System.Windows.Forms.LinkLabel AvaLink;
        private System.Windows.Forms.LinkLabel GitLink;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}