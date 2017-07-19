// public List<string> GetChildren ()
// {
//     using (_connection)
//     {
//         _connection.Open ();
//         SqliteCommand dbcmd = _connection.CreateCommand ();

//         //select the id and name of every child
//         dbcmd.CommandText = "select id, name from child";

//         using (SqliteDataReader dr = dbcmd.ExecuteReader())
//         {
//             //Read each row in the result set
//             while (dr.Read())
//             {
//                 _children.Add(dr[1}.ToString()); //Add child name to list
//             }
//         }

//         //clean up
//         dbcmd.Dispose ();
//         _connection.Close ();
//     }

//     return _children;
// }