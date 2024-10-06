namespace CSharpLearning.SolidPrinciples.SingleResponsibility
{
    public class SingleResponsibility
    {
        private readonly List<Product> _products;

        public SingleResponsibility()
        {
            _products = new List<Product>();
        }
        public void AddProduct(Product product) => _products.Add(product);
        public void RemoveProduct(Product product) => _products.Remove(product);
        public Product GetProduct(int Id) => _products[Id];
        public void UpdateProduct(Product product, int Id) => _products[Id] = product;
    }

    public class NotificationService
    {
        public void SendNotification(Product product) => Console.WriteLine($"Notification for product: {product.Name}");
    }
}
