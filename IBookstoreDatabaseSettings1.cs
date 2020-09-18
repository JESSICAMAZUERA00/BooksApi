namespace BooksApi.Models
{
    public interface IBookstoreDatabaseSettings1
    {
        string BooksCollectionName { get; set; }
        string BooksCollectionName { get; set; }
        string DatabaseName { get; set; }
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }

        string GetConnectionString1();
        void SetConnectionString1(string value);
    }
}