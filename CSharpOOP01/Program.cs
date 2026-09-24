namespace CSharpOOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions
            #region Question01
            // a) What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?
            /*
             * Answer:
             * DeliveryAddress is a struct, and a struct is a value type.
             * When a DeliveryAddress variable is copied into another variable, the data is copied. Each variable gets its own independent copy.
             * Therefore, if the copy is modified, the original variable is not affected.
             */     
            DeliveryAddress address1 = new DeliveryAddress();
            address1.City = "Cairo";
            DeliveryAddress address2 = address1;
            address2.City = "Giza";
            Console.WriteLine(address1.City); // Output: Cairo
            Console.WriteLine(address2.City); // Output: Giza
            // Conclusion: Modifying the copied DeliveryAddress does not affect the original because structs are copied by value.

            // b) What happens when a Customer variable is copied into another variable and one variable modifies the object
            /*
             * Answer:
             * Customer is a class, and a class is a reference type.
             * When a Customer variable is copied into another variable, only the reference is copied, not the actual object.
             * Therefore, if one variable modifies the object, the other variable will see the same changes.
             */
            Customer customer1 = new Customer();
            customer1.Name = "Ahmed";
            Customer customer2 = customer1;
            customer2.Name = "Mohamed";
            Console.WriteLine(customer1.Name); // Output: Mohamed
            Console.WriteLine(customer2.Name); // Output: Mohamed
            // Conclusion: Modifying the copied Customer affects the original because classes are copied by reference.
            #endregion

            #endregion
        }
    }
}
