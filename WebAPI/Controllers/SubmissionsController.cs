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
    public class SubmissionsController : ApiController
    {
        MongoCRUD db = new MongoCRUD("TNCPDb");

        public IHttpActionResult PostSubmission([FromBody] Submission body)
        {
            System.Diagnostics.Debug.WriteLine("inserting: ", body);
            db.InsertRecord("Submissions", body);
            return Ok();
        }

        public IHttpActionResult GetSubmission(string Id)
        {
            System.Diagnostics.Debug.WriteLine("loading: ", Id);
            return Ok(db.LoadRecordById<Submission>("Submissions", Id));
        }

        public IHttpActionResult UpsertSubmission([FromBody] PrelimSubmission body, string Id)
        {
            System.Diagnostics.Debug.WriteLine("upserting: ", Id);
            db.UpsertRecord<PrelimSubmission>("Submissions", Id, body);
            return Ok();
        }

        public IHttpActionResult DeleteSubmission(string Id)
        {
            System.Diagnostics.Debug.WriteLine("deleting: ", Id);
            db.DeleteRecord<Submission>("Submissions", Id);
            return Ok();
        }

    }
}