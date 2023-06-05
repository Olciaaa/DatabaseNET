using AleksandraPoskrobekEFProducts;

public class Program
{
    private static void Main(string[] args)
    {   
        ProductContext productContext = new ProductContext();
        Supplier productSupplier = new Supplier { CompanyName = "Bubu", City = "Kraków", Street = "Kwiatowa", ZipCode = 876, bankAccountNumber = "898"};
        Supplier productSupplier2 = new Supplier { CompanyName = "Tralala", City = "Kraków", Street = "Kwiatowa", ZipCode = 56, bankAccountNumber = "355666898"};
        Customer customer = new Customer { CompanyName = "aha", City = "Kraków", Street = "Kwiatowaa", ZipCode = 876, Discount = true};
        Customer customer2 = new Customer { CompanyName = "Hmm", City = "Kraków", Street = "Kwiatowa", ZipCode = 455, Discount = false};
        Customer customer3 = new Customer { CompanyName = "Bum", City = "Kraków", Street = "Kwiatowa", ZipCode = 86576, Discount = false};

        productContext.Suppliers.Add(productSupplier);
        productContext.Suppliers.Add(productSupplier2);
        productContext.Customers.Add(customer);
        productContext.Customers.Add(customer2);
        productContext.Customers.Add(customer3);

        productContext.SaveChanges();

        var ps = productContext.Companies
        .OfType<Supplier>()
        .ToList();
        foreach (var supplier in ps)
        {
            Console.WriteLine($"{supplier.ID}, {supplier.CompanyName}, {supplier.bankAccountNumber}");
        }

        var cs = productContext.Companies
            .OfType<Customer>()
            .ToList();
        foreach (var customerr in cs)
        {
            Console.WriteLine($"{customerr.ID}, {customerr.CompanyName}, {customerr.Discount}");
        }
    }
}