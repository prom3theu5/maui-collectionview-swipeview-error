namespace CollectionViewSwipeViewError.Services.DataSource;

public interface IDataSource
{
    Task<ReadOnlyCollection<LocalFile>> GetLocalFiles();
}