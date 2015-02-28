
using System;
namespace _04.CompanyHierarchy.Interfaces
{
    public interface ISale
    {
        string ProductName { get; set; }
        DateTime SaleDate { get; set; }
        decimal Price { get; set; }
    }
}
