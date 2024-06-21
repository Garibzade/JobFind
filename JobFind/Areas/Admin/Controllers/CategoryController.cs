using JobFind.DAL;
using JobFind.Models;
using JobFind.ViewModel.Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using NuGet.Protocol;

namespace JobFind.Areas.Admin.Controllers
{
        [Area("Admin")]
    public class CategoryController(JobFindContext _context,IWebHostEnvironment environment) : Controller
    {
        public IWebHostEnvironment Environment { get; } = environment;



        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.Select(c => new GetCategoryAdminVM
            {
                Id = c.Id,
                Name = c.Name,
                Icon = c.Icon,
                JobCount = c.JobCount,


            }).ToListAsync());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Create(CreateCategoryVM CreateVM)
        {
           if (CreateVM.IconFile == null) 
            {
                ModelState.AddModelError("IconFile", "The Icon file is required");
            }
            if (!ModelState.IsValid)
            {
                return View(CreateVM);
            }

            string NewFileName= DateTime.Now.ToString("yyyyMMddHHmmssfff");
            NewFileName += Path.GetExtension(CreateVM.IconFile!.FileName);

            string IconFullPath=Environment.WebRootPath + "/category/"+ NewFileName;
            using (var stream=System.IO.File.Create(IconFullPath))
            {
                CreateVM.IconFile.CopyTo(stream);
            }
            Category category = new Category()
            {
                Icon = NewFileName,
                Name = NewFileName,
                
            };
            _context.Categories.Add(category);
            _context.SaveChanges();


            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? Id)
        {
            if (Id==null)
            {
                return NotFound();
            }
            var category = await _context.Categories.FindAsync(Id);    
            if (category == null)
            {
                return BadRequest();
            }
            //EditCategoryVM EditVM = new EditCategoryVM()
            //{
            //    Name = category.Name,
            //    IconFile = category.IconFile

            //};

            return View();
        }


    }
}