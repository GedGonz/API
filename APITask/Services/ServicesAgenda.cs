using APITask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APITask.Services
{
    public class ServicesAgenda
    {
        public List<Tarea> getallTask() 
        {
            var List=new List<Tarea>();
            using(var conexion=new AgendaEntities())
            {
                List=conexion.Tareas.ToList();
            }
            return List;
        }
        public Tarea getTaskById(int Id)
        {
            var task = new Tarea();
            using (var conexion = new AgendaEntities())
            {
                task = conexion.Tareas.FirstOrDefault(x=>x.ID==Id);
            }
            return task;
        }

        public bool addTask(Tarea task)
        {
            var retorno = false;
            using (var conexion = new AgendaEntities())
            {
                conexion.Tareas.Add(task);
                conexion.SaveChanges();
                retorno = true;
            }
            return retorno;
        }
        public bool updateTask(int ID)
        {
            var retorno = false;
            using (var conexion = new AgendaEntities())
            {
                var t = conexion.Tareas.FirstOrDefault(x => x.ID == ID);
                t.estado = (t.estado) ? false : true;
                conexion.SaveChanges();
                retorno = true;
            }
            return retorno;
        }
        public bool deletedTask(int ID)
        {
            var retorno = false;
            using (var conexion = new AgendaEntities())
            {
                var t = conexion.Tareas.FirstOrDefault(x => x.ID == ID);
                conexion.Tareas.Remove(t);
                conexion.SaveChanges();
                retorno = true;
            }
            return retorno;
        }

    }
}