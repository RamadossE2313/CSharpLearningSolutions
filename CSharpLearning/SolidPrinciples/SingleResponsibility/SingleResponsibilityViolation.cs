namespace CSharpLearning.SolidPrinciples.SingleResponsibility
{
    // Multiple Responsibilities: The class is handling two distinct responsibilities:
    // Managing a collection of Product instances.
    //Sending notifications about a Product.
    public class SingleResponsibilityViolation
    {
        private readonly List<Product> _products;

        public SingleResponsibilityViolation()
        {
            _products = new List<Product>();
        }
        public void AddProduct(Product product) => _products.Add(product);
        public void RemoveProduct(Product product) => _products.Remove(product);
        public Product GetProduct(int Id) => _products[Id];
        public void UpdateProduct(Product product, int Id) => _products[Id] = product;
        
        // it's not responsibility of this class at all
        public void SendNotification(Product product) => Console.WriteLine("Yet to implement it");
    }
}
