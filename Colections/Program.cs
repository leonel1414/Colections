﻿// Collections
//Collecion de String

using System.Collections;
using System.Collections.Generic;


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

/*
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


using System.Data.Common;
using System.Runtime.CompilerServices;

ListarCoches();
static void ListarCoches() {
    var cars = new List<Car> {
        {new Car() {Name = "car6", Color = "blue", Speed = 20} },
        {new Car() {Name = "car3", Color = "red", Speed = 10} },
        {new Car() {Name = "car4", Color = "green", Speed = 50} },
        {new Car() {Name = "car5", Color = "blue", Speed = 40} },
        {new Car() {Name = "car2", Color = "yellow", Speed = 30} },
        {new Car() {Name = "car1", Color = "blue", Speed = 20} }
    };
    cars.Sort();
    foreach (Car car in cars) {
    Console.WriteLine($"Nombre: {car.Name}, Color: {car.Color}, Velocidad: {car.Speed}");
    
    }
}



class Car : IComparable<Car>{
    public string Name { get; set; }
    public string Color { get; set; }
    public int Speed { get; set; }




    public int CompareTo(Car? other)
    {

        int compare;
        compare = String.Compare(this.Name, other.Name, true);

        if (compare == 0)
        {
            compare= this.Name.CompareTo(other.Name);
            compare = -compare;
        }
        //throw new NotImplementedException();
        return compare;
    }
}
*/
//CLASE DE COLLECCION PERSONALIZADA

public class MisColores : System.Collections.IEnumerable
{
    Colores[] _colores = {
     new Colores(){Nombre = "Azul" },
     new Colores(){Nombre = "Rojo" },
     new Colores(){Nombre = "Verde" },
    };
    public System.Collections.IEnumerable GetEnumerator(){
        
        return new ColoresEnumerator(_colores);
    
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

public class Colores {
   public string Nombre { get; set; }
}