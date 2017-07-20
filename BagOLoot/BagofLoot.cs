using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.Sqlite;

namespace BagOLoot
{
    public class BagofLoot
    {

        private string _connectionString = $"Data Source={Environment.GetEnvironmentVariable("BAGOLOOT_DB")}";
        private SqliteConnection _toyConnection;
        private List<(string, int)> ToyList {get; set;}= new List<(string, int)>();
        private List<Toy> _KidsWithToys = new List<Toy>();

        public BagofLoot () {
            _toyConnection = new SqliteConnection(_connectionString);
        }


        public bool AddToyToBag(string toy, int childId)
        {
            ToyList.Add((toy, childId));
            
            int _lastId = 0; // Will store the id of the last inserted record
            using (_toyConnection)
            {
                _toyConnection.Open ();
                SqliteCommand dbcmd = _toyConnection.CreateCommand ();

                // Insert the new child
                dbcmd.CommandText = $"insert into toy values (null, '{toy}', '{childId}')";
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
                _toyConnection.Close ();
            }

            return _lastId != 0 && true;

        }

        public List<Toy> GetToyListPerChild(int childId)
        {
            // Toy toyName = new Toy(nameof, butt, buttbutt);

            return new List<Toy>();
        }

        public List<Toy> AllChildrenWithAToy(int childId)
        {

            using (_toyConnection)
            {
                _toyConnection.Open ();
                SqliteCommand dbcmd = _toyConnection.CreateCommand ();

                //select the id and name of every child
                dbcmd.CommandText = "select id, toy, childID from toy";

                using (SqliteDataReader dr = dbcmd.ExecuteReader())
                {
                    //Read each row in the result set
                    while (dr.Read())
                    {
                        // Child newChild = new Child(dr[1].ToString(), dr.GetInt32(0), dr.GetBoolean(2));
                        _KidsWithToys.Add(new Toy(dr[1].ToString(), dr.GetInt32(0), dr.GetInt32(2))); //Add child name to list
                    }
                }
                //clean up
                dbcmd.Dispose ();
                _toyConnection.Close ();
            }

            return _KidsWithToys;
            // return new List<int>() {4, 5, 6, 7};
        }
    }
}