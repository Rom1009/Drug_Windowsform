namespace DXApplication1
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtpassWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DXApplication1.Properties.Resources.logo_no_background;
            this.pictureBox1.Location = new System.Drawing.Point(243, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(804, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.txtuserName);
            this.panel1.ForeColor = System.Drawing.Color.Ivory;
            this.panel1.Location = new System.Drawing.Point(489, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 43);
            this.panel1.TabIndex = 2;
            // 
            // txtuserName
            // 
            this.txtuserName.BackColor = System.Drawing.SystemColors.Window;
            this.txtuserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtuserName.Location = new System.Drawing.Point(0, 0);
            this.txtuserName.Multiline = true;
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(559, 36);
            this.txtuserName.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Controls.Add(this.txtpassWord);
            this.panel3.ForeColor = System.Drawing.Color.Ivory;
            this.panel3.Location = new System.Drawing.Point(489, 453);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 43);
            this.panel3.TabIndex = 3;
            // 
            // txtpassWord
            // 
            this.txtpassWord.BackColor = System.Drawing.SystemColors.Window;
            this.txtpassWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtpassWord.Location = new System.Drawing.Point(0, 0);
            this.txtpassWord.Multiline = true;
            this.txtpassWord.Name = "txtpassWord";
            this.txtpassWord.PasswordChar = '*';
            this.txtpassWord.Size = new System.Drawing.Size(559, 36);
            this.txtpassWord.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(249, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(249, 450);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 39);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnLogin.Location = new System.Drawing.Point(459, 554);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(400, 72);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1346, 645);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Green;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtuserName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtpassWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
    }
}