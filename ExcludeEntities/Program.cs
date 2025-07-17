using ExcludeEntities.Data;

var context = new AppDbContext();
foreach (var product in context.Products)
{
    Console.WriteLine($"{product.Name} \t\n...... loaded at " +
        $"{product.Snapshot.LoadedAt.ToString("yyyy-MM-dd hh:mm")}" +
        $"\nVersion: {product.Snapshot.Version}");
}