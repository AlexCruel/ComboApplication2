using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication
{
    public partial class Auth : Form
    {

        public Auth()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
           if(string.IsNullOrEmpty(textBox1.Text)|| string.IsNullOrEmpty(textBoxLogin.Text)|| string.IsNullOrEmpty(textBoxPassword.Text))
           {
                MessageBox.Show("Отсутствуют данные в текстовых полях!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string login = textBoxLogin.Text;
                string password = textBoxPassword.Text;
                string ip = textBox1.Text.Replace(',', '.');

                if(!ServerMananger.Connect(ip))
                    MessageBox.Show("Отсутствуют соединение с сервером", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    if(ServerMananger.Login(login,password))
                    {
                        new Main(this).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неверный логи или пароль!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
        }
    }
}
