using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BusManagementAPI.NewFolder;

namespace BusManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private static List<Bus> buslist = new List<Bus>()
        {
            new Bus
            {
                BusId=42,Source="Manglore",Destination="Talapady", Capacity=100,Name="Sleeper",DepartureTime=new DateTime(2023,08,05),ArrivalTime=new DateTime(2023,08,07),
            },
            new Bus
            {
                BusId=51,Source="Banglore",Destination="Mysore", Capacity=3400,Name="Seater",DepartureTime=new DateTime(2023,11,02),ArrivalTime=new DateTime(2023,12,05),
            },
        };
        [HttpGet("GetBus/{Destination}")]
        public List<Bus> GetBus()
        {
            return buslist;
        }
        [HttpGet("GetAllBus")]
        public List<Bus> GetAllBus()
        {
            return buslist;
        }
        [HttpPost("AddBus")]
        public void AddBus(Bus bus)
        {
            buslist.Add(bus);
        }
        //HttpDelete("DeleteBus")]
        //public void DeleteBus(int BusId)
        //{
            //var busToBeDeleted = buslist.Where(b => b.BusId )== BusId.FirstOrDefault();
            //buslist.Remove(busToBeDeleted);
        //}

    }
}
