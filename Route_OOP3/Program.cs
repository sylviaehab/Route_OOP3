using Route_OOP3.Interfaces;

namespace Route_OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question1
            //is the process of hiding implementation details and showing only the essential features of an object.what not how
            //can be achieved using abstract classes and interfaces.
            //Because abstraction helps us hide complex implementation details and expose only what is necessary to the user, helps in maintaining the code in the future.

            #endregion
            //A)
            //interface: implemantation of interface is mandatory in the derived class, and it can be implemented by any class, struct, or record. It can contain only method signatures, properties, events, and indexers. A class can implement multiple interfaces.
            //abstract class: inheriting and implementing from an abstract class is optional, and it can be inherited only by a class. It can contain method implementations, fields, constructors, and destructors. A class can inherit only one abstract class.
            //B)
            //Choose an Interface when you want different, possibly unrelated classes to follow the same contract or behavior.(No Inheritance)
            //no One class parent, yes multiple interfaces.

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
                new DeliveryAddress(city, street, buildingNumber);

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
            Console.WriteLine("ITrackable[]");
            Console.WriteLine();
            ITrackable[] trackables = {
                standardShipment, expressShipment, internationalShipment

               };
            foreach (ITrackable trackable in trackables)
            {
                Console.WriteLine(trackable.GetTrackingStatus());
            }
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
