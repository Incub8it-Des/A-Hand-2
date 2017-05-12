using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using A_Hand_2.Models;

namespace A_Hand_2.Controllers.api
{
    public class AskTaskApiController : ApiController
    {

        private ApplicationDbContext _context;

        public AskTaskApiController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/asktasks
        public IEnumerable<AskTask> GetAskTasks()
        {
            return _context.AskTasks.ToList();
        }

        //GET /api/asktasks/1
        public AskTask GetAskTask(int id)
        {
            var asktask = _context.AskTasks.SingleOrDefault(at => at.Id == id);

            if (asktask == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return asktask;
        }

        // POST /api/asktask
        [HttpPost]
        public AskTask CreateAskTask(AskTask asktask)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.AskTasks.Add(asktask);
            _context.SaveChanges();

            return asktask;
        }

        // PUT /api/asktask/1
        [HttpPut]
        public void UpdateAskTask(int id, AskTask asktask)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var asktaskInDb = _context.AskTasks.SingleOrDefault(at => at.Id == id);
            if (asktaskInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            asktaskInDb.BasicDescription = asktask.BasicDescription;

            _context.SaveChanges();
        }

        // DELETE /asp/asktask/1
        [HttpDelete]
        public void DeleteAskTask(int id)
        {
            var asktaskInDb = _context.AskTasks.SingleOrDefault(at => at.Id == id);
            if (asktaskInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.AskTasks.Remove(asktaskInDb);
            _context.SaveChanges();
        }

    }
}
