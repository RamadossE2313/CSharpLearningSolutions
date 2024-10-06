namespace CSharpLearning.SolidPrinciples.OpenClosedPrinciple
{
    public class OpenClosedPrinciple
    {
        private readonly List<Product> _products;
        private readonly INotificationService _notificationService;

        public OpenClosedPrinciple(INotificationService notificationService)
        {
            _products = new List<Product>();
        }

        public void AddProduct(Product product) => _products.Add(product);
        public void RemoveProduct(Product product) => _products.Remove(product);
        public Product GetProduct(int Id) => _products[Id];
        public void UpdateProduct(Product product, int Id)
        {
            _products[Id] = product;
            _notificationService.SendNotification(product);
        }
    }

    public interface INotificationService
    {
        void SendNotification(Product product);
    }

    public class EmailNotificationService : INotificationService
    {
        public void SendNotification(Product product)
            => Console.WriteLine($"Email Notification for product: {product.Name}");
    }

    public class SMSNotificationService : INotificationService
    {
        public void SendNotification(Product product)
            => Console.WriteLine($"SMS Notification for product: {product.Name}");
    }
}
