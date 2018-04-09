using Dapper;
using GettingStartedLib.Class;
using MySql.Data.MySqlClient;
using System.Data;
using System.Linq;

namespace GettingStartedLib
{
    public class Service : MyService
    {
        public user List(string email)
        {
            /*
            // MySQLを接続する
            string myConnectionString = "server=192.168.1.60;Port=3306;database=magellan;uid=root;pwd=root;";
            MySqlConnection cnn;
            cnn = new MySqlConnection(myConnectionString);
            cnn.Open();
            Console.WriteLine("データベース接続が成功しました");

            MySqlCommand cmd = new MySqlCommand("select * from user;", cnn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(3));
            }
            cnn.Close();
            */

            /*
            MySqlConnection db;

            // Connect to DB
            //db = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
            db = new MySqlConnection("server=192.168.1.60;Port=3306;database=magellan;uid=root;pwd=root;");
            db.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM user", db);
            MySqlDataReader reader = cmd.ExecuteReader();

            string result = "";
            while(reader.Read())
            {
                result = reader.GetString(3);
            }

            db.Close();
            */

            IDbConnection db = new MySqlConnection("server=192.168.1.60;Port=3306;database=magellan;uid=root;pwd=root;");

            return db.Query<user>("Select * From user " +
                "WHERE email = @email", new { email }).SingleOrDefault();
        }

        public bool Add(string name, string password)
        {
            //var result = db.Query<m_user>("");
            
            //Console.WriteLine("Received Add({0},{1})", n1, n2);
            //Console.WriteLine("Return: {0}", result);
            return true;
        }

        public bool Update(string name, string password)
        {
            //Console.WriteLine("Received Multiply({0},{1})", n1, n2);
            //Console.WriteLine("Return: {0}", result);
            return true;
        }

        public bool Delete(int id)
        {
            //Console.WriteLine("Received Divide({0},{1})", n1, n2);
            //Console.WriteLine("Return: {0}", result);
            return true;
        }
    }
}
