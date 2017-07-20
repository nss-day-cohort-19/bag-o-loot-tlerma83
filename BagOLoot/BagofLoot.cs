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
        public List<(string, int)> ToyList {get; set;}= new List<(string, int)>();

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

        public List<int> AllChildrenWithAToy(int childId)
        {
            return new List<int>() {4, 5, 6, 7};
        }
    }
}