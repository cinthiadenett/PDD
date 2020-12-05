using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class IRemoteService
    {
        [Get("/Usuarios")]
         Task<List<Usuarios>> GetAllUsuarios();

        [Get("/Usuarios/{id}")]
        Task<Usuarios> GetUsuarios(int id);

        [Post("/Usuarios")]
        Task<Usuarios> GuardarUsuarios(Usuarios valor);


        [Get("/Recurso")]
        Task<List<Recurso>> GetAllRecurso();

        [Get("/Recurso/{id}")]
        Task<Recurso> GetRecurso(int id);


        [Post("/Recurso")]
        Task<Recurso> GuardarRecurso(Recurso valor);


        [Get("/Detalle")]
        Task<List<Detalle>> GetAllDetalle();

        [Get("/Detalle/{id}")]
        Task<Detalle> GetDetalle(int id);

        [Post("/Detalle")]
        Task<Detalle> GuardarDetalle(Detalle valor);


        [Get("/Tarea")]
        Task<List<Tarea>> GetAllTarea();

        [Get("/Tarea/{id}")]
        Task<Tarea> GetTarea(int id);

        [Post("/Tarea")]
        Task<Tarea> GuardarTarea(Tarea valor);



    }

}

