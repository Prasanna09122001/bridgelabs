using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class RideRepository
    {
        Dictionary<string, List<Ride>> Userrides = new Dictionary<string, List<Ride>>();
        public void AddRides(string userId, Ride[] ride)
        {
            bool isExist = Userrides.ContainsKey(userId);
            List<Ride> rides = new List<Ride>();
            if (!isExist)
            {
                rides.AddRange(ride);
                Userrides.Add(userId, rides);
            }
            else
            {
                foreach (var data in Userrides)
                {
                    if (data.Key.Equals(userId))
                    {
                        rides = data.Value;
                    }
                }
                foreach (var item in ride)
                {
                    rides.Add(item);
                }
            }
        }
        public Ride[] GetRides(string userId)
        {
            return Userrides[userId].ToArray();
        }
    }
}
