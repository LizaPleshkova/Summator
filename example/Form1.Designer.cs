namespace example
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
            this.regLabel = new System.Windows.Forms.Label();
            this.buttonAuthor = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.closeX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.regLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLabel.Location = new System.Drawing.Point(255, 504);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(170, 20);
            this.regLabel.TabIndex = 23;
            this.regLabel.Text = "Еще нет аккаунта?";
            this.regLabel.Click += new System.EventHandler(this.buttonAuthor_Click);
            this.regLabel.MouseEnter += new System.EventHandler(this.closeX_MouseEnter);
            this.regLabel.MouseLeave += new System.EventHandler(this.closeX_MouseLeave);
            // 
            // buttonAuthor
            // 
            this.buttonAuthor.BackColor = System.Drawing.Color.White;
            this.buttonAuthor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAuthor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonAuthor.Location = new System.Drawing.Point(207, 438);
            this.buttonAuthor.Name = "buttonAuthor";
            this.buttonAuthor.Size = new System.Drawing.Size(269, 43);
            this.buttonAuthor.TabIndex = 22;
            this.buttonAuthor.Text = "Войти";
            this.buttonAuthor.UseVisualStyleBackColor = false;
            this.buttonAuthor.Click += new System.EventHandler(this.buttonAuthor_Click);
            this.buttonAuthor.MouseEnter += new System.EventHandler(this.closeX_MouseEnter);
            this.buttonAuthor.MouseLeave += new System.EventHandler(this.closeX_MouseLeave);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(300, 295);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(176, 22);
            this.password.TabIndex = 21;
            this.password.UseSystemPasswordChar = true;
            this.password.Click += new System.EventHandler(this.buttonAuthor_Click);
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.MouseEnter += new System.EventHandler(this.closeX_MouseEnter);
            this.password.MouseLeave += new System.EventHandler(this.closeX_MouseLeave);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login.Location = new System.Drawing.Point(300, 207);
            this.login.Multiline = true;
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(176, 40);
            this.login.TabIndex = 20;
            this.login.Click += new System.EventHandler(this.buttonAuthor_Click);
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            this.login.MouseEnter += new System.EventHandler(this.closeX_MouseEnter);
            this.login.MouseLeave += new System.EventHandler(this.closeX_MouseLeave);
            // 
            // closeX
            // 
            this.closeX.AutoSize = true;
            this.closeX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.closeX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.closeX.Location = new System.Drawing.Point(592, 10);
            this.closeX.Name = "closeX";
            this.closeX.Size = new System.Drawing.Size(34, 39);
            this.closeX.TabIndex = 19;
            this.closeX.Text = "x";
            this.closeX.Click += new System.EventHandler(this.buttonAuthor_Click);
            this.closeX.MouseEnter += new System.EventHandler(this.closeX_MouseEnter);
            this.closeX.MouseLeave += new System.EventHandler(this.closeX_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(227, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 39);
            this.label1.TabIndex = 18;
            this.label1.Text = "Авторизация";
            this.label1.Click += new System.EventHandler(this.buttonAuthor_Click);
            this.label1.MouseEnter += new System.EventHandler(this.closeX_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.closeX_MouseLeave);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(745, 540);
            this.mainPanel.TabIndex = 17;
            this.mainPanel.TabStop = false;
            this.mainPanel.Click += new System.EventHandler(this.buttonAuthor_Click);
            this.mainPanel.MouseEnter += new System.EventHandler(this.closeX_MouseEnter);
            this.mainPanel.MouseLeave += new System.EventHandler(this.closeX_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 540);
            this.Controls.Add(this.regLabel);
            this.Controls.Add(this.buttonAuthor);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.closeX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label regLabel;
        private System.Windows.Forms.Button buttonAuthor;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label closeX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox mainPanel;
    }
}

