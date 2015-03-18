using System;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace som.dao.test
{
    [TestFixture]
    public class SqliteTest
    {
        private static string AssemblyDirectory
        {
            get
            {
                return
                    Path.GetDirectoryName(
                        Uri.UnescapeDataString(
                            new UriBuilder(Assembly.GetExecutingAssembly().CodeBase).Path));
            }
        }

        [Test]
        public void ConnectionTest()
        {
            var databasePath = Path.Combine(AssemblyDirectory, @"REF\somdb.sqlite");

            var connectionString = string.Format("Data Source={0};Pooling=true;FailIfMissing=false;Version=3", databasePath);

            var sqliteConnection = new SQLiteConnection(connectionString);
            sqliteConnection.Open();
            var query = sqliteConnection.CreateCommand();
            query.CommandText = "select * from atex";
            var reader = query.ExecuteReader();

            while (reader.Read())
            {
                var values = reader.GetValues();
                var line = values.AllKeys.Aggregate("", (current, key) => current + (values[key] + ";"));
                Console.WriteLine(line);

            }
        }


    }
}
