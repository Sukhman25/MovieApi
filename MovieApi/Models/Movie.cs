using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApi.Models
{
    public class Movie
    {
        public int Id { get; set; }             //Primary Key
        public string MovieName { get; set; }           //Name of a movie
       
        public string Plot { get; set; }            //Some plot about movie
        public int ReleaseYear { get; set; }
        public bool IsBlockBuster { get; set; }             //Bool is added
        public DateTime CreatedDt { get; set; }                // Date time is also added
    }
}
