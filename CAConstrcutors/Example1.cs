using System;

namespace CAConstrcutors
{
    class StoreInformation
    {
        public string storelocation; public double pincode; public string state;
        public StoreInformation(string storelocation, double pincode, string state)
        {
            this.storelocation = storelocation;
            this.pincode = pincode;
            this.state = state;
        }
    }
    class Product
    {
        int productId; string productName; double price; int qty;
        string storelocation; double pincode; string state;
        private Product(string productName, double price)
        {
            this.productName = productName;
            this.price = price;
        }
        
        public Product(int id, int qty, StoreInformation info)
        {
            productId = id;           
            this.qty = qty;
            storelocation = info.storelocation;
            this.pincode = info.pincode;
            this.state = info.state;
            Product p1 = new Product("Mobile", 12345);
            p1.ProductInfo();
            Product p2 = new Product("Laptop", 83838);
            p2.ProductInfo();
        }
        public void Display()
        {            
            Console.WriteLine($"{productId} - {qty} - {storelocation} - {state}");
        }
        public void ProductInfo()
        {
            Console.WriteLine($"{productName} - {price}");
        }
    }

    class Example1
    {
        static void Main(string[] args)
        {
            StoreInformation info = new StoreInformation("Vijayawada", 522549, "AP");


            Product p1 = new Product(101, 4, info);
            //Product p2 = new Product(102, 3, info);
            //Product p3 = new Product(103, 2, info);

            //Product p4 = new Product("Dell Laptop", 12000);
            //Product p5 = new Product("Lenovo Laptop", 5);

            p1.Display();
            //p2.Display();
            //p3.Display();

            Console.Read();
        }
    }
}
