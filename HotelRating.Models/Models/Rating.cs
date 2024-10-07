using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelRating.Model.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public double Score { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
