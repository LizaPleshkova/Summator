namespace allForms
{
    partial class MainForm
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
            this.closeX = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.ExitAcount = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBoxDateSearch = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.DateSearch = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainPanel = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // closeX
            // 
            this.closeX.AutoSize = true;
            this.closeX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(146)))));
            this.closeX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.closeX.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeX.Location = new System.Drawing.Point(1001, 0);
            this.closeX.Name = "closeX";
            this.closeX.Size = new System.Drawing.Size(34, 39);
            this.closeX.TabIndex = 12;
            this.closeX.Text = "x";
            this.closeX.Click += new System.EventHandler(this.closeX_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic);
            this.buttonSave.Location = new System.Drawing.Point(76, 560);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(176, 32);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ExitAcount
            // 
            this.ExitAcount.AutoSize = true;
            this.ExitAcount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitAcount.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.ExitAcount.Location = new System.Drawing.Point(823, 14);
            this.ExitAcount.Name = "ExitAcount";
            this.ExitAcount.Size = new System.Drawing.Size(165, 21);
            this.ExitAcount.TabIndex = 21;
            this.ExitAcount.Text = "Выйти из аккаунта";
            this.ExitAcount.Click += new System.EventHandler(this.ExitAcount_Click);
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.textSearch.Location = new System.Drawing.Point(715, 68);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(221, 28);
            this.textSearch.TabIndex = 22;
            this.textSearch.Enter += new System.EventHandler(this.textSearch_Enter);
            this.textSearch.Leave += new System.EventHandler(this.textSearch_Leave);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Arial", 20F);
            this.monthCalendar1.Location = new System.Drawing.Point(62, 51);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 24;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.Salmon;
            this.monthCalendar1.TrailingForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // textBoxNote
            // 
            this.textBoxNote.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.textBoxNote.Location = new System.Drawing.Point(76, 165);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(464, 379);
            this.textBoxNote.TabIndex = 27;
            this.textBoxNote.TextChanged += new System.EventHandler(this.textBoxNote_TextChanged);
            this.textBoxNote.Enter += new System.EventHandler(this.textBoxNote_Enter);
            this.textBoxNote.Leave += new System.EventHandler(this.textBoxNote_Leave);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.textBoxTitle.Location = new System.Drawing.Point(76, 86);
            this.textBoxTitle.Multiline = true;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(289, 61);
            this.textBoxTitle.TabIndex = 30;
            this.textBoxTitle.Enter += new System.EventHandler(this.textBoxTitle_Enter);
            this.textBoxTitle.Leave += new System.EventHandler(this.textBoxTitle_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(379, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 61);
            this.button1.TabIndex = 35;
            this.button1.Text = "Выбрать цвет фона";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic);
            this.buttonDelete.Location = new System.Drawing.Point(275, 560);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(181, 32);
            this.buttonDelete.TabIndex = 42;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(216)))), ((int)(((byte)(204)))));
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.monthCalendar1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(609, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 310);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Календарь";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic);
            this.button3.Location = new System.Drawing.Point(60, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(215, 34);
            this.button3.TabIndex = 46;
            this.button3.Text = "скрыть календарь";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBoxDateSearch
            // 
            this.textBoxDateSearch.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.textBoxDateSearch.Location = new System.Drawing.Point(609, 186);
            this.textBoxDateSearch.Name = "textBoxDateSearch";
            this.textBoxDateSearch.Size = new System.Drawing.Size(275, 28);
            this.textBoxDateSearch.TabIndex = 44;
            this.textBoxDateSearch.Enter += new System.EventHandler(this.textBoxDateSearch_Enter);
            this.textBoxDateSearch.Leave += new System.EventHandler(this.textBoxDateSearch_Leave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic);
            this.button2.Location = new System.Drawing.Point(609, 561);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(327, 34);
            this.button2.TabIndex = 47;
            this.button2.Text = "Личные праздники";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DateSearch
            // 
            this.DateSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.DateSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DateSearch.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.DateSearch.Image = global::allForms.Properties.Resources.icons8_google_поиск_40;
            this.DateSearch.Location = new System.Drawing.Point(893, 186);
            this.DateSearch.Name = "DateSearch";
            this.DateSearch.Size = new System.Drawing.Size(31, 31);
            this.DateSearch.TabIndex = 45;
            this.DateSearch.UseVisualStyleBackColor = false;
            this.DateSearch.Click += new System.EventHandler(this.DateSearch_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Search.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Italic);
            this.Search.Image = global::allForms.Properties.Resources.icons8_google_поиск_40;
            this.Search.Location = new System.Drawing.Point(942, 68);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(31, 31);
            this.Search.TabIndex = 23;
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(211)))));
            this.pictureBox1.Location = new System.Drawing.Point(57, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(931, 573);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mainPanel.BackgroundImage = global::allForms.Properties.Resources.town;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Image = global::allForms.Properties.Resources.town;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1035, 660);
            this.mainPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPanel.TabIndex = 10;
            this.mainPanel.TabStop = false;
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 660);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.closeX);
            this.Controls.Add(this.DateSearch);
            this.Controls.Add(this.textBoxDateSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.textBoxNote);
            this.Controls.Add(this.ExitAcount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label closeX;
        private System.Windows.Forms.PictureBox mainPanel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label ExitAcount;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDateSearch;
        private System.Windows.Forms.Button DateSearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button button2;
    }
}