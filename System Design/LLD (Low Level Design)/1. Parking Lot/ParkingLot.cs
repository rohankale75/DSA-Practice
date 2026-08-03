namespace System_Design.LLD__Low_Level_Design_
{
    // Parking Lot
    // Parking Spot
    // Vehicle
    // Ticket
    // Fee Calculator

    // All above follow SEPARATION OF CONCERNS rule

    #region Vehicle type can fit in which Slot Type
    public static class SlotCompatibility
    {
        public static bool CanFit(VehicleType vehicle, SlotType slot)
        {
            return slot switch
            {
                SlotType.Bike => vehicle == VehicleType.Bike,
                SlotType.Car => vehicle == VehicleType.Car  // bike and car can fit
                            || vehicle == VehicleType.Bike,
                SlotType.Bus => true,   // all vehicles can fit
                _ => false  // default 
            };
        }
    }
    #endregion

    #region Hourly Rate Per Vehicle
    public class ParkingRates
    {
        public static decimal GetRates(VehicleType type) => type switch
        {
            VehicleType.Bike => 1.0m,
            VehicleType.Car => 2.0m,
            VehicleType.Bus => 3.0m,
            _ => 0m
        };
    }
    #endregion

    #region Vehicle
    public abstract class Vehicle
    {
        public string LicensePlate { get; }
        public VehicleType Type { get; }

        protected Vehicle(string Plate, VehicleType type)
        {
            LicensePlate = Plate;
            Type = type;
        }
    }

    public class Bike : Vehicle
    {
        public Bike(string Plate) : base(Plate, VehicleType.Bike) { } 
    }

    public class Car : Vehicle
    {
        public Car(string Plate) : base(Plate, VehicleType.Car) { }
    }

    public class Bus : Vehicle
    {
        public Bus(string Plate) : base(Plate, VehicleType.Bus) { }
    }
    #endregion

    #region Parking Slot
    public class ParkingSlot
    {
        public int SlotNumber { get; }
        public SlotType Type { get; }
        public bool IsAvailable { get; private set; } = true;
        public Vehicle CurrentVehicle { get; private set; }

        public ParkingSlot(int number, SlotType type)
        {
            SlotNumber = number;
            Type = type;
        }

        public bool CanFit(Vehicle vehicle) =>
            IsAvailable && SlotCompatibility.CanFit(vehicle.Type, Type);

        public void Assign(Vehicle vehicle)
        {
            CurrentVehicle = vehicle;
            IsAvailable = false;
        }

        public void Vacate()
        {
            CurrentVehicle = null;
            IsAvailable = true;
        }
    }
    #endregion

    #region Parking Ticket
    public class ParkingTicket
    {
        public string TicketId { get; } = Guid.NewGuid().ToString();
        public Vehicle Vehicle { get; }
        public ParkingSlot Slot { get; }
        public int FloorNumber { get; }
        public DateTime EntryTime { get; } = DateTime.Now;
        public DateTime? ExitTime { get; private set; }
        public decimal Fee { get; private set; }

        public ParkingTicket(Vehicle vehicle, ParkingSlot slot, int floor)
        {
            Vehicle = vehicle;
            Slot = slot;
            FloorNumber = floor;
        }

        public decimal CalculateFee()
        {
            ExitTime = DateTime.Now;
            var hours = Math.Ceiling((ExitTime.Value - EntryTime).TotalHours);
            Fee = (decimal)hours * ParkingRates.GetRates(Vehicle.Type);
            return Fee;
        }
    }
    #endregion

    #region Parking Floor
    public class ParkingFloor
    {
        public int FloorNumber { get; }
        public List<ParkingSlot> Slots { get; } = new();

        public ParkingFloor(int number, int bikeSlots, int carSlots, int busSlots)
        {
            FloorNumber = number;
            int SlotNum = 1;

            for (int i = 0; i < bikeSlots; i++)
            {
                Slots.Add(new ParkingSlot(SlotNum++, SlotType.Bike));
            }
            for (int i = 0; i < carSlots; i++)
            {
                Slots.Add(new ParkingSlot(SlotNum++, SlotType.Car));
            }
            for (int i = 0; i < busSlots; i++)
            {
                Slots.Add(new ParkingSlot(SlotNum++, SlotType.Bus));
            }
        }

        public ParkingSlot FindAvailableSlot(Vehicle vehicle) =>
            Slots.FirstOrDefault(x => x.CanFit(vehicle));

        public string GetStatus()
        {
            var bFee = Slots.Count(s => s.Type == SlotType.Bike && s.IsAvailable);
            var bTotal = Slots.Count(s => s.Type == SlotType.Bike);

            var cFee = Slots.Count(s => s.Type == SlotType.Car && s.IsAvailable);
            var cTotal = Slots.Count(s => s.Type == SlotType.Car);

            var busFee = Slots.Count(s => s.Type == SlotType.Bus && s.IsAvailable);
            var busTotal = Slots.Count(s => s.Type == SlotType.Bus);

            return $"Floor {FloorNumber}: {bFee / bTotal} Bike, {cFee / cTotal} Car, {busFee / busTotal} Bus slots are available.";
        }
    }
    #endregion

    // Main Class
    public class ParkingLot
    {

    }

    public enum SlotType { Bike, Car, Bus }

    public enum VehicleType { Bike, Car, Bus }


}
