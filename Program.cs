using net_ef_videogame.Migrations;
using net_ef_videogame.Models;



/*try
{
Console.WriteLine("inserisci un nome");
var name = Console.ReadLine();
Console.WriteLine("inserisci una descrizione");
var ow = Console.ReadLine();
Console.WriteLine("inserisci una data dd-MM-yy");
var date =Convert.ToDateTime( Console.ReadLine());
Console.WriteLine("inserisci l'id della software house");
var sh =Convert.ToInt32( Console.ReadLine());    

Metodivideogames.addvideogame(name,ow,date,sh);

}
catch(Exception ex) 
{
    Console.WriteLine(ex.Message);
    Environment.Exit(0);
}*/


//ricerca in base al nome o l'id
Console.WriteLine("inserisci se ricercare tramite nome o id");
string inputchoose = Console.ReadLine();

if("id" == inputchoose)
{
    Console.WriteLine("inserisci l'id");
    var inputsearch =Convert.ToInt32( Console.ReadLine());
    Metodivideogames.searchvideogamesbyid(inputsearch);
}else if ("nome" == inputchoose)
{
    Console.WriteLine("inserisci il nome");
    var inputsearch = Console.ReadLine();
    Metodivideogames.searchvideogamesbyname(inputsearch);
}
else
{
    Console.WriteLine("l'elemento inserito non è stato riconosciuto");
    Environment.Exit(0);
}

//cancellazione videogioco

/*Console.WriteLine("Inserisci l'id del gioco da cancellare");
int  inputdelete =Convert.ToInt32( Console.ReadLine());
Metodivideogames.removegame(inputdelete);*/
