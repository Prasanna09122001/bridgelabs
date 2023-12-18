using EmployeeManagers.IManager;
using EmployeeModels;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace EmployeeManagementSystem.Controllers
{
    public class EmployeeController : Controller
    {
        public readonly IEmpManager empManager;
        public EmployeeController(IEmpManager empManager)
        {
            this.empManager = empManager;
        }
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(Employee emp)
        {
            try
            {
                var result = this.empManager.AddEmployee(emp);
                if (result != null)
                {
                    ViewBag.Message = "Employeee Details Added Successfully";
                }
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
        public IActionResult GetAllEmployee()
        {
            List<Employee> objCategoryList = this.empManager.GetAllEmployee();
            return View(objCategoryList);
        }
        public ActionResult EditEmployee(int id)
        {
            var result = this.empManager.GetAllEmployee().Find(Emp => Emp.EmpId == id);
            if (result == null)
             {
                return View(); 
            }
            else
            {
                return View(result);
            }
        }
        [HttpPost]
        public ActionResult EditEmployee(Employee employee)
        {
            try
            {
                var result = this.empManager.UpdateEmployee(employee);
                if (result != null)
                {
                    ViewBag.Message = "Employee Details Updated Successfully";
                }
                return RedirectToAction("GetAllEmployee");
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
        public ActionResult DeleteEmployee(int id)
        {
            this.empManager.DeleteEmployee(id);
            return RedirectToAction("GetAllEmployee");
        }
    }
}
