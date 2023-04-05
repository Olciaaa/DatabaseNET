using AleksandraPoskrobekEFProducts;

public class Program
{
    private static void Main(string[] args)
    {
            ProductContext productContext = new ProductContext();
            Product product = new Product { ProductName = "Flamaster" };
            productContext.Products.Add(product);
            productContext.SaveChanges();
    }
}