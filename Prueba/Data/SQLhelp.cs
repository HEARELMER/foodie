using Prueba.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Prueba.Data
{
    class SQLhelp
    {
        SQLiteAsyncConnection db;

        public SQLhelp(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Item>().Wait();
        }
        public Task<int> SaveMarcaAsync(Item item)
        {
            if (string.IsNullOrEmpty(item.Id))
            {
                return db.InsertAsync(item);
            }
            else
            {
                return null;
            }
        }
        public Task<List<Item>> GetItemAsync()
        {
            return db.Table<Item>().ToListAsync();
        }
        public Task<Item> GetMarcaByIdAsync(string id)
        {
            return db.Table<Item>().FirstOrDefaultAsync(item => item.Id == id);
        }
    }
}
