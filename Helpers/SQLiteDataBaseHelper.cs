using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MauiAppFit.Helpers
{
    internal class SQLiteDataBaseHelper
    {
        readonly SQLiteAsyncConnection _db;

        public SQLiteDataBaseHelper(string dbPath)
        {
            _db = new SQLiteAsyncConnection(dbPath);
            _db.CreateTableAsync<Atividade>().Wait();
        }
    }
}
