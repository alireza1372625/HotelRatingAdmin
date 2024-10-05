using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelRating.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}




