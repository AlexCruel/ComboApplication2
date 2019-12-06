namespace ClientApplication
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanelMain = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelDeanery = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDeanery = new System.Windows.Forms.Button();
            this.buttonFaculty = new System.Windows.Forms.Button();
            this.buttonSpecialty = new System.Windows.Forms.Button();
            this.flowLayoutPanelTeacher = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonTeacher = new System.Windows.Forms.Button();
            this.buttonJournal = new System.Windows.Forms.Button();
            this.buttonDiscipline = new System.Windows.Forms.Button();
            this.flowLayoutPanelGroup = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonGroupInfo = new System.Windows.Forms.Button();
            this.buttonGroup = new System.Windows.Forms.Button();
            this.buttonStudent = new System.Windows.Forms.Button();
            this.flowLayoutPanelJournal = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonJournalPerform = new System.Windows.Forms.Button();
            this.buttonExam = new System.Windows.Forms.Button();
            this.buttonAcPerform = new System.Windows.Forms.Button();
            this.buttonGrPerform = new System.Windows.Forms.Button();
            this.timerTeacher = new System.Windows.Forms.Timer(this.components);
            this.timerInfoGroup = new System.Windows.Forms.Timer(this.components);
            this.timerJournal = new System.Windows.Forms.Timer(this.components);
            this.timerDeanery = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanelMain.SuspendLayout();
            this.flowLayoutPanelDeanery.SuspendLayout();
            this.flowLayoutPanelTeacher.SuspendLayout();
            this.flowLayoutPanelGroup.SuspendLayout();
            this.flowLayoutPanelJournal.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(946, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создать отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanelMain
            // 
            this.flowLayoutPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.flowLayoutPanelMain.Controls.Add(this.flowLayoutPanelDeanery);
            this.flowLayoutPanelMain.Controls.Add(this.flowLayoutPanelTeacher);
            this.flowLayoutPanelMain.Controls.Add(this.flowLayoutPanelGroup);
            this.flowLayoutPanelMain.Controls.Add(this.flowLayoutPanelJournal);
            this.flowLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMain.Name = "flowLayoutPanelMain";
            this.flowLayoutPanelMain.Size = new System.Drawing.Size(207, 586);
            this.flowLayoutPanelMain.TabIndex = 1;
            this.flowLayoutPanelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelMain_Paint);
            // 
            // flowLayoutPanelDeanery
            // 
            this.flowLayoutPanelDeanery.Controls.Add(this.buttonDeanery);
            this.flowLayoutPanelDeanery.Controls.Add(this.buttonFaculty);
            this.flowLayoutPanelDeanery.Controls.Add(this.buttonSpecialty);
            this.flowLayoutPanelDeanery.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelDeanery.MaximumSize = new System.Drawing.Size(204, 189);
            this.flowLayoutPanelDeanery.MinimumSize = new System.Drawing.Size(204, 63);
            this.flowLayoutPanelDeanery.Name = "flowLayoutPanelDeanery";
            this.flowLayoutPanelDeanery.Size = new System.Drawing.Size(204, 63);
            this.flowLayoutPanelDeanery.TabIndex = 3;
            // 
            // buttonDeanery
            // 
            this.buttonDeanery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDeanery.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDeanery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonDeanery.FlatAppearance.BorderSize = 3;
            this.buttonDeanery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeanery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeanery.ForeColor = System.Drawing.Color.Black;
            this.buttonDeanery.Location = new System.Drawing.Point(3, 3);
            this.buttonDeanery.Name = "buttonDeanery";
            this.buttonDeanery.Size = new System.Drawing.Size(197, 56);
            this.buttonDeanery.TabIndex = 2;
            this.buttonDeanery.Text = "Деканат";
            this.buttonDeanery.UseVisualStyleBackColor = false;
            this.buttonDeanery.Click += new System.EventHandler(this.buttonDeanery_Click_1);
            // 
            // buttonFaculty
            // 
            this.buttonFaculty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonFaculty.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFaculty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonFaculty.FlatAppearance.BorderSize = 3;
            this.buttonFaculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFaculty.Font = new System.Drawing.Font("Century Gothic", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonFaculty.ForeColor = System.Drawing.Color.Black;
            this.buttonFaculty.Location = new System.Drawing.Point(3, 65);
            this.buttonFaculty.Name = "buttonFaculty";
            this.buttonFaculty.Size = new System.Drawing.Size(197, 56);
            this.buttonFaculty.TabIndex = 3;
            this.buttonFaculty.Text = "Факультеты";
            this.buttonFaculty.UseVisualStyleBackColor = false;
            this.buttonFaculty.Click += new System.EventHandler(this.buttonFaculty_Click);
            // 
            // buttonSpecialty
            // 
            this.buttonSpecialty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonSpecialty.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSpecialty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSpecialty.FlatAppearance.BorderSize = 3;
            this.buttonSpecialty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSpecialty.Font = new System.Drawing.Font("Century Gothic", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSpecialty.ForeColor = System.Drawing.Color.Black;
            this.buttonSpecialty.Location = new System.Drawing.Point(3, 127);
            this.buttonSpecialty.Name = "buttonSpecialty";
            this.buttonSpecialty.Size = new System.Drawing.Size(197, 56);
            this.buttonSpecialty.TabIndex = 4;
            this.buttonSpecialty.Text = "Специальности";
            this.buttonSpecialty.UseVisualStyleBackColor = false;
            this.buttonSpecialty.Click += new System.EventHandler(this.buttonSpecialty_Click);
            // 
            // flowLayoutPanelTeacher
            // 
            this.flowLayoutPanelTeacher.Controls.Add(this.buttonTeacher);
            this.flowLayoutPanelTeacher.Controls.Add(this.buttonJournal);
            this.flowLayoutPanelTeacher.Controls.Add(this.buttonDiscipline);
            this.flowLayoutPanelTeacher.Location = new System.Drawing.Point(3, 72);
            this.flowLayoutPanelTeacher.MaximumSize = new System.Drawing.Size(204, 192);
            this.flowLayoutPanelTeacher.MinimumSize = new System.Drawing.Size(204, 63);
            this.flowLayoutPanelTeacher.Name = "flowLayoutPanelTeacher";
            this.flowLayoutPanelTeacher.Size = new System.Drawing.Size(204, 64);
            this.flowLayoutPanelTeacher.TabIndex = 4;
            // 
            // buttonTeacher
            // 
            this.buttonTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTeacher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonTeacher.FlatAppearance.BorderSize = 3;
            this.buttonTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTeacher.ForeColor = System.Drawing.Color.Black;
            this.buttonTeacher.Location = new System.Drawing.Point(3, 3);
            this.buttonTeacher.Name = "buttonTeacher";
            this.buttonTeacher.Size = new System.Drawing.Size(197, 56);
            this.buttonTeacher.TabIndex = 2;
            this.buttonTeacher.Text = "Преподаватель";
            this.buttonTeacher.UseVisualStyleBackColor = false;
            this.buttonTeacher.Click += new System.EventHandler(this.buttonTeacher_Click_1);
            // 
            // buttonJournal
            // 
            this.buttonJournal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonJournal.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonJournal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonJournal.FlatAppearance.BorderSize = 3;
            this.buttonJournal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJournal.Font = new System.Drawing.Font("Century Gothic", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonJournal.ForeColor = System.Drawing.Color.Black;
            this.buttonJournal.Location = new System.Drawing.Point(3, 65);
            this.buttonJournal.Name = "buttonJournal";
            this.buttonJournal.Size = new System.Drawing.Size(197, 56);
            this.buttonJournal.TabIndex = 3;
            this.buttonJournal.Text = "Журнал преподавателя";
            this.buttonJournal.UseVisualStyleBackColor = false;
            this.buttonJournal.Click += new System.EventHandler(this.buttonJournal_Click);
            // 
            // buttonDiscipline
            // 
            this.buttonDiscipline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonDiscipline.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDiscipline.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonDiscipline.FlatAppearance.BorderSize = 3;
            this.buttonDiscipline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDiscipline.Font = new System.Drawing.Font("Century Gothic", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDiscipline.ForeColor = System.Drawing.Color.Black;
            this.buttonDiscipline.Location = new System.Drawing.Point(3, 127);
            this.buttonDiscipline.Name = "buttonDiscipline";
            this.buttonDiscipline.Size = new System.Drawing.Size(197, 56);
            this.buttonDiscipline.TabIndex = 5;
            this.buttonDiscipline.Text = "Дисциплины";
            this.buttonDiscipline.UseVisualStyleBackColor = false;
            this.buttonDiscipline.Click += new System.EventHandler(this.buttonDiscipline_Click);
            // 
            // flowLayoutPanelGroup
            // 
            this.flowLayoutPanelGroup.Controls.Add(this.buttonGroupInfo);
            this.flowLayoutPanelGroup.Controls.Add(this.buttonGroup);
            this.flowLayoutPanelGroup.Controls.Add(this.buttonStudent);
            this.flowLayoutPanelGroup.Location = new System.Drawing.Point(3, 142);
            this.flowLayoutPanelGroup.MaximumSize = new System.Drawing.Size(204, 191);
            this.flowLayoutPanelGroup.MinimumSize = new System.Drawing.Size(204, 63);
            this.flowLayoutPanelGroup.Name = "flowLayoutPanelGroup";
            this.flowLayoutPanelGroup.Size = new System.Drawing.Size(204, 65);
            this.flowLayoutPanelGroup.TabIndex = 5;
            // 
            // buttonGroupInfo
            // 
            this.buttonGroupInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonGroupInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGroupInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonGroupInfo.FlatAppearance.BorderSize = 3;
            this.buttonGroupInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroupInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGroupInfo.ForeColor = System.Drawing.Color.Black;
            this.buttonGroupInfo.Location = new System.Drawing.Point(3, 3);
            this.buttonGroupInfo.Name = "buttonGroupInfo";
            this.buttonGroupInfo.Size = new System.Drawing.Size(197, 56);
            this.buttonGroupInfo.TabIndex = 2;
            this.buttonGroupInfo.Text = "Инф. о группах";
            this.buttonGroupInfo.UseVisualStyleBackColor = false;
            this.buttonGroupInfo.Click += new System.EventHandler(this.buttonGroupInfo_Click_1);
            // 
            // buttonGroup
            // 
            this.buttonGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonGroup.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonGroup.FlatAppearance.BorderSize = 3;
            this.buttonGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGroup.Font = new System.Drawing.Font("Century Gothic", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGroup.ForeColor = System.Drawing.Color.Black;
            this.buttonGroup.Location = new System.Drawing.Point(3, 65);
            this.buttonGroup.Name = "buttonGroup";
            this.buttonGroup.Size = new System.Drawing.Size(197, 56);
            this.buttonGroup.TabIndex = 3;
            this.buttonGroup.Text = "Группы";
            this.buttonGroup.UseVisualStyleBackColor = false;
            this.buttonGroup.Click += new System.EventHandler(this.buttonGroup_Click);
            // 
            // buttonStudent
            // 
            this.buttonStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStudent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonStudent.FlatAppearance.BorderSize = 3;
            this.buttonStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStudent.Font = new System.Drawing.Font("Century Gothic", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStudent.ForeColor = System.Drawing.Color.Black;
            this.buttonStudent.Location = new System.Drawing.Point(3, 127);
            this.buttonStudent.Name = "buttonStudent";
            this.buttonStudent.Size = new System.Drawing.Size(197, 56);
            this.buttonStudent.TabIndex = 4;
            this.buttonStudent.Text = "Студенты";
            this.buttonStudent.UseVisualStyleBackColor = false;
            this.buttonStudent.Click += new System.EventHandler(this.buttonStudent_Click);
            // 
            // flowLayoutPanelJournal
            // 
            this.flowLayoutPanelJournal.Controls.Add(this.buttonJournalPerform);
            this.flowLayoutPanelJournal.Controls.Add(this.buttonExam);
            this.flowLayoutPanelJournal.Controls.Add(this.buttonAcPerform);
            this.flowLayoutPanelJournal.Controls.Add(this.buttonGrPerform);
            this.flowLayoutPanelJournal.Location = new System.Drawing.Point(3, 213);
            this.flowLayoutPanelJournal.MaximumSize = new System.Drawing.Size(204, 251);
            this.flowLayoutPanelJournal.MinimumSize = new System.Drawing.Size(204, 63);
            this.flowLayoutPanelJournal.Name = "flowLayoutPanelJournal";
            this.flowLayoutPanelJournal.Size = new System.Drawing.Size(204, 65);
            this.flowLayoutPanelJournal.TabIndex = 6;
            // 
            // buttonJournalPerform
            // 
            this.buttonJournalPerform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonJournalPerform.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonJournalPerform.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonJournalPerform.FlatAppearance.BorderSize = 3;
            this.buttonJournalPerform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJournalPerform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonJournalPerform.ForeColor = System.Drawing.Color.Black;
            this.buttonJournalPerform.Location = new System.Drawing.Point(3, 3);
            this.buttonJournalPerform.Name = "buttonJournalPerform";
            this.buttonJournalPerform.Size = new System.Drawing.Size(197, 56);
            this.buttonJournalPerform.TabIndex = 2;
            this.buttonJournalPerform.Text = "Отчёт";
            this.buttonJournalPerform.UseVisualStyleBackColor = false;
            this.buttonJournalPerform.Click += new System.EventHandler(this.buttonJournalPerform_Click);
            // 
            // buttonExam
            // 
            this.buttonExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonExam.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonExam.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonExam.FlatAppearance.BorderSize = 3;
            this.buttonExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExam.Font = new System.Drawing.Font("Century Gothic", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExam.ForeColor = System.Drawing.Color.Black;
            this.buttonExam.Location = new System.Drawing.Point(3, 65);
            this.buttonExam.Name = "buttonExam";
            this.buttonExam.Size = new System.Drawing.Size(197, 56);
            this.buttonExam.TabIndex = 3;
            this.buttonExam.Text = "Экзамен";
            this.buttonExam.UseVisualStyleBackColor = false;
            this.buttonExam.Click += new System.EventHandler(this.buttonExam_Click);
            // 
            // buttonAcPerform
            // 
            this.buttonAcPerform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonAcPerform.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAcPerform.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonAcPerform.FlatAppearance.BorderSize = 3;
            this.buttonAcPerform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcPerform.Font = new System.Drawing.Font("Century Gothic", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAcPerform.ForeColor = System.Drawing.Color.Black;
            this.buttonAcPerform.Location = new System.Drawing.Point(3, 127);
            this.buttonAcPerform.Name = "buttonAcPerform";
            this.buttonAcPerform.Size = new System.Drawing.Size(197, 56);
            this.buttonAcPerform.TabIndex = 4;
            this.buttonAcPerform.Text = "Успеваемость студентов";
            this.buttonAcPerform.UseVisualStyleBackColor = false;
            this.buttonAcPerform.Click += new System.EventHandler(this.buttonAcPerform_Click);
            // 
            // buttonGrPerform
            // 
            this.buttonGrPerform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonGrPerform.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGrPerform.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonGrPerform.FlatAppearance.BorderSize = 3;
            this.buttonGrPerform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGrPerform.Font = new System.Drawing.Font("Century Gothic", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGrPerform.ForeColor = System.Drawing.Color.Black;
            this.buttonGrPerform.Location = new System.Drawing.Point(3, 189);
            this.buttonGrPerform.Name = "buttonGrPerform";
            this.buttonGrPerform.Size = new System.Drawing.Size(197, 56);
            this.buttonGrPerform.TabIndex = 5;
            this.buttonGrPerform.Text = "Успеваемость по группам";
            this.buttonGrPerform.UseVisualStyleBackColor = false;
            this.buttonGrPerform.Click += new System.EventHandler(this.buttonGrPerform_Click);
            // 
            // timerTeacher
            // 
            this.timerTeacher.Interval = 15;
            this.timerTeacher.Tick += new System.EventHandler(this.timerTeacher_Tick);
            // 
            // timerInfoGroup
            // 
            this.timerInfoGroup.Interval = 15;
            this.timerInfoGroup.Tick += new System.EventHandler(this.timerInfoGroup_Tick);
            // 
            // timerJournal
            // 
            this.timerJournal.Interval = 15;
            this.timerJournal.Tick += new System.EventHandler(this.timerJournal_Tick);
            // 
            // timerDeanery
            // 
            this.timerDeanery.Interval = 15;
            this.timerDeanery.Tick += new System.EventHandler(this.timerDeanery_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 586);
            this.Controls.Add(this.flowLayoutPanelMain);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.flowLayoutPanelMain.ResumeLayout(false);
            this.flowLayoutPanelDeanery.ResumeLayout(false);
            this.flowLayoutPanelTeacher.ResumeLayout(false);
            this.flowLayoutPanelGroup.ResumeLayout(false);
            this.flowLayoutPanelJournal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDeanery;
        private System.Windows.Forms.Button buttonDeanery;
        private System.Windows.Forms.Button buttonFaculty;
        private System.Windows.Forms.Button buttonSpecialty;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTeacher;
        private System.Windows.Forms.Button buttonTeacher;
        private System.Windows.Forms.Button buttonJournal;
        private System.Windows.Forms.Button buttonDiscipline;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelGroup;
        private System.Windows.Forms.Button buttonGroupInfo;
        private System.Windows.Forms.Button buttonGroup;
        private System.Windows.Forms.Button buttonStudent;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelJournal;
        private System.Windows.Forms.Button buttonJournalPerform;
        private System.Windows.Forms.Button buttonExam;
        private System.Windows.Forms.Button buttonAcPerform;
        private System.Windows.Forms.Button buttonGrPerform;
        private System.Windows.Forms.Timer timerTeacher;
        private System.Windows.Forms.Timer timerInfoGroup;
        private System.Windows.Forms.Timer timerJournal;
        private System.Windows.Forms.Timer timerDeanery;
    }
}