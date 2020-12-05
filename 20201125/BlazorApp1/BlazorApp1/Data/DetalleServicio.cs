using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class DetalleServicio
    {
        public List<Detalle> getDetalles()
        {
            var ctx = new dbContext();
            var lista = ctx.Detalles.ToList();
            return lista;
        }
        private dbContext context;
        public DetalleServicio(dbContext _context)
        {
            context = _context;
        }

        public async Task<Detalle> Get(int id)
        {
            return await context.Detalles.Where(i => i.id == id).SingleAsync();
            
        }

        public async Task<List<Detalle>> GetAll()
        {
            // return await context.Detalles.ToListAsync();
            var remoteService = RestService.For<RemoteService>("https://localhost:44357/api/");
            return await remoteService.GetAllDetalle();
        }

        public async Task<Detalle> Save(Detalle value)
        {
            
            var remoteService = RestService.For<RemoteService>("https://localhost:44357/api/");
            return await remoteService.GuardarDetalles(value);
        }

        public async Task<bool> Remove(int id)
        { 
            var entidad = await context.Detalles.Where(i => i.id == id).SingleAsync();
        context.Detalles.Remove(entidad);
            await context.SaveChangesAsync();
            return true;

           

        public async Task<List<Recurso>> GetRecurso()
        {
            return await context.Recursos.ToListAsync();
                //  return await context.Tareas.ToListAsync();
                var remoteService = RestService.For<RemoteService>("https://localhost:44357/api/");
                return await remoteService.GetAllTarea();

            }

        public async Task<List<Tarea>> GetTarea()
        {
            return await context.Tareas.ToListAsync();
            //  return await context.Tareas.ToListAsync();
            var remoteService = RestService.For<RemoteService>("https://localhost:44357/api/");
            return await remoteService.GetAllTarea();
        }
    }
}
