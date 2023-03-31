using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame.Models
{
    public class Videogame
    {
        
        public int VideogameId { get; set; }
        public string Name { get; set; }
        public string Overview { get; set; }
        public DateTime Release_date { get; set; }

        public int? Software_houseId { get; set; }
        public Software_house softwarehouses { get; set; }
    }
}
