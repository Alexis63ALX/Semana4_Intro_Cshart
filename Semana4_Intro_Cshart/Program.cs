// See https://aka.ms/new-console-template for more information
using Semana4_Intro_Cshart;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, World!");

string curso = "Desarrollo de Aplicaciones Web";
int edad = 20;
double salario = 2000;

/*asignacion de declaracion implicita*/
var alumno = "Alexis Meza";
var mundial = 2026;

var player = new Persona();
player.dni= 829847382;
player.name = "Paolo guerrero";
player.phone = "99999999";
player.active = true;

var player2 = new Persona(){
    dni = 84758939,
    name = "claudio pizarro",
    phone = "434859404",
    active = false,
};

var player3 = new Persona(11111111, "gianluca la padula", "8475894939", true);
var player4 = new Persona(22222222, "Pedro Galese", "8475894939", true);

var personas = new List<Persona>();
personas.Add(player);
personas.Add(player2);
personas.Add(player3);
personas.Add(player4);

//Buscar a la persona Laadula con DNI 22222222
//Linq Query Expressions

var busqueda = (from p in personas
                where p.dni == 11111111
                select p).FirstOrDefault();

Console.WriteLine("La persona encontrada es: " + busqueda.name);

//busqueda por lambda expressinos

var otraBusqueda = personas.Where(a=>a.dni == 22336688).FirstOrDefault();

