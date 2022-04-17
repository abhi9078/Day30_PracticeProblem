using System;
using System.Collections.Generic;

namespace CabInvoiceGenerator
{
    public class RideRepository
    {
        //Dictionari to store userId and List.
        Dictionary<string, List<Ride>> userRides = null;

        /// <summary>
        /// Constructor to create Dictionary
        /// </summary>
        public RideRepository()
        {
            userRides = new Dictionary<string, List<Ride>>();
        }

        /// <summary>
        /// Function to add ride to Specific Userid
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="rides"></param>
        /// <exception cref="CabInvoiceException"></exception>
        public void AddRide(string userId, Ride[] rides)
        {
            bool rideList=this.userRides.ContainsKey(userId);
            try
            {
                if (!rideList)
                {
                    List<Ride> list = new List<Ride>();
                    list.AddRange(rides);
                    userRides.Add(userId, list);
                }
            }
            catch (CabInvoiceException)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.NULL_RIDES, "Rides are null");
            }
        }

        /// <summary>
        /// Function to get list as an array for specific USer Id
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        /// <exception cref="CabInvoiceException"></exception>
        public Ride[] GetRides(string userId)
        {
            try
            {
                return this.userRides[userId].ToArray();
            }
            catch (Exception)
            {
                throw new CabInvoiceException(CabInvoiceException.ExceptionType.INVALID_USER_ID, "Invalid UserId");
            }
        }
    }
}