using StoreAppProject.Database;
using StoreAppProject.Models;
using StoreAppProject.Services;

StoreAppDatabase database = new StoreAppDatabase();

ProductService productService = new ProductService(database);


bool isRunning = true;
while (isRunning)
{
    Console.WriteLine("Welcome to the Store App!");
    Console.WriteLine("1. Add Product");
    Console.WriteLine("2. All Products");
    Console.WriteLine("3. Get Product by ID");
    Console.WriteLine("4. Remove Product");
    Console.WriteLine("5. Get Order By ID");
    Console.WriteLine("6. All Orders");
    Console.WriteLine("7. Remove Order");
    Console.WriteLine("8. Add Customer");
    Console.WriteLine("9. Get Customer By ID");
    Console.WriteLine("10. All Customers");
    Console.WriteLine("11. Exit");
    int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter Product Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Product Description:");
            string description = Console.ReadLine();
            Console.WriteLine("Enter Product Price:");
            double price = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Quantity:");
            int quantity = int.Parse(Console.ReadLine());
            productService.Add(new Product { Name = name, Price = price, Description = description });
            Console.WriteLine("Product added successfully.");
            break;
        case 2:
            List<Product> products = productService.GetAll();
            foreach (var item in products)
            {
                Console.WriteLine(item);
            }
            break;
        case 3:
            Console.WriteLine("Enter Product ID:");
            int id = int.Parse(Console.ReadLine());
            Product product = productService.GetById(id);
            if (product != null)
            {
                Console.WriteLine(product);
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
            break;
        case 4:
            Console.WriteLine("Enter Product ID to remove:");
            int removeId = int.Parse(Console.ReadLine());
            Product productToRemove = productService.GetById(removeId);
            if (productToRemove != null)
            {
                productService.Remove(productToRemove);
                Console.WriteLine("Product removed successfully\n");
            }
            else
            {
                Console.WriteLine("Product not found.");
            }
            break;
        case 5:
            Console.WriteLine("Enter Order ID:");
            int orderId = int.Parse(Console.ReadLine());
            Order order = database.Orders.FirstOrDefault(o => o.Id == orderId);
            if (order != null)
            {
                Console.WriteLine(order);
            }
            else
            {
                Console.WriteLine("Order not found.");
            }
            break;
        case 6:
            List<Order> orders = database.Orders;
            foreach (var item in orders)
            {
                Console.WriteLine(item);
            }
            break;
        case 7:
            Console.WriteLine("Enter Order ID to remove:");
            int removeOrderId = int.Parse(Console.ReadLine());
            Order orderToRemove = database.Orders.FirstOrDefault(o => o.Id == removeOrderId);
            if (orderToRemove != null)
            {
                database.Orders.Remove(orderToRemove);
                Console.WriteLine("Order removed successfully\n");
            }
            else
            {
                Console.WriteLine("Order not found.");
            }
            break;
        case 8:
            Console.WriteLine("Enter Customer Name:");
            string customerName = Console.ReadLine();
            Console.WriteLine("Enter Customer Surname:");
            string customerSurname = Console.ReadLine();
            Console.WriteLine("Enter Customer Gender:");
            string customerGender = Console.ReadLine();
            Customer customer = new Customer
            {
                Name = customerName,
                Surname = customerSurname
            };
            database.Customers.Add(customer);
            Console.WriteLine("Customer added successfully.");
            break;
        case 9:
            Console.WriteLine("Enter Customer ID:");
            int customerId = int.Parse(Console.ReadLine());
            Customer customerById = database.Customers.FirstOrDefault(c => c.Id == customerId);
            if (customerById != null)
            {
                Console.WriteLine(customerById);
            }
            else
            {
                Console.WriteLine("Customer not found.");
            }
            break;
        case 10:
            List<Customer> customers = database.Customers;
            foreach (var item in customers)
            {
                Console.WriteLine(item);
            }
            break;
        case 11:
            isRunning = false;
            Console.WriteLine("Exiting the application.");
            break;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}