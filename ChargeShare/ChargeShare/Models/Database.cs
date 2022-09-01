using ChargeShare.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WeekMCCapp.Models
{
	public class Database
	{
		private readonly SQLiteAsyncConnection _database;

		public Database(string dbPath)
		{
			_database = new SQLiteAsyncConnection(dbPath);

		}

		public Task<User> GetUserFromDatabase()
		{
			return _database.Table<User>().FirstAsync();
		}

		public Task<int> SaveUserToDatabase(User user)
		{
			return _database.InsertAsync(user);
		}

		public async Task<User> GetUserByEmail(string EmailString)
		{
			var query = from s in _database.Table<User>()
						where s.Email == EmailString
						select s;

			return query.;
		}

	}
}
