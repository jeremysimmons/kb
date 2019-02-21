https://ahmet.im/blog/azure-listblobssegmentedasync-listcontainerssegmentedasync-how-to/

public Task<List<IListBlobItem> ListBlobsAsync(BlobContinuationToken currentToken){
    BlobContinuationToken continuationToken = null;
    List<IListBlobItem> results = new List<IListBlobItem>();
    do
    {
        var response = await ListBlobsSegmentedAsync(continuationToken);
        continuationToken = response.ContinuationToken;
        results.AddRange(response.Results);
    }
    while (continuationToken != null);
    return results;
}

public async Task<List<CloudBlobContainer>> ListContainersAsync()
{
    BlobContinuationToken continuationToken = null;
    List<CloudBlobContainer> results = new List<CloudBlobContainer>();
    do
    {
        var response = await ListContainersSegmentedAsync(continuationToken);
        continuationToken = response.ContinuationToken;
        results.AddRange(response.Results);
    }
    while (continuationToken != null);
    return results;
}