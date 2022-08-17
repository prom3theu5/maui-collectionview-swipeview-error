namespace CollectionViewSwipeViewError.Services.DataSource;

public class DebugData : IDataSource
{
    public Task<ReadOnlyCollection<LocalFile>> GetLocalFiles()
    {
        var filesNames = new[] { "Test File One", "Test File Two" };

        return Task.FromResult(filesNames.Select(file => new LocalFile() { FileName = file, }).ToList().AsReadOnly());
    }
}