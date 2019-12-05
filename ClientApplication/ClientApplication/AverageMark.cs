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
    public partial class AverageMark : Form
    {
        public AverageMark()
        {
            InitializeComponent();
            LoadInfoStudent();
            LoadInfoDiscipline();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string student = comboBoxStud.SelectedValue.ToString();
            string discipline = comboBoxDisc.SelectedValue.ToString();

            DataSet dst = new DataSet();
            dst.ReadXml(new StringReader(ServerMananger.Calculate("AvScoreJournal", new string[] { student, discipline })));

            foreach (DataTable dt in dst.Tables)
            {
                foreach (DataRow row in dt.Rows)
                {
                    richTextBox1.Text = row[0].ToString();
                }
            }
        }
    }
}
