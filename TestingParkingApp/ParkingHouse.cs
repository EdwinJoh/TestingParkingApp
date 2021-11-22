using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingParkingApp
{
    public class ParkingHouse
    {

        public List<ParkingSpot>? ParkingList { get; set; } = Configuration.ReadParkingList();  //Instance our parkinglist, Read from our json file
        public Configuration? Settings { get; set; } = Configuration.ReadSettingsFromFile();    //Instance our settings class to get the value from our json settings file
        private string message;
        public DialogToUser Message { get; set; } = new DialogToUser();                         //Instance our dialog class to reach the method there.
        /// <summary>
        /// Construct our parkinghouse, we check if the parkinglist is null 
        /// or if there is parkingspots in the parked vehicles json file
        /// </summary>
        public ParkingHouse()
        {
            if (ParkingList == null)
            {
                ParkingList = new List<ParkingSpot>(capacity: Settings.ParkingHouseSize);
                NewParkingHouse();
            }
            else
            {
                ExpandParkinghouse();
            }
        }
        public string CreateVehicle(string regNum, string type)
        {
            switch (type)
            {
                case "Car":
                    Car newcar = new Car(regNum);
                    message = AddVehicle(newcar);
                    break;
                case "Mc":
                    MC newMc = new MC(regNum);
                    message = AddVehicle(newMc);
                    break;
                case "Bike":
                    Bike newBike = new Bike(regNum);
                    message = AddVehicle(newBike);
                    break;
                case "Bus":
                    Bus newBus = new Bus(regNum);
                    message = AddVehicle(newBus);
                    break;
                default:
                    break;
            }
            return message;
        }                           //Creating our diffrent vehicles
        public string AddVehicle(Vehicle vehicle)                                            // Adding our vehicles to the parkinglot if space is available
        {
            ParkingSpot spot = FirstAvailableSpace(vehicle);
            string regnum = CheckReg(vehicle.RegNumber);
            if (spot != null && vehicle.size <= Settings.ParkingSpotSize && regnum != null)
            {
                spot.AddVehicleToList(vehicle);
                Settings.UpdateParkingList(ParkingList);
                return $"Parked Vehicle: {vehicle.RegNumber} at spot {spot.SpotNumber}";


            }
            else if (spot != null && vehicle.size > Settings.ParkingSpotSize)
            {
                spot.Addlargevehicle(vehicle);
                Settings.UpdateParkingList(ParkingList);
                Message.SuccsessMessage("Parked", spot);
                return $"Parked vehicle {vehicle.RegNumber} at spot {spot.SpotNumber}";
            }
            if (regnum == null)
            {
                return "vehicle is already parked here";
            }
            else
            {
                return "The parkinghouse is full please come back later";
            }

        }
        public string RemoveVehicle(string regnum)
        {
            string checkIn;
            (Vehicle vehicle, ParkingSpot spot) = ExistRegnumber(regnum);
            if (vehicle == null)
            {
                return "Vehicle was not found ";
            }
            if (vehicle.size <= Settings.ParkingSpotSize)
            {
                checkIn = vehicle.TimeIn.ToString();
                CalculatePrice(checkIn, vehicle, out int price);
                spot.Remove(vehicle);
                Settings.UpdateParkingList(ParkingList);
                return $"Removed vehicle {vehicle.RegNumber} price to pay: {price}";
            }
            else if (vehicle.size >= Settings.ParkingSpotSize)
            {
                spot.RemoveLargeVehicle(vehicle);
                ResetLargeVehicleSpace(vehicle);
                Settings.UpdateParkingList(ParkingList);
                checkIn = vehicle.TimeIn.ToString();
                CalculatePrice(checkIn, vehicle, out int price);
                return $"Removed vehicle {vehicle.RegNumber} price to pay: {price}";
            }
            else
            {
                return "Vehicle was not found ";
            }
        }     // Removing vehicle from the program if its parked here.
        public ParkingSpot FirstAvailableSpace(Vehicle vehicle)                            // looping true the parking list and return the first available space for the vehicle, checks the size of the vehicle
        {
            List<ParkingSpot> Templist = new List<ParkingSpot>();

            if (vehicle.size <= Settings.ParkingSpotSize)
            {
                ParkingSpot spot = ParkingList.Find(x => x.AvailableSize >= vehicle.size);
                return spot;
            }
            else
            {
                for (int i = 0; i < Settings.SpacesForLargeVehicle; i++)
                {
                    if (ParkingList[i].AvailableSize == Settings.ParkingSpotSize)
                    {
                        Templist.Add(ParkingList[i]);
                    }
                    else if (ParkingList[i].AvailableSize < Settings.ParkingSpotSize)
                    {
                        Templist.Clear();
                        continue;
                    }
                    if (Templist.Count == vehicle.size / Settings.ParkingSpotSize)
                    {
                        foreach (var spots in Templist)
                        {
                            spots.Status = vehicle.RegNumber;
                            spots.AvailableSize -= Settings.ParkingSpotSize;
                        }
                        return ParkingList[i];
                    }
                }

            }

            return null;
        }
        public void NewParkingHouse()
        {
            for (int i = 0; i < Settings.ParkingHouseSize; i++)
            {
                ParkingList.Add(new ParkingSpot { SpotNumber = i + 1 });
            }
        }                                                   // Creating an new parkinghouse with new spots if the program does not have any spots saved
        public void ExpandParkinghouse()                                                   // Creating the parkinghouse from the saved parkingList
        {
            for (int i = ParkingList.Count; i < Settings.ParkingHouseSize; i++)
            {
                ParkingList.Add(new ParkingSpot { SpotNumber = i + 1 });
            }
        }
        public bool MoveVehicle(Vehicle vehicle, ParkingSpot oldSpot)
        {
            Message.AskForNewSpot();
            int newSpot = 4;
            if (newSpot != 0 && vehicle.size <= Settings.ParkingSpotSize)
            {
                if (CheckNewSpot(newSpot, vehicle, out ParkingSpot spot))
                {
                    RemoveVehicle(vehicle.RegNumber);
                    spot.AddVehicleToList(vehicle);
                    Settings.UpdateParkingList(ParkingList);
                    Message.SuccsessMessage("Moved", spot);
                    return true;
                }
            }
            else if (newSpot == 0)
            {

                return false;
            }
            else
            {
                if (newSpot <= Settings.SpacesForLargeVehicle && CheckSpotsInRows(vehicle, newSpot, out ParkingSpot spot))
                {
                    oldSpot.RemoveLargeVehicle(vehicle);
                    spot.Addlargevehicle(vehicle);
                    Settings.UpdateParkingList(ParkingList);
                    Message.BigVehiceSuccsess("Moved", newSpot, spot);
                    return true;
                }
            }
            return false;
        }                   // Moving vehicle, check if the vehicle is parked here. and move the vehicle if there is space in the new parking spot
        public bool CheckNewSpot(int newspot, Vehicle vehicle, out ParkingSpot newSpot)    // Check the new spot when moving the vehicle to see if there is enough space in the new spot
        {
            foreach (var spot in ParkingList)
            {
                if (spot.SpotNumber == newspot && spot.AvailableSize >= vehicle.size)
                {
                    newSpot = spot;
                    return true;

                }
            }
            newSpot = null;
            return false;
        }
        public (Vehicle?, ParkingSpot?) ExistRegnumber(string RegNumber)                   // Check if the regnumber the user input is an existing vehicle in the program
        {

            foreach (ParkingSpot spot in ParkingList)
            {
                foreach (Vehicle vehicle in spot.vehicles)
                {
                    if (vehicle.RegNumber == RegNumber)
                    {
                        return (vehicle, spot);
                    }
                    continue;
                }
            }
            return (null, null);
        }
        public int CalculatePrice(string checkIn, Vehicle vehicle, out int price)          // Calculating the price when checking out an vehicle deppening on the time its been parked and the price of the vehicle
        {

            TimeSpan span = DateTime.Now - vehicle.TimeIn;
            if (span.TotalMinutes <= Settings.FreeMin)
            {
                price = 0;
            }
            else
            {
                int hours;
                if (span.TotalMinutes < 60)// one hour
                {
                    price = vehicle.Price;
                }
                else
                {
                    hours = (int)span.TotalMinutes / 60;
                    hours++;
                    price = hours * vehicle.Price;
                }
            }
            return price;
        }
        public List<Vehicle> GetParkedVehicles()                                           // Collecting the parked vehicles to display for the user in showVehicles
        {
            var list = new List<Vehicle>();
            foreach (var parkingspots in ParkingList)
            {
                foreach (var v in parkingspots.vehicles)
                {
                    if (v != null)
                    {
                        list.Add(v);
                    }
                }
            }
            return list;
        }
        public void ResetLargeVehicleSpace(Vehicle vehicle)                                // Reset all the parkingspots when removing larger vehicles that takes more then on parkingspot,
        {
            foreach (var spot in ParkingList)
            {
                if (spot.Status == vehicle.RegNumber)
                {
                    spot.Status = "";
                    spot.AvailableSize = Settings.ParkingSpotSize;
                }
            }
        }
        public bool CheckSpotsInRows(Vehicle vehicle, int newSpot, out ParkingSpot NewSpot) // For moving larger vehicle that takes more then one parkingspot we check if the new spots and the x other parkingspaces is availble to move the vehicle
        {

            List<ParkingSpot> tempSpots = new List<ParkingSpot>();

            for (int i = newSpot - 1; i < ParkingList.Count; i++)
            {
                if (ParkingList[i].AvailableSize == Settings.ParkingSpotSize)
                {
                    tempSpots.Add(ParkingList[i]);
                }
                else if (ParkingList[i].Status == vehicle.RegNumber)
                {
                    tempSpots.Add(ParkingList[i]);
                }
                else
                {
                    tempSpots.Clear();
                    NewSpot = null;
                    return false;
                }
                if (tempSpots.Count == vehicle.size / Settings.ParkingSpotSize)
                {

                    ResetLargeVehicleSpace(vehicle);
                    foreach (var spot in tempSpots)
                    {
                        spot.AvailableSize -= Settings.ParkingSpotSize;
                        spot.Status = vehicle.RegNumber;

                    }
                    NewSpot = ParkingList[i];
                    Settings.UpdateParkingList(ParkingList);
                    return true;
                }
            }

            NewSpot = null;
            return true;
        }
        public void WriteSettingsToFile(Configuration settings)
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;
            string parkingHouseString = JsonConvert.SerializeObject(settings, Formatting.Indented);
            using (StreamWriter writer = new StreamWriter(@"../../../Files/ConfigSettings.json"))
            {
                writer.Write(parkingHouseString);
            }
            Environment.Exit(0);
        }                           // When modify the settings we write the new value to the configuration file so its save, restarting the program so the new setting can be applied
        public void ClearParkingSpots()
        {
            foreach (var spot in ParkingList)
            {
                if (spot.AvailableSize != Settings.ParkingSpotSize)
                {
                    spot.AvailableSize = Settings.ParkingSpotSize;
                    spot.Status = "";
                    spot.vehicles.Clear();
                }
            }
            Settings.UpdateParkingList(ParkingList);
            Console.WriteLine("Parkinglot reseting. All parked vehicles has been removed");
        }                                                   // clear the parkinglist from all the vehicles.
        public string CheckReg(string regNum)
        {
            foreach (var spot in ParkingList)
            {
                foreach (var vehicle in spot.vehicles)
                {
                    if (vehicle.RegNumber == regNum)
                    {
                        return null;
                    }
                }
            }
            return regNum;
        }
      
    }
}
