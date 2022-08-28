using Core.Entity;
using Data;
using Manager.IService;
using Manager.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace KonusarakOgren.Controllers
{
    [Authorize]

    public class AdminController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IProductService productService;
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnv;

        public AdminController(ICategoryService categoryService, IProductService productService, Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnv)
        {
            this.categoryService = categoryService;
            this.productService = productService;
            this.hostingEnv = hostingEnv;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Product()
        {
            List<Product> Product = productService.GetAll().ToList();
            return View(Product);
        }
        public IActionResult Category()
        {
            List<Category> category = categoryService.GetAll().ToList();
            return View(category);
        }
        public IActionResult CategoryInsert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryInsert(Category category)
        {
            Category category1 = new Category()
            {
                Name = category.Name,
                URL = category.URL,
                Approval = "True",
                Rows = category.Rows,
                CreateDate = DateTime.Now,
                Status = true,
                UpdateDate = DateTime.Now
            };
            categoryService.Addservis(category1);
            return Json(new { success = "İşlem Başarılı", status = 401 });
        }
        public IActionResult ProductInsert()
        {
            List<Category> category = categoryService.GetAll().ToList();
            return View(category);
        }
        [HttpPost]
        public IActionResult ProductInsert(Product product)
        {
            string resimyol="";
            foreach (IFormFile file in Request.Form.Files)
            {

                if (file != null)
                {
                    string filename = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    filename = this.EnsureCorrectFilename(filename);
                    using (FileStream output = System.IO.File.Create(this.GetPathAndFilename(filename)))
                        file.CopyTo(output);
                    string imageUrl = this.GetPathAndFilename(filename);
                    resimyol = "/Content/" + filename;
                }
            }
            Product product1 = new Product()
            {
                CategoryId = product.CategoryId,
                Name = product.Name,
                URL = product.URL,
                Contents = "",
                discount = product.discount,
                Image = resimyol,
                ShortContent = product.ShortContent,
                Approval = "True",
                Rows = product.Rows,
                CreateDate = DateTime.Now,
                Status = true,
                UpdateDate = DateTime.Now
            };
            productService.Addservis(product1);

            return Json(new { success = "İşlem Başarılı", status = 401 });
        }
        [Route("/Admin/ProductUpdate/{id}")]
        public IActionResult ProductUpdate(int id)
        {
            Product products= productService.GetAll().Where(x=>x.Id==id).FirstOrDefault();
            List<Category> category = categoryService.GetAll().ToList();
            var model = (products, category);
            return View(model);
        }

        private string EnsureCorrectFilename(string filename)
        {
            if (filename.Contains("\\"))
                filename = filename.Substring(filename.LastIndexOf("\\") + 1);
            return filename;
        }

        private string GetPathAndFilename(string filename)
        {
            if (!Directory.Exists(hostingEnv.WebRootPath + "\\Content\\"))
            {
                Directory.CreateDirectory(hostingEnv.WebRootPath + "\\Content\\");
            }
            return hostingEnv.WebRootPath + "\\Content\\" + filename;
        }
        [Route("/Admin/ProductDelete/{id}")]
        public IActionResult ProductDelete(int id)
        {
            Product product1 = new Product()
            {
                Id = id
            };
            productService.Delete(product1);
            return View("");
        }

    }
}
