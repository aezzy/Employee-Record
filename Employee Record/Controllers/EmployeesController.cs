using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Employee_Record.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Employee_Record.Controllers
{
    public class EmployeesController : Controller
    {
        public static List<EmpRecord> empRecord = new List<EmpRecord>();

        public IActionResult Index()
        {
          
            //by default these items will be shown everytime when the page is loaded
            if(empRecord.Count ==0)
            {
                empRecord.Add(new EmpRecord { Id = 1, Name = "Ankur", City = "Malmö" });
                empRecord.Add(new EmpRecord { Id = 2, Name = "Rahul", City = "Lund" });
            }



            return View(empRecord);
        }

        //this is to load the create page for input
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        //item will be added in the list and be shown until the page is opened
        [HttpPost]
        public IActionResult Create(EmpRecord e)
        {
            empRecord.Add(e);
            return RedirectToAction("Index");
        }

        // GET: Default/Details
        public IActionResult Details(int Id, EmpRecord e)
        {
            e = empRecord.Find(x => x.Id == e.Id);

          
            return View(e);
        }

        // POST: Default/Display partial view
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
        public IActionResult Display()
        {

            List<EmpRecord> tdList = new List<EmpRecord>();
            EmpRecord td = new EmpRecord();
            int Id; string Name; string City;
            Id = td.Id;
            Name = td.Name;
            City = td.City;
            tdList.Add(td);
            return View("test");
        }



        // GET: Default/Edit
        public IActionResult Edit(int? Id, EmpRecord e)
        {
            e = empRecord.Find(x => x.Id == e.Id);


            return View(e);
        }

        //GET: Default/Delete
        public IActionResult Delete(int? Id, EmpRecord e)
        {
            e = empRecord.Find(x => x.Id == e.Id);
            empRecord.Remove(e);


            return View(e);
        }




        [HttpPost]
        public IActionResult Edit(EmpRecord e)
        {
            if(ModelState.IsValid) 
                { 
            var temp = empRecord.Find(x => x.Id == e.Id);
                empRecord.Remove(temp);
                empRecord.Add(e);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");


        }
       
    }                                                                                                                                                                                                                                 
}