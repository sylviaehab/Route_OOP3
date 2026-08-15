namespace Route_OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Center Name: ");
            string centerName= Console.ReadLine();
            DeliveryCenter center= new DeliveryCenter(centerName);
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
            // CompletedShipment is sealed,
            // so another class cannot inherit from it.
            //
            // Example - NOT allowed:
            //
            // class TestShipment : CompletedShipment
            // {
            // }
            // GenerateCustomsReport() is sealed in PriorityInternationalShipment.
            // Therefore, a class that inherits from PriorityInternationalShipment
            // cannot override GenerateCustomsReport() again.

        }
    }
}
