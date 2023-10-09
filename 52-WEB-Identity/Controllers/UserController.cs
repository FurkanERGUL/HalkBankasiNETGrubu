using _52_WEB_Identity.Models;
using _52_WEB_Identity.Models.VMs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace _52_WEB_Identity.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public UserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            var users=_userManager.Users.Select(u => new ListUserVM
            {
                Id = u.Id,
                UserName = u.UserName,
                Email = u.Email,
                FirstName = u.FirstName,
                LastName = u.LastName,
            });
            return View(users);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegisterUserVM model)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = new AppUser()
                {
                    UserName = model.UserName,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    PhoneNumber = model.Phone
                };
                var result = await _userManager.CreateAsync(appUser, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty,error.Description.ToString());
                    }
                }
            }
            return View(model);
            
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            AppUser appUser = await _userManager.FindByIdAsync(id);
            if (appUser!=null)
            {
                EditUserVM model = new EditUserVM();
                model.Id=appUser.Id;
                model.UserName = appUser.UserName;
                model.FirstName = appUser.FirstName;
                model.LastName = appUser.LastName;
                model.Email = appUser.Email;
                model.Phone = appUser.PhoneNumber;
                return View(model);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditUserVM model)
        {
            if (ModelState.IsValid)
            {
                AppUser appUser = await _userManager.FindByIdAsync(model.Id);
                if (appUser.UserName!=model.UserName)
                {
                    appUser.UserName = model.UserName;
                }
                if (appUser.FirstName != model.FirstName)
                {
                    appUser.FirstName = model.FirstName;
                }
                if (appUser.LastName != model.LastName)
                {
                    appUser.LastName = model.LastName;
                }
                if (appUser.Email != model.Email)
                {
                    appUser.Email = model.Email;
                }
                if (appUser.PhoneNumber != model.Phone)
                {
                    appUser.PhoneNumber = model.Phone;
                }

                IdentityResult result = await _userManager.UpdateAsync(appUser);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return BadRequest();
                }
            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Delete (string id)
        {
            var user =await _userManager.FindByIdAsync(id);
            IdentityResult result = await _userManager.DeleteAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest();
            }
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            AppUser appUser = await _userManager.FindByNameAsync(model.UserName);
            if (appUser!=null)
            {
                var result = await _signInManager.PasswordSignInAsync(appUser, model.Password, true, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Deneme","Home");
                }
                else if(result.IsLockedOut)
                {
                    //Hesap kilitlendiğinde
                }
                else
                {
                    ModelState.AddModelError("Hatalı giriş", "Lütfen doğru şifre giriniz");
                }
            }
            else
            {
                ModelState.AddModelError("Kullanıcı bulunamadı", "Lütfen kayıt olunuz");
            }
            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }
    }
}
