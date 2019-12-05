using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication
{
    public partial class Main : Form
    {
        private bool isCollapsed;
        private Auth Auth;

        public Main(Auth auth)
        {
            InitializeComponent();
            this.Auth = auth;
        }

        // выпадающая панель "Деканат"
        private void timerMain_Tick(object sender, EventArgs e)
        {

        }

        private void buttonDeanery_Click(object sender, EventArgs e)
        {
            timerDeanery.Start();     // таймер для "Деканат"
        }

        // выпадающая панель "Преподаватель"
        private void timerTeacher_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                flowLayoutPanelTeacher.Height += 10;
                if (flowLayoutPanelTeacher.Size == flowLayoutPanelTeacher.MaximumSize)
                {
                    timerTeacher.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                flowLayoutPanelTeacher.Height -= 10;
                if (flowLayoutPanelTeacher.Size == flowLayoutPanelTeacher.MinimumSize)
                {
                    timerTeacher.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void buttonTeacher_Click(object sender, EventArgs e)
        {
            timerTeacher.Start();     // таймер для "Преподаватель"
        }

        // выпадающая панель "Инф. о группах"
        private void timerInfoGroup_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                flowLayoutPanelGroup.Height += 10;
                if (flowLayoutPanelGroup.Size == flowLayoutPanelGroup.MaximumSize)
                {
                    timerInfoGroup.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                flowLayoutPanelGroup.Height -= 10;
                if (flowLayoutPanelGroup.Size == flowLayoutPanelGroup.MinimumSize)
                {
                    timerInfoGroup.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void buttonGroupInfo_Click(object sender, EventArgs e)
        {
            timerInfoGroup.Start();    // таймер для "Инф. о группах"
        }

        // выпадающая панель "Journal"
        private void timerJournal_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                flowLayoutPanelJournal.Height += 10;
                if (flowLayoutPanelJournal.Size == flowLayoutPanelJournal.MaximumSize)
                {
                    timerJournal.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                flowLayoutPanelJournal.Height -= 10;
                if (flowLayoutPanelJournal.Size == flowLayoutPanelJournal.MinimumSize)
                {
                    timerJournal.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void buttonJournalPerform_Click(object sender, EventArgs e)
        {
            timerJournal.Start();    // таймер для "Журнал"
        }

        // выход
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void flowLayoutPanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonGroupInfo_Click_1(object sender, EventArgs e)
        {
            timerInfoGroup.Start();
        }

        private void buttonTeacher_Click_1(object sender, EventArgs e)
        {
            timerTeacher.Start();
        }

        private void buttonDeanery_Click_1(object sender, EventArgs e)
        {
            timerDeanery.Start();
        }

        private void timerDeanery_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                // opened
                flowLayoutPanelDeanery.Height += 10;
                if (flowLayoutPanelDeanery.Size == flowLayoutPanelDeanery.MaximumSize)
                {
                    timerDeanery.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                // closed
                flowLayoutPanelDeanery.Height -= 10;
                if (flowLayoutPanelDeanery.Size == flowLayoutPanelDeanery.MinimumSize)
                {
                    timerDeanery.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void buttonFaculty_Click(object sender, EventArgs e)
        {
            Faculty form = new Faculty();
            form.Show();
        }

        private void buttonSpecialty_Click(object sender, EventArgs e)
        {
            Specialty form = new Specialty();
            form.Show();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
            Auth.Close();
        }

        private void buttonJournal_Click(object sender, EventArgs e)
        {
            Journal form = new Journal();
            form.Show();
        }

        private void buttonDiscipline_Click(object sender, EventArgs e)
        {
            Discipline form = new Discipline();
            form.Show();
        }

        private void buttonGroup_Click(object sender, EventArgs e)
        {
            Group form = new Group();
            form.Show();
        }

        private void buttonStudent_Click(object sender, EventArgs e)
        {
            Student form = new Student();
            form.Show();
        }

        private void buttonExam_Click(object sender, EventArgs e)
        {
            Exam form = new Exam();
            form.Show();
        }

        private void buttonAcPerform_Click(object sender, EventArgs e)
        {
            StudPerform form = new StudPerform();
            form.Show();
        }

        private void buttonGrPerform_Click(object sender, EventArgs e)
        {
            StudPerformGroup form = new StudPerformGroup();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report form = new Report();
            form.Show();
        }
    }
}
