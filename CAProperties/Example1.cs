using System;

namespace CAProperties
{
    class Product
    {
        int prodId; string prodName; double price;
        //Indexer
        public object this[int i]
        {
            set
            {
                if (i == 0)
                    prodId = Convert.ToInt32(value);
                if (i == 101)
                    prodName = Convert.ToString(value);
                if (i == 102)
                    price = Convert.ToDouble(value);
            }
            get
            {
                if (i == 0)
                    return prodId;
                if (i == 1)
                    return prodName;
                if (i == 2)
                    return price;
                return null;
            }
        }

        //Indexer
        public object this[string name]
        {
            set
            {
                if (name == "productName")
                    prodName = Convert.ToString(value);
            }
        }

    }
    internal class Example1
    {
        static void Main(string[] args)
        {
            Product obj = new Product();
            obj[0] = 101;
            obj["productName"] = "Mobile";
            obj[102] = 1234.56;
            Console.WriteLine($"Product ID is: {obj[0]}, Product Name is: {obj[1]} and Price is: {obj[2]}");


            Console.Read();

        }
    }
}
