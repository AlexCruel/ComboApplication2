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
        }

        private void UpdateData()
        {
            DataSet dst = new DataSet();
            dst.ReadXml(new StringReader(ServerMananger.Select("Exam")));

            if (dst.Tables.Count > 0)
            {
                dataGridView1.DataSource = dst.Tables[0];
                //dataGridView1.Columns[0].Visible = false;
            }
        }
    }
}
