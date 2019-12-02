using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication
{
    public partial class Journal : Form
    {
        public Journal()
        {
            InitializeComponent();
            UpdateData();
            LoadInfoGroup();
            LoadInfoTeacher();
            LoadInfoStudent();
            LoadInfoDiscipline();
            LoadInfoFC();
        }

        private void UpdateData()
        {
            DataSet dst = new DataSet();
            dst.ReadXml(new StringReader(ServerMananger.Select("Journal")));

            if (dst.Tables.Count > 0)
            {
                dataGridView1.DataSource = dst.Tables[0];
            }
        }

        private void LoadInfoGroup()
        {
            DataSet dst = new DataSet();
            dst.ReadXml(new StringReader(ServerMananger.SelectColumn("Группы")));

            comboBoxGroup.DataSource = dst.Tables["g"];
            comboBoxGroup.ValueMember = dst.Tables["g"].Columns[0].ColumnName;
            comboBoxGroup.DisplayMember = dst.Tables["g"].Columns[2].ColumnName;
        }

        private void LoadInfoTeacher()
        {
            DataSet dst = new DataSet();
            dst.ReadXml(new StringReader(ServerMananger.SelectColumn("Преподаватели")));

            comboBoxTeacher.DataSource = dst.Tables["t"];
            comboBoxTeacher.ValueMember = dst.Tables["t"].Columns[0].ColumnName;
            comboBoxTeacher.DisplayMember = dst.Tables["t"].Columns[1].ColumnName;
        }

        private void LoadInfoStudent()
        {
            DataSet dst = new DataSet();
            dst.ReadXml(new StringReader(ServerMananger.SelectColumn("Студенты")));

            comboBoxStud.DataSource = dst.Tables["st"];
            comboBoxStud.ValueMember = dst.Tables["st"].Columns[0].ColumnName;
            comboBoxStud.DisplayMember = dst.Tables["st"].Columns[1].ColumnName;
        }

        private void LoadInfoDiscipline()
        {
            DataSet dst = new DataSet();
            dst.ReadXml(new StringReader(ServerMananger.SelectColumn("Дисциплины")));

            comboBoxDisc.DataSource = dst.Tables["disc"];
            comboBoxDisc.ValueMember = dst.Tables["disc"].Columns[0].ColumnName;
            comboBoxDisc.DisplayMember = dst.Tables["disc"].Columns[1].ColumnName;
        }

        private void LoadInfoFC()
        {
            DataSet dst = new DataSet();
            dst.ReadXml(new StringReader(ServerMananger.SelectColumn("[Форма контроля]")));

            comboBoxFC.DataSource = dst.Tables["fc"];
            comboBoxFC.ValueMember = dst.Tables["fc"].Columns[0].ColumnName;
            comboBoxFC.DisplayMember = dst.Tables["fc"].Columns[1].ColumnName;
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            string semester = comboBoxSemester.Text;
            string date = dateTimePicker.Text;
            string group = comboBoxGroup.SelectedValue.ToString();
            string teacher = comboBoxTeacher.SelectedValue.ToString();
            string student = comboBoxStud.SelectedValue.ToString();
            string discipline = comboBoxDisc.SelectedValue.ToString();
            string formOfControl = comboBoxFC.SelectedValue.ToString();
            string mark = comboBoxMark.Text;


            if (ServerMananger.Add("[Журнал преподавателя]", new string[] { semester, date, group, teacher, student, discipline, formOfControl, mark }))
            {
                MessageBox.Show("Данные успешно добавлены", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Сбой во время операции!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
