using _53_WEB_IdentityRole.Models;
using _53_WEB_IdentityRole.Models.VMs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _53_WEB_IdentityRole.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LogIn(LogInVM model)
        {
            AppUser appUser = await userManager.FindByNameAsync(model.Username);
            if (appUser!=null)
            {
                var result = await signInManager.PasswordSignInAsync(appUser, model.Password, true, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    return BadRequest();
                }
            }
            else
            {
                ModelState.AddModelError("Kullanıcı bulunamadı", "Lütfen kayıt olunuz");
            }
            return View();
        }


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
                    Email = model.Email,
                    PhoneNumber = model.PhoneNumber,
                    
                };
                var result = await userManager.CreateAsync(appUser, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description.ToString());
                    }
                }
            }
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }

        

        public IActionResult Listele()
        {
            var users = userManager.Users.Select(u => new AppUserListVM
            {
                Id = u.Id,
                UserName = u.UserName,
                Email = u.Email,
                PhoneNumber= u.PhoneNumber
            });
            return View(users);
        }

        public async Task<IActionResult> Edit(string id)
        {
            AppUser appUser= await userManager.FindByIdAsync(id);
            if (appUser != null)
            {
                var model = new EditUserVM();
                model.Id = appUser.Id;
                model.UserName = appUser.UserName;
                model.Email = appUser.Email;
                model.PhoneNumber = appUser.PhoneNumber;
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
                AppUser appUser = await userManager.FindByIdAsync(model.Id);
                if (appUser.UserName != model.UserName)
                {
                    appUser.UserName = model.UserName;
                }
                
                if (appUser.Email != model.Email)
                {
                    appUser.Email = model.Email;
                }
                if (appUser.PhoneNumber != model.PhoneNumber)
                {
                    appUser.PhoneNumber = model.PhoneNumber;
                }

                IdentityResult result = await userManager.UpdateAsync(appUser);
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

        public async Task<IActionResult> Details(string id)
        {
            var userRoleVM = new UserRoleVM()
            {
                User = id
            };
            userRoleVM.Roles = await roleManager.Roles.ToListAsync();
            return View(userRoleVM);
        }

        [HttpPost]
        public async Task<IActionResult> Details(UserRoleVM model)
        {
            AppUser appUser = await userManager.FindByIdAsync(model.User);
            var result =await userManager.AddToRoleAsync(appUser, model.Name);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest();
            }
        }


        public IActionResult RoleCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RoleCreate(IdentityRole model)
        {
            var role = new IdentityRole();
            role.Name = model.Name;
            var result = await roleManager.CreateAsync(model);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest();
            }
        }

        public IActionResult RoleList()
        {
            var roles = roleManager.Roles.Select(u => new RoleListVM
            {
                Id = u.Id,
                Name = u.Name,
                NormalizedName=u.NormalizedName
            });
            return View(roles);
        }

        public async Task<IActionResult> RoleUpdate(string id)
        {
            var role = await roleManager.FindByIdAsync(id);
            return View(role);
        }

        [HttpPost]
        public async Task<IActionResult> RoleUpdate(IdentityRole model)
        {
            //var role = new IdentityRole();
            //role.Name = model.Name;
            var result = await roleManager.UpdateAsync(model);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
