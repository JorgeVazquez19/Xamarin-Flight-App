using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinFlightApp.Droid.Clases.Interfaces;

namespace XamarinFlightApp.Droid.Clases.Local
{
    public class FlightsDatabase : IFlightsDao
    {

        /*private readonly SQLiteAsyncConnection database;

        public CommentDatabase(string pathToDb)
        {
            database = new SQLiteAsyncConnection(pathToDb);
            database.CreateTableAsync<Comment>().Wait();
        }

        public Task<List<Comment>> GetFavorites()
        {
            return database.Table<Comment>().ToListAsync();
        }

        public Task<int> AddToFavorites(Comment comment)
        {
            return database.InsertOrReplaceAsync(comment);
        }

        public Task<int> DeleteFromFavorites(Comment comment)
        {
            return database.DeleteAsync(comment);
        }*/
    }
}