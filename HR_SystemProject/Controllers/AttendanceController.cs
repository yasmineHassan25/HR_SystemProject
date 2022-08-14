using Microsoft.AspNetCore.Mvc;
using HR_SystemProject.Repositories;
using HR_SystemProject.Models;
using HR_SystemProject.ViewModel;

namespace HR_SystemProject.Controllers
{
    public class AttendanceController : Controller
    {
        IAttendanceRepository attendanceRepo;
        IEmployeeRepository employeeRepo;
        public AttendanceController(IAttendanceRepository attendanceRepo, IEmployeeRepository employeeRepo)
        {
            this.attendanceRepo = attendanceRepo;
            this.employeeRepo = employeeRepo;
        }

        public IActionResult Index()
        {
            ViewBag.Attendances = attendanceRepo.GetAll();
            ViewBag.Employees = employeeRepo.GetAll();

            return View();
        }

        //for table of attendances..
        public IActionResult ShowAll()
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AttendanceForm(AttendanceViewModel newAttend)
        {
            if (ModelState.IsValid)
            {
                attendanceRepo.AddAttendance(newAttend);
                return RedirectToAction("Index");

            }

            return RedirectToAction("AttendanceForm", newAttend);
            
        }
        /* Validation on attendance date */
        public IActionResult CheckDate(DateTime date, int Emp_id)
        {
            Employee Emp = employeeRepo.GetByID(Emp_id);
            if(DateOnly.FromDateTime(date) < Emp.hiredate)
            {
                return Json($"Attendance date starts from hire date({Emp.hiredate})");
            }
            return Json(true);
        }

        /* Validation on attendance time */
        public IActionResult CheckAttendTime(DateTime checkIn, int Emp_id)
        {
            Employee Emp = employeeRepo.GetByID(Emp_id);
            if (TimeOnly.FromDateTime(checkIn) < Emp.checkIn)
            {
                return Json($"Attendance starts from ({Emp.checkIn})");
            }
            return Json(true);
        }

        /* Filter using name */
        public IActionResult DisplayAttendancesByName(string name)
        {
            return Json(attendanceRepo.GetByEmpName(name));
        }

        /* Filter using range dates */
        public IActionResult DisplayAttendancesBytwoDates(DateTime start, DateTime end)
        {
            return Json(attendanceRepo.GetbyPeriodOfDate(start, end));
        }

        [HttpPost]
        public IActionResult RemoveAttendance(string dateString  ,int Emp_Id)
        {
            DateOnly date = DateOnly.Parse(dateString);
            attendanceRepo.DeleteAttendance(date, Emp_Id);
            return RedirectToAction("Index");
        }
    }
}
