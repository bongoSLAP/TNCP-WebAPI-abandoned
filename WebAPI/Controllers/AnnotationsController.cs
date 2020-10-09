using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using WebAPI.Models;
using System.Web.Http;
using WebAPI.Services;

namespace WebAPI.Controllers
{
    public class AnnotationsController : ApiController
    {
        MongoCRUD db = new MongoCRUD("TNCPDb");

        public IHttpActionResult PostAnnotation([FromBody] Annotation body)
        {
            System.Diagnostics.Debug.WriteLine("inserting: ", body);
            db.InsertRecord("Annotations", body);
            return Ok();
        }

        public IHttpActionResult GetAnnotation(string Id)
        {
            System.Diagnostics.Debug.WriteLine("loading: ", Id);
            return Ok(db.LoadRecordById<Annotation>("Annotations", Id));
        }

        public IHttpActionResult UpsertAnnotation(string Id)
        {
            System.Diagnostics.Debug.WriteLine("upserting: ", Id);
            var record = db.LoadRecordById<Annotation>("Annotations", Id);
            db.UpsertRecord<Annotation>("Annotation", Id, record);
            return Ok();
        }

        public IHttpActionResult DeleteAnnotation(string Id)
        {
            System.Diagnostics.Debug.WriteLine("deleting: ", Id);
            db.DeleteRecord<Annotation>("Annotations", Id);
            return Ok();
        }
    }
}
