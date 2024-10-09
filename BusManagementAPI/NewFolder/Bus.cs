namespace BusManagementAPI.NewFolder
{
    public class Bus
    {
        public int BusId { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public  int Capacity { get; set; }
        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }

    }
}
