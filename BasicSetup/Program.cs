
using BasicSetup.Data;

var context = new AppDbContext();
foreach (var product in context.Products)
{
    Console.WriteLine(product.Name);
}