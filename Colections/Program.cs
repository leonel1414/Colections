// Collections
//Collecion de String

/*
var coches = new List<string>();
coches.Add("Ford");
coches.Add("BMW");
coches.Add("Peugeot");


foreach (var co in coches)
{
    Console.Write(co + " ");
}


//lista 2
var coches2 = new List<string> {"Seat", "Wolkswager", "Fiar"};



*/

List<Elemento> elemento = CrearLista();

var query = from el in elemento where el.NumeroAtomico < 20
            //el.NumeroAtomico > 20
            select el;

foreach (Elemento el in query) {
    Console.WriteLine($"Nombre: {el.Nombre}, Simbolo: {el.Simbolo}, Numero Atomico: {el.NumeroAtomico}");
}

static List<Elemento> CrearLista() {

    return new List<Elemento>
    {
        { new Elemento(){ Simbolo = "K", Nombre = "Potasio", NumeroAtomico = 20}},
        { new Elemento(){ Simbolo = "Ca", Nombre = "Calcio", NumeroAtomico = 19}},
        { new Elemento(){ Simbolo = "Ti", Nombre = "Titanio", NumeroAtomico = 22}}
    };

}
public class Elemento { 

    public string Simbolo { get; set;}
    public string Nombre { get; set;}
    public int NumeroAtomico { get; set;}
}