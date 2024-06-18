using CapitalPlacementTask.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CapitalPlacementTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly AppDbContext _db;

        public ValuesController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IEnumerable<Question> GetQuestions(int programId)
        {
            var questions = _db.Questions.Where(x => x.ProgramId == programId).ToList();
            return questions;
        }

        [HttpPost]
        public IActionResult SubmitApplicaion(RequestDto request)
        {
            var userInformation = request.PersonalInformation;
            var questions = request.Questions;
            var program = request.ProgramDetail;

            if (userInformation != null)
            {
                _db.PersonalInformations.Add(userInformation);
                _db.SaveChanges();
            }
            if (questions != null)
            {
                
                 _db.Questions.AddRange(questions);
                 _db.SaveChanges();
            }
            if (program != null)
            {
                _db.ProgramDetails.Add(program);
                _db.SaveChanges();
            }
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateApplicaion(RequestDto request)
        {
            var userInformation = request.PersonalInformation;
            var questions = request.Questions;
            var program = request.ProgramDetail;

            if (userInformation != null)
            {
                _db.PersonalInformations.Add(userInformation);
                _db.SaveChanges();
            }
            if (questions != null)
            {

                _db.Questions.AddRange(questions);
                _db.SaveChanges();
            }
            if (program != null)
            {
                _db.ProgramDetails.Add(program);
                _db.SaveChanges();
            }
            return Ok();
        }


    }
}
