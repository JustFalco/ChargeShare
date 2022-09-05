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
			_database.CreateTableAsync<User>();
			_database.CreateTableAsync<ChargeStation>();
		}

		public Task<int> SaveUserToDatabase(User user)
		{
			return _database.InsertAsync(user);
		}

		public Task<int> SaveChargeStationToDatabase(ChargeStation chargeStation)
		{
			return _database.InsertAsync(chargeStation);
		}

		public Task<List<ChargeStation>> GetAllChargeStations()
		{
			return _database.Table<ChargeStation>().ToListAsync();
		}

		public async Task<User> GetUserByEmail(string EmailString)
		{
			Console.WriteLine("In query ");
			var user = await _database.Table<User>().Where(a => a.Email == EmailString).FirstOrDefaultAsync();
			Console.WriteLine("executed query ");
			return user;
		}

	}
}
