namespace BooksApi.Models
{
    public class BookstoreDatabaseSettings : IBookstoreDatabaseSettings
    {
        public string BooksCollectionName { get; set; }

        private string connectionString;

        public BookstoreDatabaseSettings(string booksCollectionName, string connectionString, string databaseName, string booksCollectionName, string connectionString, string databaseName)
        {
            this.BooksCollectionName = booksCollectionName;
            ConnectionString = connectionString;
            this.DatabaseName = databaseName;
            this.BooksCollectionName = booksCollectionName;
            ConnectionString = connectionString;
            this.DatabaseName = databaseName;
        }

        public string GetConnectionString1()
        {
            return connectionString;
        }

        public void SetConnectionString1(string value)
        {
            connectionString = value;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public string DatabaseName { get; set; }
    }

    public interface IBookstoreDatabaseSettings:IBookstoreDatabaseSettings
    {
        string BooksCollectionName { get; set; }

        string GetConnectionString1();
        void SetConnectionString1(string value);

        string DatabaseName { get; set; }
    }
}