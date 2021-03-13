namespace allForms
{
    partial class PersonalHolidays
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
            this.mainPanel = new System.Windows.Forms.PictureBox();
            this.holidays_calendar = new System.Windows.Forms.MonthCalendar();
            this.holiday_note = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.holiday_date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(220)))), ((int)(((byte)(211)))));
            this.pictureBox1.Location = new System.Drawing.Point(78, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 345);
            this.pictureBox1.TabIndex = 38;
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
            this.mainPanel.Size = new System.Drawing.Size(804, 474);
            this.mainPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mainPanel.TabIndex = 37;
            this.mainPanel.TabStop = false;
            // 
            // holidays_calendar
            // 
            this.holidays_calendar.Location = new System.Drawing.Point(123, 134);
            this.holidays_calendar.Name = "holidays_calendar";
            this.holidays_calendar.TabIndex = 39;
            this.holidays_calendar.TitleBackColor = System.Drawing.Color.Red;
            this.holidays_calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.holidays_calendar_DateChanged);
            // 
            // holiday_note
            // 
            this.holiday_note.Location = new System.Drawing.Point(327, 134);
            this.holiday_note.Multiline = true;
            this.holiday_note.Name = "holiday_note";
            this.holiday_note.Size = new System.Drawing.Size(363, 169);
            this.holiday_note.TabIndex = 40;
            this.holiday_note.TextChanged += new System.EventHandler(this.holiday_note_TextChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic);
            this.buttonSave.Location = new System.Drawing.Point(327, 309);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(176, 32);
            this.buttonSave.TabIndex = 41;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(169)))), ((int)(((byte)(148)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Italic);
            this.buttonDelete.Location = new System.Drawing.Point(509, 309);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(181, 32);
            this.buttonDelete.TabIndex = 43;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            // 
            // holiday_date
            // 
            this.holiday_date.AutoSize = true;
            this.holiday_date.Location = new System.Drawing.Point(120, 108);
            this.holiday_date.Name = "holiday_date";
            this.holiday_date.Size = new System.Drawing.Size(46, 17);
            this.holiday_date.TabIndex = 44;
            this.holiday_date.Text = "label1";
            // 
            // PersonalHolidays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 474);
            this.Controls.Add(this.holiday_date);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.holiday_note);
            this.Controls.Add(this.holidays_calendar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mainPanel);
            this.Name = "PersonalHolidays";
            this.Text = "PersonalHolidays";
            this.Load += new System.EventHandler(this.PersonalHolidays_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox mainPanel;
        private System.Windows.Forms.MonthCalendar holidays_calendar;
        private System.Windows.Forms.TextBox holiday_note;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label holiday_date;
    }
}