using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beibsolteams
{
    class Program
    {
        static void Main(string[] args)
        {
            
                List<Equipo> equipos = new List<Equipo>();

                Equipo Boston = new Equipo("Boston", "1");
                Equipo NewYork = new Equipo("NewYork", "2");




                equipos.Add(Boston);
                Jugador betts = new Jugador("betts", "21");
                Jugador xander = new Jugador("xander", "76");
                Jugador JD = new Jugador("JD", "89");
                Jugador benintendi = new Jugador("Benintendi", "41");
                Jugador devers = new Jugador("Devers", "98");
                Jugador vazquez = new Jugador("Vazquez", "31");
                Jugador sale = new Jugador("Sale", "26");
                Jugador rodriguez = new Jugador("Rodriguez", "59");
                Jugador bradley = new Jugador("bradley", "65");

                equipos.Add(NewYork);
                Jugador judge = new Jugador("Judge", "71");
                Jugador stanton = new Jugador("Stanton", "96");
                Jugador urshela = new Jugador("urshela", "59");
                Jugador gregorius = new Jugador("gregorius", "61");
                Jugador sabathia = new Jugador("sabathia", "45");
                Jugador torres = new Jugador("torres", "64");
                Jugador bartolo = new Jugador("bartolo", "55");
                Jugador frank = new Jugador("frank", "2");
                Jugador ford = new Jugador("ford", "7");





                Boston.Jugadores.Add(betts);
                Boston.Jugadores.Add(xander);
                Boston.Jugadores.Add(JD);
                Boston.Jugadores.Add(benintendi);
                Boston.Jugadores.Add(devers);
                Boston.Jugadores.Add(vazquez);
                Boston.Jugadores.Add(sale);
                Boston.Jugadores.Add(rodriguez);
                Boston.Jugadores.Add(bradley);


                NewYork.Jugadores.Add(judge);
                NewYork.Jugadores.Add(stanton);
                NewYork.Jugadores.Add(urshela);
                NewYork.Jugadores.Add(gregorius);
                NewYork.Jugadores.Add(sabathia);
                NewYork.Jugadores.Add(torres);
                NewYork.Jugadores.Add(bartolo);
                NewYork.Jugadores.Add(frank);
                NewYork.Jugadores.Add(ford);


                foreach (Equipo equipo in equipos)
                {

                    Console.WriteLine("Equipo: " + equipo.Codigo);
                    Console.WriteLine("EquipoN: " + equipo.EquipoN);
                    Console.WriteLine("Lista de Jugadores:");

                    foreach (Jugador jugador in equipo.Jugadores)
                    {
                        Console.WriteLine("*" + jugador.Nombre);
                    }

                }

                Console.Read();
            }
        }
    }




   
