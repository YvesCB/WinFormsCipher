using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsCipher
{
    public class CipherController
    {
        public void InitializeDatabase()
        {
            using (var context = new CipherContext())
            {
                // Initialize the database. This includes creating it if it doesn't exist
                if (!context.Database.CanConnect())
                {
                    context.Database.EnsureCreated();
                    Console.WriteLine("Database created");
                }
                else
                {
                    Console.WriteLine("Database already exists");
                }
            }
        }

        public List<CipherEntry> GetAllEntries()
        {
            using (var context = new CipherContext())
            {
                return context.CipherEntries.ToList();
            }
        }

        public CipherEntry GetEntry(int id) {
            using (var context = new CipherContext())
            {
                // This can return null
                return context.CipherEntries.SingleOrDefault(entry => entry.Id == id);
            }
        }

        public void InsertEntry(DateTime timestamp, string plainText, string cipherText, string key)
        {
            using (var context = new CipherContext())
            {
                var newEntry = new CipherEntry
                {
                    Timestamp = timestamp,
                    PlainText = plainText,
                    CipherText = cipherText,
                    Key = key
                };
                context.CipherEntries.Add(newEntry);
                context.SaveChanges();
            }
        }

        public void DeleteEntryById(int id)
        {
            using (var context = new CipherContext())
            {
                var entry = context.CipherEntries.SingleOrDefault(e => e.Id == id);
                if (entry != null)
                {
                    context.CipherEntries.Remove(entry);
                    context.SaveChanges();
                }
            }
        }
    }
}
