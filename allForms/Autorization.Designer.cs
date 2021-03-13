namespace allForms
{
    partial class Autorization
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
            this.closeX = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.regLabel = new System.Windows.Forms.Label();
            this.buttonAuthor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(156)))), ((int)(((byte)(133)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(661, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "    Авторизация    ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeX
            // 
            this.closeX.AutoSize = true;
            this.closeX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.closeX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.closeX.Location = new System.Drawing.Point(993, 0);
            this.closeX.Name = "closeX";
            this.closeX.Size = new System.Drawing.Size(34, 39);
            this.closeX.TabIndex = 10;
            this.closeX.Text = "x";
            this.closeX.Click += new System.EventHandler(this.closeX_Click_1);
            this.closeX.MouseEnter += new System.EventHandler(this.closeX_MouseEnter);
            this.closeX.MouseLeave += new System.EventHandler(this.closeX_MouseLeave);
            // 
            // login
            // 
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.login.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Italic);
            this.login.ForeColor = System.Drawing.SystemColors.WindowText;
            this.login.Location = new System.Drawing.Point(688, 220);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(256, 29);
            this.login.TabIndex = 11;
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login.Enter += new System.EventHandler(this.login_Enter);
            this.login.Leave += new System.EventHandler(this.login_Leave);
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Italic);
            this.password.Location = new System.Drawing.Point(688, 296);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(256, 29);
            this.password.TabIndex = 12;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.BackColor = System.Drawing.Color.Transparent;
            this.regLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regLabel.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic);
            this.regLabel.Location = new System.Drawing.Point(745, 441);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(144, 17);
            this.regLabel.TabIndex = 16;
            this.regLabel.Text = "Еще нет аккаунта?";
            this.regLabel.Click += new System.EventHandler(this.regLabel_Click);
            // 
            // buttonAuthor
            // 
            this.buttonAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(156)))), ((int)(((byte)(133)))));
            this.buttonAuthor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(55)))), ((int)(((byte)(50)))));
            this.buttonAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAuthor.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Italic);
            this.buttonAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonAuthor.Location = new System.Drawing.Point(668, 366);
            this.buttonAuthor.Name = "buttonAuthor";
            this.buttonAuthor.Size = new System.Drawing.Size(305, 47);
            this.buttonAuthor.TabIndex = 13;
            this.buttonAuthor.Text = "Войти";
            this.buttonAuthor.UseVisualStyleBackColor = false;
            this.buttonAuthor.Click += new System.EventHandler(this.buttonAuthor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.pictureBox1.Location = new System.Drawing.Point(576, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 615);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Image = global::allForms.Properties.Resources.town;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1027, 615);
            this.mainPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPanel.TabIndex = 1;
            this.mainPanel.TabStop = false;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 615);
            this.Controls.Add(this.regLabel);
            this.Controls.Add(this.buttonAuthor);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.closeX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Autorization";
            this.Text = "Autorization";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label closeX;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.Button buttonAuthor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}