namespace CSharpLearning.SolidPrinciples.OpenClosedPrinciple
{
    public class OpenClosedPrincipleViolation
    {
        private readonly List<Product> _products;
        private readonly NotificationService _notificationService;

        public OpenClosedPrincipleViolation()
        {
            _products = new List<Product>();
            _notificationService = new NotificationService();
        }

        public void AddProduct(Product product) => _products.Add(product);
        public void RemoveProduct(Product product) => _products.Remove(product);
        public Product GetProduct(int Id) => _products[Id];
        public void UpdateProduct(Product product, int Id)
        {
            _products[Id] = product;
            _notificationService.SendNotification(product, "Email");
        }
    }

    // If new notification type comes means, you have to modify the NotificationService class, which is violating the OCP
    // it's violates the SRP, now the class is responsible for multiple notification types

    public class NotificationService
    {
        public void SendNotification(Product product, string notificationType)
        {
            if (notificationType == "Email")
            {
                Console.WriteLine($"Email Notification for product: {product.Name}");
            }
            else if (notificationType == "SMS")
            {
                Console.WriteLine($"SMS Notification for product: {product.Name}");
            }
            else
            {
                Console.WriteLine($"Default Notification for product: {product.Name}");
            }
        }
    }

}
