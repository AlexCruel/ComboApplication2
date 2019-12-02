using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApplication
{
    class ServerMananger
    {
        enum OPERATIONS
        {
            LOGIN=0,
            SELECT,
            ADD,
            SELECTCOLUMN,
            UPDATE,
            EXEC
        }

        private static TcpClient tcpClient;
        private const int PORT = 4000;
        private static BinaryReader reader;
        private static BinaryWriter writer;

        public static bool Connect(string ip)
        {
            bool result = false;
            try
            {
                tcpClient = new TcpClient();
                tcpClient.Connect(ip, PORT);
                reader = new BinaryReader(tcpClient.GetStream());
                writer = new BinaryWriter(tcpClient.GetStream());
                result = true;
            }
            catch
            {
                result = false;
            }

            return result;
        }

        public static bool Login(string login,string password)
        {
            writer.Write((int)OPERATIONS.LOGIN);
            writer.Write(login);
            writer.Write(password);

            return reader.ReadBoolean();
        }

        public static string Select(string tablename)
        {
            writer.Write((int)OPERATIONS.SELECT);
            writer.Write(tablename);

            return reader.ReadString();
        }

        public static string SelectColumn(string tablename)
        {
            writer.Write((int)OPERATIONS.SELECTCOLUMN);
            writer.Write(tablename);

            return reader.ReadString();
        }

        public static bool Add(string tablename, string[] args)
        {
            writer.Write((int)OPERATIONS.ADD);
            writer.Write(tablename);
            writer.Write(args.Length);
            
            foreach (string item in args)
            {
                writer.Write(item);
            }


            return reader.ReadBoolean();
        }
    }
}
