using APITask.Filter;
using APITask.Models;
using APITask.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace APITask.Controllers
{
    public class TareaController : ApiController
    {
        //
        // GET: /Tarea/

        [ValidateModel]
        public IHttpActionResult Get() 
        {
            var tasks = new ServicesAgenda().getallTask();

            return Ok(tasks);
        }

        [ValidateModel]
        public IHttpActionResult Get(int Id) 
        {
            var tasks = new ServicesAgenda().getTaskById(Id);

            if (tasks != null)
            {
                return Ok(tasks);
            }
            else
            {
                return Content(HttpStatusCode.NotFound, "Task not found");
            }    
            
        }
        [ValidateModel]
        public IHttpActionResult Post(Tarea task) 
        {
            var tasks = new ServicesAgenda().addTask(task);

            if (tasks)
            {
                return Ok(tasks);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, "Task not save");
            }   
        }

        [ValidateModel]
        public IHttpActionResult Put(int ID)
        {
            var tasks = new ServicesAgenda().updateTask(ID);

            if (tasks)
            {
                return Ok(tasks);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, "Task not updated");
            }
        }

        [ValidateModel]
        public IHttpActionResult Delete(int ID)
        {
            var tasks = new ServicesAgenda().deletedTask(ID);

            if (tasks)
            {
                return Ok(tasks);
            }
            else
            {
                return Content(HttpStatusCode.InternalServerError, "Task not deteleted");
            }
        }
        

    }
}
