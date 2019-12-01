using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace Server
{
    class Program
    {
        private static TcpListener listener;
        private const int PORT = 4000;
        private static IPAddress IP = IPAddress.Any;
        public const string CONNECTION_STRING = @"Data Source=DESKTOP-DUJH35B\SQLEXPRESS;Initial Catalog=Kursovaya;Integrated Security=True";

        static void Main(string[] args)
        {
            Console.WriteLine("Подключение к БД ....");

            try
            {
                SqlConnection connection = new SqlConnection(CONNECTION_STRING);
                connection.Open();
                connection.Close();
                Console.WriteLine("Соединение с БД установлено");
            }
            catch
            {
                Console.WriteLine("Не удалось установить соединение с БД");
            }

            listener = new TcpListener(IP, PORT);
            listener.Start();

            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                ClientObject clientObject = new ClientObject(client);
            }
        }
    }
}
