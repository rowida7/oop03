using oop02;
using System.Drawing;
using System.Xml.Linq;

namespace oop03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Theoretical Questions
            //Q1  Overloading, Overriding, and Binding
            //a)  What is the difference between Method Overloading and Method Overriding?
            // Method Overloading having many methods with the same name and different parameter (order, count, dataType)
            // Method Overriding a virtual method that overrided in the inherited class to have different behaviour


            //b)  What is the difference between Static Binding and Dynamic Binding?
            // Static Binding is deciding the method to call in Compile Time
            // Dynamic Binding is deciding the method to call in RunTime

            //Q2 Sealed Classes and Methods
            //a)  What is the purpose of the sealed keyword when applied to a class?
            // that class can't be inherited

            //b)  What is the difference between a sealed class and a sealed method?
            // sealed class can't be inherited 
            // sealed method can't be overrided

            //c)  Can a sealed method be overridden? Why?
            // No, because it's stoping the overriding chain
            #endregion


            #region Main() Checklist
            // a.Create a Driver.
            Driver driver = new Driver("Ahmed Mohamed");
            // b.Create a DeliveryCenter.
            DeliveryCenter deliveryCenter = new DeliveryCenter();
            // c.Assign the Driver to the DeliveryCenter.
            deliveryCenter.Driver = driver;

            deliveryCenter.PrintInfo();

            DeliveryAddress deliveryAddress = new DeliveryAddress("Cairo", "Salah Salem", 45);
            // d.Create one StandardShipment.
            StandardShipment standard = new StandardShipment("001","Fragile",200.0,100.0, deliveryAddress);
            // e.Create one ExpressShipment.
            ExpressShipment express = new ExpressShipment("002", "Books", 550.0, 250.0, deliveryAddress, 100.0);
            // f.Create one InternationalShipment.
            InternationalShipment international = new InternationalShipment("003", "Electronics", 350.0, 500.0, deliveryAddress, "Egypt", 3000.0);

            // g.Add all shipments to the DeliveryCenter.
            deliveryCenter.AddShipment(standard);
            deliveryCenter.AddShipment(express);
            deliveryCenter.AddShipment(international);


            // h.Print all shipments using PrintAllShipments().
            
            
            Console.WriteLine("------------Shipments------------");
            deliveryCenter.PrintAllShipments();

            // i.Call DeliveryHelper.PrintShipmentDetails() for each shipment.
            Console.WriteLine("Printing Using DeliveryHelper...");
            DeliveryHelper.PrintShipmentDetails(standard);
            DeliveryHelper.PrintShipmentDetails(express);
            DeliveryHelper.PrintShipmentDetails(international);
            Console.WriteLine("===================================");
            

            // j.Demonstrate both versions of UpdateWeight().
            Shipment shipment = new Shipment("004", "Clothes", 3, 200.0, deliveryAddress);
            Console.WriteLine("Updating Weight..."); 
            Console.WriteLine($"Original Weight :{shipment.Weight}");
            shipment.UpdateWeight(5);
            Console.WriteLine($"Updated Weight :{shipment.Weight}");
            shipment.UpdateWeight(5, 0.5);
            Console.WriteLine($"Updated Weight After Packing :{shipment.Weight}");

            // k.Build a Shipment[] holding mixed types and print all of them in a loop.
            Console.WriteLine("Printing Using Shipment[]...");
            Shipment[] shipments = { standard, express, international };
            foreach (Shipment ship in shipments)
            {
                ship.PrintShipment();
            }

            Console.WriteLine("============================");

            // l.Demonstrate the sealed class and sealed method(comments or code).

            PriorityInternationalShipment priority = new PriorityInternationalShipment();
            priority.GenerateCustomsReport();

            // GenerateCustomsReport() cannot be overridden in a derived class 
            // the sealed class can't be inherited
            #endregion
        }
    }
}
