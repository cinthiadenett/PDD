
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class RecursoServicio
    {
        public List<Recurso> GetRecursos()
        {
            var bd = new TareasDbContext();

            var list = bd.Recurso.ToList();

            return list;

        }



        private TareasDbContext context;

        public RecursoServicio(TareasDbContext _context)
        {
            context = _context;
        }

        public async Task<Recurso> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GetRecurso(id);
            //return await context.Recurso.Where(i => i.Id == id).SingleAsync();
        }
        public async Task<List<Recurso>> GetAllRecurso()
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GetAllRecurso();
        }
        /*
             if (value.id == 0)
             {
                 await context.Recursos.AddAsync(value);
             }
             else
             {
                 context.Recursos.Update(value);
             }
             await context.SaveChangesAsync();
             return value;
             */
        public async Task<Recurso> SaveRecurso(Recurso valor)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GuardarRecurso(valor);
        }

        

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Recurso.Where(i => i.Id == id).SingleAsync();
            context.Recurso.Remove(entidad);

            await context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Usuarios>> GetUsuarios()
        {
            return await context.Usuarios.ToListAsync();
        }
    }
}
