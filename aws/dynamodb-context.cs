namespace Services
{
    public class DynamoDbService
    {
        public async Task<T> GetAsync<T>(string id)
        {
            try
            {
                DynamoDBContext context = new DynamoDBContext(_dynamoDbClient);
                return await context.LoadAsync<T>(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Amazon error in Get operation! Error: {ex}");
            }
        }

        public async Task WriteAsync<T>(T item)
        {
            try
            {
                DynamoDBContext context = new DynamoDBContext(_dynamoDbClient);
                await context.SaveAsync(item);
            }
            catch (Exception ex)
            {
                throw new Exception($"Amazon error in Write operation! Error: {ex}");
            }
        }

        public async Task DeleteAsync<T>(T item)
        {
            try
            {
                DynamoDBContext context = new DynamoDBContext(_dynamoDbClient);
                await context.DeleteAsync(item)
            }
            catch (Exception ex)
            {
                throw new Exception($"Amazon error in Delete operation! Error: {ex}");
            }
        }
    }
}

public interface IDynamoDbContext<T> : IDisposable where T : class
{
    Task<T> GetByIdAsync(string id);
    Task SaveAsync(T item);
    Task DeleteByIdAsync(T item);
}

public class DynamoDbContext<T> : DynamoDBContext, IDynamoDbContext<T>
    where T : class
{
    private DynamoDBOperationConfig _config;

    public DynamoDbContext(IAmazonDynamoDB client, string tableName)
        : base(client)
    {
        _config = new DynamoDBOperationConfig()
        {
            OverrideTableName = tableName
        };
    }

    public async Task<T> GetByIdAsync(string id)
    {
        return await base.LoadAsync<T>(id, _config);
    }

    public async Task SaveAsync(T item)
    {
        await base.SaveAsync(item, _config);
    }

    public async Task DeleteByIdAsync(T item)
    {
        await base.DeleteAsync(item, _config);
    }
}

// AWS Options
var awsOptions = Configuration.GetAWSOptions();
services.AddDefaultAWSOptions(awsOptions);

var client = awsOptions.CreateServiceClient<IAmazonDynamoDB>();
var dynamoDbOptions = new DynamoDbOptions();
ConfigurationBinder.Bind(Configuration.GetSection("DynamoDbTables"), dynamoDbOptions);

// This is where the magic happens
services.AddScoped<IDynamoDbContext<Player>>(provider => new DynamoDbContext<Player>(client, dynamoDbOptions.Player));
services.AddScoped<IDynamoDbContext<Location>>(provider => new DynamoDbContext<Location>(client, dynamoDbOptions.Location));