using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace szemelyzetGUI
{
    internal class Database
    {
        const string server = "SERVER=localhost;DATABASE=szemelyzet;UID=root;PASSWORD=;";
        MySqlConnection con;
        MySqlCommand cmd;
        MySqlDataReader dr;

        public MySqlDataReader Dr { get => dr; set => dr = value; }

        public Database(string querry) 
        {
            con = new MySqlConnection(server);
            cmd = new MySqlCommand(querry, con);
            con.Open();
            dr = cmd.ExecuteReader();
        }
        public void Close() 
        {
            con.Close();
        }
        ~Database() 
        {
            con.Close();
        }
    }
}
