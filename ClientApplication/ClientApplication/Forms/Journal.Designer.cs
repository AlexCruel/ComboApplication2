namespace ClientApplication
{
    partial class Journal
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMark = new System.Windows.Forms.ComboBox();
            this.comboBoxFC = new System.Windows.Forms.ComboBox();
            this.comboBoxDisc = new System.Windows.Forms.ComboBox();
            this.comboBoxStud = new System.Windows.Forms.ComboBox();
            this.comboBoxTeacher = new System.Windows.Forms.ComboBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.comboBoxSemester = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.labelManager = new System.Windows.Forms.Label();
            this.labelFaculty = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(1013, 73);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(197, 20);
            this.dateTimePicker.TabIndex = 65;
            // 
            // comboBoxMark
            // 
            this.comboBoxMark.FormattingEnabled = true;
            this.comboBoxMark.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxMark.Location = new System.Drawing.Point(1013, 347);
            this.comboBoxMark.Name = "comboBoxMark";
            this.comboBoxMark.Size = new System.Drawing.Size(197, 21);
            this.comboBoxMark.TabIndex = 64;
            this.comboBoxMark.Text = "Выбрать";
            // 
            // comboBoxFC
            // 
            this.comboBoxFC.FormattingEnabled = true;
            this.comboBoxFC.Items.AddRange(new object[] {
            "901",
            "902",
            "903",
            "904"});
            this.comboBoxFC.Location = new System.Drawing.Point(1013, 302);
            this.comboBoxFC.Name = "comboBoxFC";
            this.comboBoxFC.Size = new System.Drawing.Size(197, 21);
            this.comboBoxFC.TabIndex = 63;
            // 
            // comboBoxDisc
            // 
            this.comboBoxDisc.FormattingEnabled = true;
            this.comboBoxDisc.Location = new System.Drawing.Point(1013, 257);
            this.comboBoxDisc.Name = "comboBoxDisc";
            this.comboBoxDisc.Size = new System.Drawing.Size(197, 21);
            this.comboBoxDisc.TabIndex = 62;
            // 
            // comboBoxStud
            // 
            this.comboBoxStud.FormattingEnabled = true;
            this.comboBoxStud.Location = new System.Drawing.Point(1013, 211);
            this.comboBoxStud.Name = "comboBoxStud";
            this.comboBoxStud.Size = new System.Drawing.Size(197, 21);
            this.comboBoxStud.TabIndex = 61;
            // 
            // comboBoxTeacher
            // 
            this.comboBoxTeacher.FormattingEnabled = true;
            this.comboBoxTeacher.Location = new System.Drawing.Point(1013, 169);
            this.comboBoxTeacher.Name = "comboBoxTeacher";
            this.comboBoxTeacher.Size = new System.Drawing.Size(197, 21);
            this.comboBoxTeacher.TabIndex = 60;
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(1013, 123);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(197, 21);
            this.comboBoxGroup.TabIndex = 59;
            // 
            // comboBoxSemester
            // 
            this.comboBoxSemester.FormattingEnabled = true;
            this.comboBoxSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxSemester.Location = new System.Drawing.Point(1013, 32);
            this.comboBoxSemester.Name = "comboBoxSemester";
            this.comboBoxSemester.Size = new System.Drawing.Size(197, 21);
            this.comboBoxSemester.TabIndex = 58;
            this.comboBoxSemester.Text = "Выбрать";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(913, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Отметка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(913, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Форма контроля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(913, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Дисциплина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(913, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "ФИО студента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(913, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Семестр";
            this.label1.UseWaitCursor = true;
            // 
            // buttonRecord
            // 
            this.buttonRecord.Location = new System.Drawing.Point(1057, 401);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(125, 37);
            this.buttonRecord.TabIndex = 52;
            this.buttonRecord.Text = "Добавить";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // labelManager
            // 
            this.labelManager.AutoSize = true;
            this.labelManager.Location = new System.Drawing.Point(913, 172);
            this.labelManager.Name = "labelManager";
            this.labelManager.Size = new System.Drawing.Size(86, 13);
            this.labelManager.TabIndex = 51;
            this.labelManager.Text = "Преподаватель";
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.Location = new System.Drawing.Point(913, 126);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.Size = new System.Drawing.Size(42, 13);
            this.labelFaculty.TabIndex = 50;
            this.labelFaculty.Text = "Группа";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(913, 80);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(33, 13);
            this.labelID.TabIndex = 49;
            this.labelID.Text = "Дата";
            this.labelID.UseWaitCursor = true;
            // 
            // Journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 450);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.comboBoxMark);
            this.Controls.Add(this.comboBoxFC);
            this.Controls.Add(this.comboBoxDisc);
            this.Controls.Add(this.comboBoxStud);
            this.Controls.Add(this.comboBoxTeacher);
            this.Controls.Add(this.comboBoxGroup);
            this.Controls.Add(this.comboBoxSemester);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRecord);
            this.Controls.Add(this.labelManager);
            this.Controls.Add(this.labelFaculty);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Journal";
            this.Text = "Journal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxMark;
        private System.Windows.Forms.ComboBox comboBoxFC;
        private System.Windows.Forms.ComboBox comboBoxDisc;
        private System.Windows.Forms.ComboBox comboBoxStud;
        private System.Windows.Forms.ComboBox comboBoxTeacher;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.ComboBox comboBoxSemester;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Label labelManager;
        private System.Windows.Forms.Label labelFaculty;
        private System.Windows.Forms.Label labelID;
    }
}