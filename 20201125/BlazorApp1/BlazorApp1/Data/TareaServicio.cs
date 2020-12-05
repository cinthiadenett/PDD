using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareaServicio
    {
        public List<Tarea> GetTareas()
        {
            var bd = new TareasDbContext(); 

            var list = bd.Tarea.ToList();

            return list;
        }




        private TareasDbContext context;

        public TareaServicio(TareasDbContext _context)
        {
            context = _context;
        }

        public async Task<Tarea> Get(int id)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GetTarea(id);
            //return await context.Tarea.Where(i => i.Id == id).SingleAsync();
        }

        public async Task<List<Tarea>> GetAllTarea()
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GetAllTarea();
        }


        public async Task<Tarea> SaveTarea(Tarea valor)
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GuardarTarea(valor);
        }


        /*public async Task<List<Tarea>> GetAll()
        {
            return await context.Tarea.ToListAsync();
        }*/

        /* public async Task<Tarea> Save(Tarea value)
         {
             if (value.Id == 0)
             {
                 await context.Tarea.AddAsync(value);
             }
             else
             {
                 context.Tarea.Update(value);
             }
             await context.SaveChangesAsync();
             return value;
         }*/

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Tarea.Where(i => i.Id == id).SingleAsync();
            context.Tarea.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }
        public async Task<List<Recurso>> GetAllRecurso()
        {
            var remoteService = RestService.For<IRemoteService>("http://localhost:64280/api/");
            return await remoteService.GetAllRecurso();
        }

    }
}
