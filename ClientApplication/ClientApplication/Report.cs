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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            LoadInfoGroup();
        }

        private void LoadInfoGroup()
        {
            DataSet dst = new DataSet();
            dst.ReadXml(new StringReader(ServerMananger.SelectColumn("Группы")));

            comboBoxGroup.DataSource = dst.Tables["g"];
            comboBoxGroup.ValueMember = dst.Tables["g"].Columns[0].ColumnName;
            comboBoxGroup.DisplayMember = dst.Tables["g"].Columns[2].ColumnName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataExport.ExportToExcel(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string semester = comboBoxSemester.Text;
            string group = comboBoxGroup.Text;

            DataSet dst = new DataSet();
            dst.ReadXml(new StringReader(ServerMananger.Execute("Report", new string[] { semester, group }, "Report")));

            if (dst.Tables.Count > 0)
            {
                dataGridView1.DataSource = dst.Tables[0];
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
            }
        }
    }
}
