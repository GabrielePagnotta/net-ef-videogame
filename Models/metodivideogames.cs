using Microsoft.Extensions.Configuration;
using net_ef_videogame.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_ef_videogame.Models
{
    public static class Metodivideogames
    {


        public static void addvideogame(string name, string ow, DateTime date, int sh)
        {
            using (VideogameContext context = new VideogameContext())
            {
                Videogame nuovovideogioco = new Videogame
                {

                    Name = name,
                    Overview = ow,
                    Release_date = date,
                    Software_houseId = sh,

                };
                context.Add(nuovovideogioco);
                context.SaveChanges();
            }
        }
        public static void searchvideogames(int id)
        {
            using (VideogameContext Context = new VideogameContext())
            {

                Videogame gioco = Context.Videogames.Where(videogame => videogame.VideogameId == id).First();
                if (gioco != null)
                {
                    Console.WriteLine($" [ID : {gioco.VideogameId}, NOME:{gioco.Name}, DESCRIZIONE: {gioco.Overview}, DATA DI RILASCIO:{gioco.Release_date}]");
                }
                else
                {
                    Console.WriteLine($"No videogame found with id {id}");
                }
            }
        }
        public static void addsoftwarehouse()
        {
            using (VideogameContext context = new VideogameContext())
            {
                Software_house nintendo = new Software_house
                {
                    Name = "Nintendo",
                    City = "hiroscima",
                    Country = "Giappone"
                };
                context.Add(nintendo);
                context.SaveChanges();
                Software_house Sony = new Software_house
                {
                    Name = "Sony",
                    City = "California",
                    Country = "America"
                };
                context.Remove(Sony);
                context.SaveChanges();
                Software_house Microsoft = new Software_house
                {
                    Name = "Microsoft",
                    City = "Seattle",
                    Country = "America"
                };
                context.Add(Microsoft);
                context.SaveChanges();
            }
        }


        //rimozione gioco
        public static void removegame(int id)
        {
            using (VideogameContext Context = new VideogameContext())
            {

                Videogame deletegioco = Context.Videogames.Where(videogame => videogame.VideogameId == id).First();
                if (deletegioco != null)
                {
                    Context.Remove(deletegioco);
                    Context.SaveChanges();
                    
                }
            }

        }

    }
}

