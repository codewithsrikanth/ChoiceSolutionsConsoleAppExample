using System;

namespace CAInheritance
{
    class Category
    {
        int categoryId; string categoryName;
        public virtual void GetCategoryInfo()
        {
            Console.WriteLine("Enter Category Details: ");
            categoryId = Convert.ToInt32(Console.ReadLine());
            categoryName = Console.ReadLine();
        }
        public void F1()
        {
            Console.WriteLine("This is F1() function from parent class");
        }
        public virtual void F2()
        {
            Console.WriteLine("This is F2() function from parent class");
        }
    }
    class Product : Category
    {
        int categoryId; string categoryName; int prodId; string prodName;
        //Method Overriding : Providing a new implementation to the base class function, without changing the behaviour of parent class function.
        public override void GetCategoryInfo()
        {
            Console.WriteLine("Enter Category and Product Details: ");
            categoryId = Convert.ToInt32(Console.ReadLine());
            categoryName = Console.ReadLine();
            prodId = Convert.ToInt32(Console.ReadLine());
            prodName = Console.ReadLine();
        }
        //Method Hiding: If we provide a new implementation to the base class function with the help of "new" keyword is known as Method Hiding.
        public new void F1()
        {
            Console.WriteLine("This is F1() function from child class");
        }
    }
    class Example1
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.F1();
            p1.GetCategoryInfo();
            p1.F2();
            Console.Read();
        }
    }
}
