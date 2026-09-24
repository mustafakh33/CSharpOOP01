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
            //DeliveryAddress address1 = new DeliveryAddress();
            //address1.City = "Cairo";
            //DeliveryAddress address2 = address1;
            //address2.City = "Giza";
            //Console.WriteLine(address1.City); // Output: Cairo
            //Console.WriteLine(address2.City); // Output: Giza
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

            #region Question02
            // a) Identify at least three problems with this design from an encapsulation perspective.
            /*
              * Answer:
              * Problem 1: The fields are public, which allows external code to modify them directly, violating encapsulation principles.
              * Problem 2: There is no validation logic to ensure that the data being set is valid (e.g., negative weight or delivery fee).
              * Problem 3: The struct does not provide any methods or properties to control access to its internal state, making it less maintainable and harder to extend in the future.
             */
            // b) How can private fields and public properties improve this design? 
            /*
             * Answer:
             * By using private fields and public properties, we can control access to the internal state of the struct.
             * Properties can include validation logic to ensure that only valid data is set, improving data integrity.
             * This approach also allows for read-only properties or computed properties, enhancing encapsulation and maintainability.
             */
            #endregion
            #endregion

            #region Part 02 : Practical
            #region Part02Question01
            //DeliveryAddress address1 = new DeliveryAddress("Cairo", "Tahrir Street", 10);
            //DeliveryAddress address2 = address1;
            //address2.City = "Giza"; address2.Street = "Pyramids Street"; address2.BuildingNumber = 25;
            //Console.WriteLine(address1.GetFullAddress()); // Output: Cairo, Tahrir Street, 10
            //Console.WriteLine(address2.GetFullAddress()); // Output: Giza, Pyramids Street, 25
            #endregion

            #region Part02Question02
            //Shipment shipment1 = new Shipment("TR-001");
            //DeliveryAddress address = new DeliveryAddress("Cairo", "Tahrir Street", 10);
            //Shipment shipment2 = new Shipment("TR-002", "Electronics", 10, 100, address);
            //shipment1.PrintShipment();
            //Console.WriteLine();
            //shipment2.PrintShipment();
            //shipment2.UpdateDeliveryFee(150);
            //shipment2.PrintShipment();
            #endregion

            #region Part02Question03
            DeliveryCenter center = new DeliveryCenter();
            DeliveryAddress address = new DeliveryAddress("Cairo","Tahrir Street",10 );
            Shipment shipment1 = new Shipment("TR-001", "Laptop",10,100,address);
            Shipment shipment2 = new Shipment("TR-002","Phone",5,50,address);

            Console.WriteLine(center.AddShipment(shipment1)); // True
            Console.WriteLine(center.AddShipment(shipment2)); // True
            #endregion
     
            #endregion
        }
    }
}
