using Dapper;
using MySql.Data.MySqlClient;
using System.Linq;

namespace GettingStartedLib
{
    public class Service : MyService
    {
        public int List(string name)
        {
            MySqlConnection db;

            // Connect to DB
            db = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString);
            db.Open();

            var result = db.Query("SELECT COUNT(*) FROM m_user WHERE name like '%" + name + "%'");

            db.Close();

            return result.First();
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
