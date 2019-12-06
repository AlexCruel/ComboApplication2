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
    public partial class StudPerform : Form
    {
        public StudPerform()
        {
            InitializeComponent();
            UpdateData();
            LoadInfoStudent();
        }

        private void UpdateData()
        {
            DataSet dst = new DataSet();
            dst.ReadXml(new StringReader(ServerMananger.Select("[St_AcPerformance]")));

            if (dst.Tables.Count > 0)
            {
                dataGridView1.DataSource = dst.Tables[0];
                dataGridView1.Columns[0].Visible = false;
            }
        }

        private void LoadInfoStudent()
        {
            DataSet dst = new DataSet();
            dst.ReadXml(new StringReader(ServerMananger.SelectColumn("Студенты")));

            comboBoxStud.DataSource = dst.Tables["st"];
            comboBoxStud.ValueMember = dst.Tables["st"].Columns[0].ColumnName;
            comboBoxStud.DisplayMember = dst.Tables["st"].Columns[1].ColumnName;
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            string semester = comboBoxSemester.Text;
            string student = comboBoxStud.SelectedValue.ToString();

            DataSet dst = new DataSet();
            dst.ReadXml(new StringReader(ServerMananger.Execute("[St_AcPerformance]", new string[] { semester, student }, "StudPerform")));

            if (dst.Tables.Count > 0)
            {
                dataGridView2.DataSource = dst.Tables[0];
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[1].Visible = false;
                dataGridView2.Columns[3].Visible = false;
            }
        }
    }
}
