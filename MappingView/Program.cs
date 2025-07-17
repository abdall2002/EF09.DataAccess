
using MappingView.Data;

var context = new AppDbContext();

foreach (var item in context.OrderWithDetails)
{
    Console.WriteLine(item);
}