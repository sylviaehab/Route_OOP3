using Route_OOP3.Interfaces;

namespace Route_OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question1
            //A)both variables refer to the same object in memory the two variables if one change the other will also change
            //B)No Assignment only copies the reference, not the object itself.
            //C)
            //Copying the reference:
            //Both variables refer to the same object.
            //Changes through one variable affect the other.
            //Copying the object:
            //A new separate object is created
            //Changes to one object do not affect the other


            #endregion
            #region Question2

            //A)A Shallow Copy creates a new object, but its reference-type members still point to the same objects as the original
            //B)A Deep Copy creates a new object and also creates new copies of its reference-type members.
            //C)The reference-type members are not copied as new objects,Instead, both objects refer to the same referenced object.
            //D)New objects are created for the reference-type members.
            //E)Deep Copy is safer when you need two objects to be completely independent. 
            #endregion

            #region Question3
            //A)A static field belongs to the class itself and is shared by all objects.
            //An instance field belongs to a specific object, so every object has its own copy
            //B)A static method belongs to the class, not to a specific object.
            //A static method cannot directly access instance members, because it does not have an object instance.
            //C)A static constructor is used to initialize static data.,Runs automatically once, before the class is first used.
            //D)A static class is a class that contains only static members.
            //You cannot create an object from a static class.

            #endregion
            #region Question4
            //A)An Extension Method is a method that allows you to add a new method to an existing type without modifying its original class
            //B)The keyword this must be used before the first parameter.
            //C)An extension method must be declared inside a static class.
            //D)No.It can access members that are accessible normally, such as public members. 
            #endregion
            #region Question5

            //A)A Partial Class allows you to split the definition of one class into multiple files
            //B)To make large classes easier to organize and maintain.,To avoid conflicts when multiple developers are working on the same class simultaneously.
            //C)A Partial Method allows one part of a partial class to declare a method, while another part can provide its implementation
            //D)If a partial method has no implementation it can be removed by the compiler, and calls to it will be ignored 
            #endregion. This can help reduce unnecessary code and improve performance.
           

            Console.Write("Enter Center Name: ");
            string centerName = Console.ReadLine();
            DeliveryCenter center = new DeliveryCenter(centerName);
            Console.WriteLine("=====Driver Inf=====");
            int driverId;
            do
            {
                Console.Write("Enter Driver Id :");
            } while (!int.TryParse(Console.ReadLine(), out driverId) || driverId <= 0);
            string name;
            do
            {
                Console.Write("Enter Driver Name :");
                name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name));
            string phoneNumber;

            do
            {
                Console.Write("Enter Phone Number: ");
                phoneNumber = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(phoneNumber));

            Driver driver = new Driver(driverId, name, phoneNumber);

            center.Driver = driver;
            Console.WriteLine("\n===== Standard Shipment =====");

            string trackingCode;
            do
            {
                Console.Write("Tracking Code: ");
                trackingCode = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(trackingCode));

            string description;
            do
            {
                Console.Write("Description: ");
                description = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(description));

            decimal weight;
            do
            {
                Console.Write("Weight: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out weight) || weight <= 0);

            decimal deliveryFee;
            do
            {
                Console.Write("Delivery Fee: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out deliveryFee) || deliveryFee <= 0);

            string city;
            do
            {
                Console.Write("City: ");
                city = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(city));

            string street;
            do
            {
                Console.Write("Street: ");
                street = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(street));

            int buildingNumber;
            do
            {
                Console.Write("Building Number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out buildingNumber) || buildingNumber <= 0);

            DeliveryAddress standardAddress =
                new DeliveryAddress(street, city, buildingNumber);

            StandardShipment standardShipment =
                new StandardShipment(
                    trackingCode,
                    description,
                    weight,
                    deliveryFee,
                    standardAddress);

            center.AddShipment(standardShipment);

            Console.WriteLine("\n===== Express Shipment =====");

            do
            {
                Console.Write("Tracking Code: ");
                trackingCode = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(trackingCode));

            do
            {
                Console.Write("Description: ");
                description = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(description));

            do
            {
                Console.Write("Weight: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out weight) || weight <= 0);

            do
            {
                Console.Write("Delivery Fee: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out deliveryFee) || deliveryFee <= 0);

            decimal extraFee;
            do
            {
                Console.Write("Extra Fee: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out extraFee) || extraFee < 0);

            do
            {
                Console.Write("City: ");
                city = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(city));

            do
            {
                Console.Write("Street: ");
                street = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(street));

            do
            {
                Console.Write("Building Number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out buildingNumber) || buildingNumber <= 0);

            DeliveryAddress expressAddress =
                new DeliveryAddress(city, street, buildingNumber);

            ExpressShipment expressShipment =
                new ExpressShipment(
                    trackingCode,
                    description,
                    weight,
                    deliveryFee,
                    expressAddress,
                    extraFee);

            center.AddShipment(expressShipment);

            Console.WriteLine("\n===== International Shipment =====");

            do
            {
                Console.Write("Tracking Code: ");
                trackingCode = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(trackingCode));

            do
            {
                Console.Write("Description: ");
                description = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(description));

            do
            {
                Console.Write("Weight: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out weight) || weight <= 0);

            do
            {
                Console.Write("Delivery Fee: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out deliveryFee) || deliveryFee <= 0);

            string destinationCountry;
            do
            {
                Console.Write("Destination Country: ");
                destinationCountry = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(destinationCountry));

            decimal customsFee;
            do
            {
                Console.Write("Customs Fee: ");
            }
            while (!decimal.TryParse(Console.ReadLine(), out customsFee) || customsFee < 0);

            do
            {
                Console.Write("City: ");
                city = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(city));

            do
            {
                Console.Write("Street: ");
                street = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(street));

            do
            {
                Console.Write("Building Number: ");
            }
            while (!int.TryParse(Console.ReadLine(), out buildingNumber) || buildingNumber <= 0);

            DeliveryAddress internationalAddress =
                new DeliveryAddress(city, street, buildingNumber);

            InternationalShipment internationalShipment =
                new InternationalShipment(
                    trackingCode,
                    description,
                    weight,
                    deliveryFee,
                    internationalAddress,
                    destinationCountry,
                    customsFee);

            center.AddShipment(internationalShipment);

            Console.WriteLine("====All Shipment====");
            center.PrintAllShipments();

           
            Shipment shipment2 = standardShipment;
            Console.WriteLine("==========================================");
            Console.WriteLine("Object Copying");
            Console.WriteLine("==========================================");

            Console.WriteLine($"Original Shipment : {standardShipment.TrackingCode}");
            Console.WriteLine($"Assigned Shipment : {shipment2.TrackingCode}");

            Console.WriteLine(
                $"Same Object : {ReferenceEquals(standardShipment, shipment2)}");
            Shipment shipment3 = standardShipment.CopyShipment();
            Console.WriteLine(
               $"Same Object After CopyShipment : " +
               $"{ReferenceEquals(standardShipment, shipment3)}");




            Shipment shallowCopy = standardShipment.ShallowCopy();
            Console.WriteLine("===== Shallow Copy =====");

            Console.WriteLine(
                $"Same Shipment object? " +
                $"{ReferenceEquals(standardShipment, shallowCopy)}");

            Console.WriteLine(
                $"Same DeliveryAddress object? " +
                $"{ReferenceEquals(standardShipment.Destination, shallowCopy.Destination)}");

            Console.WriteLine(
    $"Original City: {standardShipment.Destination.city}");

            Console.WriteLine(
                $"Copied City: {shallowCopy.Destination.city}");
            shallowCopy.Destination.city = "Giza";
            Console.WriteLine(
    $"Original City after change: {standardShipment.Destination.city}");

            Console.WriteLine(
                $"Copied City after change: {shallowCopy.Destination.city}");






            Shipment deepCopy = standardShipment.DeepCopy();

            Console.WriteLine();
            Console.WriteLine("===== Deep Copy =====");

            Console.WriteLine(
                $"Same Shipment object? " +
                $"{ReferenceEquals(standardShipment, deepCopy)}");

            Console.WriteLine(
                $"Same DeliveryAddress object? " +
                $"{ReferenceEquals(standardShipment.Destination, deepCopy.Destination)}");
            Console.WriteLine(
    $"Original City: {standardShipment.Destination.city}");

            Console.WriteLine(
                $"Copied City: {deepCopy.Destination.city}");
            deepCopy.Destination.city = "sharm";

            Console.WriteLine(
    $"Original City after change: {standardShipment.Destination.city}");

            Console.WriteLine(
                $"Copied City after change: {deepCopy.Destination.city}");


            DeliveryUtilities.PrintSeparator();

            Console.WriteLine("Static Shipment Counter");
            Console.WriteLine(
    $"Total Shipments Created: {Shipment.GetTotalShipmentsCreated()}");

            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Shipment Extensions");
            Console.WriteLine($"Summary: {standardShipment.GetSummary()}");
            Console.WriteLine($"Is Delivered ?: {standardShipment.IsDeliverable()}");

            DeliveryUtilities.PrintSeparator();
            Console.WriteLine("Partial Methods");



            Console.WriteLine(
    $"Current Status: {standardShipment.GetTrackingStatus()}");

            standardShipment.UpdateTrackingStatues("Out For Delivery");

            Console.WriteLine(
                $"Current Status: {standardShipment.GetTrackingStatus()}");

            standardShipment.UpdateTrackingStatues("Delivered");

            Console.WriteLine(
                $"Is Delivered: {standardShipment.IsDeliverable()}");
            



                Console.WriteLine("Printing Using DeliveryHelper...");
            DeliveryHelper.PrintShipmentDetails(standardShipment);
            DeliveryHelper.PrintShipmentDetails(expressShipment);
            DeliveryHelper.PrintShipmentDetails(internationalShipment);

            Console.WriteLine("\n===== Update Weight =====");

            Console.WriteLine($"Original Weight: {standardShipment.Weight}");

            standardShipment.UpdateWeight(5);

            Console.WriteLine(
                $"After UpdateWeight: {standardShipment.Weight}");


            standardShipment.UpdateWeight(5, 0.5m);

            Console.WriteLine(
                $"After UpdateWeight(5, 0.5): {standardShipment.Weight}");

            Shipment[] mixedShipments =
{
                standardShipment,
               expressShipment,
                internationalShipment
            };

            Console.WriteLine("\n===== Mixed Shipment Array =====");

            foreach (Shipment shipment in mixedShipments)
            {
                shipment.PrintShipment();
                Console.WriteLine("----------------------");
            }
            Console.WriteLine("==========================================");
            Console.WriteLine("Tracking Status");
            center.PrintTrackingStatuses();
            DeliveryReport report =
              new DeliveryReport();
            Console.WriteLine("==========================================");
            Console.WriteLine("Insurance");
            report.PrintInsurance(standardShipment);
            Console.WriteLine();
            report.PrintInsurance(expressShipment);
            Console.WriteLine();
            report.PrintInsurance(internationalShipment);
            Console.WriteLine("==========================================");
            Console.WriteLine("ITrackable[]");
            Console.WriteLine();
            ITrackable[] trackables = {
                            standardShipment, expressShipment, internationalShipment

                           };
            foreach (ITrackable trackable in trackables)
            {
                Console.WriteLine(trackable.GetTrackingStatus());
            }
            Console.WriteLine("==========================================");
            Console.WriteLine("IInsurance[]");
            IInsurable[] insurables = {
                            standardShipment, expressShipment, internationalShipment
                        };
            foreach (IInsurable insurable in insurables)
            {
                Console.WriteLine($"Insurance: {insurable.CalculateInsurance()}");
            }
            Console.WriteLine("==========================================");
            Console.WriteLine(
             "Interface Polymorphism Demonstrated Successfully.");

        }
    }
}
