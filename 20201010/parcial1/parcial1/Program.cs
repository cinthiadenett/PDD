using System;
using System.Linq;

namespace parcial1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Insertar();
            Actualizacion();
            Consultar();
            Borrar();



        }
        static void Actualizacion()
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.Id == 1).Single();
            usuario.Nombre = "Eliana";

            var usuario2 = ctx.Usuario.Where(i => i.Id == 2).FirstOrDefault();
            if (usuario2 != null)
            {
                usuario2.Nombre = "jazmin";
            }
            var usuario3 = ctx.Usuarios.Where(i => i.Nombre == "fede" && i.Id < 4).FirstOrDefault();
            if (usuario3 != null)
            {
                usuario3.Nombre = "Alfredo";
            }
            ctx.SaveChanges();
        }

        static void Consultar()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Usuario.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Nombre: { item.Nombre} ({ item.Id})");
            }
        }
        static void Insertar()
        {

            var ctx = new TareasDbContext();

            ctx.Usuario.Add(new Usuario

            {
                Id = 2,
                Nombre = "cinthia",
                Clave = "1111"
            });
            ctx.Add(new Usuario()
            {
                Id = 2,
                Nombre = "Luis",
                Clave = "22222"
            });
            ctx.Add(new Usuario()
            {
                Id = 3,
                Nombre = "Marcedez",
                Clave = "33333"
            });

            ctx.SaveChanges();

        }
        static void Borrar()
        {
            var ctx = new TareasDbContext();

            var user = ctx.Usuario.Where(i => i.Id == 1).Single();
            ctx.Usuario.Remove(user);

            ctx.SaveChanges();
        }

    }

}

