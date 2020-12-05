using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class UsuariosServicio
    {
        public List<Usuarios> getUsuarios()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Usuarios.ToList();

            return lista;

        }
        private TareasDbContext context;

        public UsuarioServicio(TareasDbContext _context)
        {
            context = _context;
        }

        public async Task<Usuarios> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GetUsuario(id);
            //return await context.Usuario.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<List<Usuarios>> GetAllUsuario()
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GetAllUsuario();
        }

        public async Task<Usuarios> SaveUsuario(Usuarios valor)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GuardarUsuario(valor);
        }


        /*public async Task<List<Usuario>> GetAll()
        {
            return await context.Usuario.ToListAsync();
        }
        public async Task<Usuario> Save(Usuario value)
        {
            if (value.Id == 0)
            {
                await context.Usuario.AddAsync(value);
            }
            else
            {
                context.Usuario.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }*/

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Usuarios.Where(i => i.Id == id).SingleAsync();
            context.Usuarios.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
