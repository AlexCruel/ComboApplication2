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
    public partial class Exam : Form
    {
        public Exam()
        {
            InitializeComponent();
            UpdateData();
            LoadInfoGroup();
            LoadInfoStudent();
            LoadInfoDiscipline();
        }

        private void UpdateData()
        {
            DataSet dst = new DataSet();
            dst.ReadXml(new StringReader(ServerMananger.Select("Exam")));

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

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            string semester = comboBoxSemester.Text;
            string group = comboBoxGroup.SelectedValue.ToString();
            string student = comboBoxStud.SelectedValue.ToString();
            string discipline = comboBoxDisc.SelectedValue.ToString();
            string mark = comboBoxMark.Text;


            if (ServerMananger.Add("Экзамен", new string[] { semester, group, student, discipline, mark }))
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
