using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace BagOLoot
{
    public class ChildRegister
    {
        private List<(string, int)> _children = new List<(string, int)>();
        private string _connectionString = $"Data Source={Environment.GetEnvironmentVariable("BAGOLOOT_DB")}";
        private SqliteConnection _connection;

        public ChildRegister()
        {
            _connection = new SqliteConnection(_connectionString);
        }

        public bool AddChild (string child) 
        {
            int _lastId = 0; // Will store the id of the last inserted record
            using (_connection)
            {
                _connection.Open ();
                SqliteCommand dbcmd = _connection.CreateCommand ();

                // Insert the new child
                dbcmd.CommandText = $"insert into child values (null, '{child}', 0)";
                Console.WriteLine(dbcmd.CommandText);
                dbcmd.ExecuteNonQuery ();

                // Get the id of the new row
                dbcmd.CommandText = $"select last_insert_rowid()";
                using (SqliteDataReader dr = dbcmd.ExecuteReader()) 
                {
                    if (dr.Read()) {
                        _lastId = dr.GetInt32(0);
                    } else {
                        throw new Exception("Unable to insert value");
                    }
                }

                // clean up
                dbcmd.Dispose ();
                _connection.Close ();
            }

            return _lastId != 0;
        }

        public List<(string, int)> GetChildren ()
        {
            using (_connection)
            {
                _connection.Open ();
                SqliteCommand dbcmd = _connection.CreateCommand ();

                //select the id and name of every child
                dbcmd.CommandText = "select id, name from child";

                using (SqliteDataReader dr = dbcmd.ExecuteReader())
                {
                    //Read each row in the result set
                    while (dr.Read())
                    {
                        _children.Add((dr[1].ToString(), dr.GetInt32(0))); //Add child name to list
                    }
                }

                //clean up
                dbcmd.Dispose ();
                _connection.Close ();
            }

            return _children;
            // return new List<string>();
        }

        public Object GetChild (int childId)
        {
            var child = _children.SingleOrDefault(c => c.Item2 == childId);

            // Inevitably, two children will have the same name. Then what?

            return child;
        }
    }
}