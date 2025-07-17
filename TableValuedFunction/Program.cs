
using Microsoft.EntityFrameworkCore;
using TableValuedFunction.Data;
using TableValuedFunction.Entities;

var order1BillDetails = new AppDbContext()
    .Set<OrderBill>()
    .FromSqlInterpolated($"SELECT * FROM GetOrderBill({1})")
    .ToList();

foreach (var item in order1BillDetails)
{
    Console.WriteLine(item);
}