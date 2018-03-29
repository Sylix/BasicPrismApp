using BasicPrismApp.Helpers;
using SQLite;

namespace BasicPrismApp.Repositories
{
    public class BasicRepository
    {
        private readonly SQLiteAsyncConnection conn;
        public BasicRepository(IFileAccessHelper fileAccessHelper)
        {
            var dbPath = fileAccessHelper.GetLocalFilePath("data.db3");
            conn = new SQLiteAsyncConnection(fileAccessHelper.GetLocalFilePath("data.db3"));
        }
    }
}