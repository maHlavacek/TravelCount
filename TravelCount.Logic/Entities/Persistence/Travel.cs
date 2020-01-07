using System;
using System.Collections.Generic;
using System.Text;
using TravelCount.Contracts.Persistence;

namespace TravelCount.Logic.Entities.Persistence
{
    public class Travel : ITravel
    {
        public string Designation { get; set; }
        public string Description { get ; set; }
        public string Currency { get ; set ; }
        public string Friends { get ; set ; }
        public string Category { get ; set ; }

        public int Id => throw new NotImplementedException();

        public void CopyProperties(ITravel other)
        {
            throw new NotImplementedException();
        }
    }
}
