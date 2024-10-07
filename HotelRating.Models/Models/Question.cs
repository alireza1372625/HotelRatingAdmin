using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelRating.Model.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}
