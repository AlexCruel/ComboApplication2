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
    public partial class AddSpecialty : Form
    {

        public AddSpecialty()
        {
            InitializeComponent();
            LoadInfoFaculty();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string faculty = comboBox1.SelectedValue.ToString();
            string name = textBox2.Text;
            string shotrName = textBox3.Text;

            if (ServerMananger.Add("Специальности", new string[] { faculty, name, shotrName }))
            {
                MessageBox.Show("Данные успешно добавлены", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Сбой во время операции!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInfoFaculty()
        {
            DataSet dst = new DataSet();
            dst.ReadXml(new StringReader(ServerMananger.SelectColumn("Факультеты")));

            comboBox1.DataSource = dst.Tables["f"];
            comboBox1.ValueMember = dst.Tables["f"].Columns[0].ColumnName;
            comboBox1.DisplayMember = dst.Tables["f"].Columns[1].ColumnName;
        }
    }
}
