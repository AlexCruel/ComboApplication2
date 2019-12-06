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
    public partial class StudPerformGroup : Form
    {
        public StudPerformGroup()
        {
            InitializeComponent();
            UpdateData();
            LoadInfoGroup();
            LoadInfoDiscipline();
        }

        private void UpdateData()
        {
            DataSet dst = new DataSet();
            dst.ReadXml(new StringReader(ServerMananger.Select("Disc_GrPerformance")));

            if (dst.Tables.Count > 0)
            {
                dataGridView1.DataSource = dst.Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[3].Visible = false;
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
            string discipline = comboBoxDisc.SelectedValue.ToString();

            DataSet dst = new DataSet();
            dst.ReadXml(new StringReader(ServerMananger.Execute("[Disc_GrPerformance]", new string[] { semester, group, discipline }, "StudPerformGroup")));

            if (dst.Tables.Count > 0)
            {
                dataGridView2.DataSource = dst.Tables[0];
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].Visible = false;
                dataGridView2.Columns[2].Visible = false;
                dataGridView2.Columns[3].Visible = false;
                dataGridView2.Columns[4].Visible = false;
            }
        }
    }
}
