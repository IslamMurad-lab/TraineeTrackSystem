using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TraineeTrackSystem.Models;
using TraineeTrackSystem.ViewModels;

namespace TraineeTrackSystem.Controllers
{
    public class TraineeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TraineeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Trainee/ShowResult/1?crsId=2
        public IActionResult ShowResult(int id, int crsId)
        {
            var result = _context.CrsResults
                .FirstOrDefault(r => r.Trainee_Id == id && r.Crs_Id == crsId);

            if (result == null)
            {
                return NotFound();
            }

            var viewModel = new TraineeResultViewModel
            {
                TraineeName = result.Trainee.Name,
                CrsName = result.Course.Name,
                Degree = result.Degree,
                Passed = result.Degree >= result.Course.MinDegree
            };

            return View(viewModel);
        }

        // GET: /Trainee/ShowTraineeResult/1
        public IActionResult ShowTraineeResult(int id)
        {
            var trainee = _context.Trainees.FirstOrDefault(t => t.Id == id);

            if (trainee == null)
            {
                return NotFound();
            }

            var results = _context.CrsResults
                .Where(r => r.Trainee_Id == id)
                .Select(r => new CourseResultItem
                {
                    CrsName = r.Course.Name,
                    Degree = r.Degree,
                    Passed = r.Degree >= r.Course.MinDegree
                })
                .ToList();

            var viewModel = new TraineeAllResultsViewModel
            {
                TraineeName = trainee.Name,
                Results = results
            };

            return View(viewModel);
        }
        // GET: /Trainee/ShowCourseResult/1
        public IActionResult ShowCourseResult(int id)
        {
            var course = _context.Courses.FirstOrDefault(c => c.Id == id);

            if (course == null)
            {
                return NotFound();
            }

            var results = _context.CrsResults
                .Where(r => r.Crs_Id == id)
                .Select(r => new TraineeResultItem
                {
                    TraineeName = r.Trainee.Name,
                    Degree = r.Degree,
                    Passed = r.Degree >= course.MinDegree
                })
                .ToList();

            var viewModel = new CourseAllResultsViewModel
            {
                CrsName = course.Name,
                Results = results
            };

            return View(viewModel);
        }
    }
}