using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BuilderDesignPattern.Models;
using BuilderDesignPattern.Factories.Employees;
using BuilderDesignPattern.Factories.Employees.BaseFactory;
using BuilderDesignPattern.Factories.AbstractFactory.Interfaces.AbstractInterface;
using BuilderDesignPattern.Factories.AbstractFactory.Client;
using BuilderDesignPattern.Factories.AbstractFactory.ConcreteFactory;
using BuilderDesignPattern.Builder;
using Microsoft.AspNetCore.Http;
using BuilderDesignPattern.Builder.IBuilder;
using BuilderDesignPattern.Builder.ConcreteBuilder;
using BuilderDesignPattern.Builder.Builder;
using BuilderDesignPattern.Builder.Product;

namespace BuilderDesignPattern.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly AppDbContext _context;

        public EmployeesController(AppDbContext context)
        {
            _context = context;
        }

        // This action will be used to create a system for each users
        [HttpGet]
        public ActionResult BuildSystem(int employeeID)
        {
            Employee employee = _context.Employees.Find(employeeID);
            if (employee.ComputerInfo.Contains("Laptop"))
                return View("BuildLaptop", employeeID);
            else
                return View("BuildSystem", employeeID);
        }

        // POST: BuildSystem
        // In this action we are implementing a simple Builder pattern
        //[HttpPost]
        //public ActionResult BuildSystem(BuildSystemViewModel model)
        //{
        //    // Retrieve an employee based on the Id that we have get from URL
        //    Employee employee = _context.Employees.Find(model.Id);

        //    // If there is not an employee, it will redirect to Index view
        //    if(employee==null)
        //    {
        //        return RedirectToAction("Index");
        //    }

        //    // Instantiate an objcet from ComputerSystem.cs and pass the value as the argumant of the constructor that we have added to the class
        //    ComputerSystem computerSystem = new ComputerSystem(model.Ram, model.HddDrive);

        //    // Build method return a string value and set it to the employee object that we have find it in Line 42
        //    employee.SystemConfigurationDetails = computerSystem.Build();
        //    _context.Entry(employee).State = EntityState.Modified;
        //    _context.SaveChanges();
        //    return RedirectToAction("Index");
        //}


        // This action create a laptop based on employee id that we have got from the url
        [HttpPost]
        public ActionResult BuildLaptop(IFormCollection formCollection)
        {
            Employee employee =
                  _context.Employees.Find(Convert.ToInt32(formCollection["employeeID"]));
            //Concrete Builder
            ISystemBuilder systemBuilder = new LaptopBuilder();
            //Director
            ConfigurationBuilder builder = new ConfigurationBuilder();
            // Build a laptop
            // BuildSystem method is a void method that create a laptop 
            // After that you can use systemBuilder variable and the GetSystem method, becuase in BuildSystem method, we create a string.
            builder.BuildSystem(systemBuilder, formCollection);

            // GetSystem method will return a computer system and set it to a computer system variable to get all method in ISystemBuilder

            ComputerSystem system = systemBuilder.GetSystem();

            // Now we can set to system variable the string that we have built in line 85
            employee.SystemConfigurationDetails =
        string.Format("RAM : {0}, HDDSize : {1}, TouchScreen: {2}"
        , system.RAM, system.HDDSize, system.TouchScreen);

            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult BuildSystem(IFormCollection formCollection)
        {
            //Step 1
            Employee employee
        = _context.Employees.Find(Convert.ToInt32(formCollection["employeeID"]));
            //Step 2 Concrete Builder
            ISystemBuilder systemBuilder = new DesktopBuilder();
            //Step 3 Director
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.BuildSystem(systemBuilder, formCollection);
            //Step 4 return the system
            ComputerSystem system = systemBuilder.GetSystem();
            employee.SystemConfigurationDetails =
        string.Format("RAM : {0}, HDDSize : {1}, Keyboard: {2}, Mouse : {3}"
        , system.RAM, system.HDDSize, system.KeyBoard, system.Mouse);
            _context.Entry(employee).State = EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            return View(await _context.Employees.ToListAsync());
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,HourlyPay,Bonus,TypeId,HouseAllowance,MedicalAllowance,JobDescription,ComputerInfo,SystemConfigurationDetails")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                // We use EmployeeManagerFactory which it returns BasedEmployeeFactory.
                // In EmployeManagerFactory we create a creator which is an abstract of IEmployeManager interface

                BaseEmployeeFactory empFactory = new EmployeeManagerFactory().CreateFactory(employee);
                empFactory.ApplySalary();

                // We create an object from EmployeeSystemFactory and due to the type of method that exist in that class we set
                // IComputerFactory type for our variable

                IComputerFactory factory = new EmployeeSystemFactory().Create(employee);

                // Create an object from EmployeeSystemManager and due to argument of the constructor we pass our 'factory' object
                EmployeeSystemManager manager = new EmployeeSystemManager(factory);

                // Set GetSystemDetails to ComputerInfo property which it returns a string as a computer info
                employee.ComputerInfo = manager.GetSystemDetails();
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,HourlyPay,Bonus,TypeId,HouseAllowance,MedicalAllowance")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}
