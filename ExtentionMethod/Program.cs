namespace ExtentionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //"Hello World".PrintToConsole();

            //HotelRoomModel roomModel = new HotelRoomModel();

            //roomModel.TurnOnAir().SetTemperature(72).OpenShades();

            //roomModel.TurnOffAir().CloseShades();
            //----------------------------------------------------------------------------------------------------

            PersonModel person = new PersonModel { FirstName="John", LastName = "Smith"};

            person.SetDefaultAge().PrintInfo();






            Console.ReadLine();
        }
    }
    public class PersonModel
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class HotelRoomModel
    {
        public int Temperature { get; set; }
        public bool IsAirRunning { get; set; }
        public bool AreShadesOpen { get; set; }
    }

    public static class ExtensionSamples
    {
        public static void PrintToConsole(this string message)
        {
            Console.WriteLine(message);
        }

        public static HotelRoomModel TurnOnAir(this HotelRoomModel room)
        {
            room.IsAirRunning = true;
            return room;
        }

        public static HotelRoomModel TurnOffAir(this HotelRoomModel room)
        {
            room.IsAirRunning = false;
            return room;
        }

        public static HotelRoomModel SetTemperature(this HotelRoomModel room, int temp)
        {
            room.Temperature = temp;
            return room;
        }

        public static HotelRoomModel OpenShades(this HotelRoomModel room)
        {
            room.AreShadesOpen = true;
            return room;
        }

        public static HotelRoomModel CloseShades(this HotelRoomModel room)
        {
            room.AreShadesOpen = false;
            return room;
        }
    }

    public static class ExtensionMethods2
    {
        public static void PrintInfo(this PersonModel person)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName} is {person.Age} years old.");
        }

        public static PersonModel SetDefaultAge(this PersonModel person)
        {
            person.Age = 18;
            return person;
        }
    }
}