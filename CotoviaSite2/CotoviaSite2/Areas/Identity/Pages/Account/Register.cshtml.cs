using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using CotoviaSite2.Models;
using CotoviaSite2.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace CotoviaSite2.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _path;

        public RegisterModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            ApplicationDbContext context,
            IWebHostEnvironment path
            )
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
            _path = path;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "O E-mail é de preenchimento obrigatório")]
            [EmailAddress]
            [Display(Name = "Email")]
            [RegularExpression("[ar][0-9]{4}@cotovia.pt", ErrorMessage = "E-mail inválido.")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }

            public Utilizadores Utilizador { get; set; }

            public IFormFile Foto { get; set; }
 
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = Input.Email, Email = Input.Email, Nome = Input.Utilizador.Nome};
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    try
                    {
                        Guid g;
                        g = Guid.NewGuid();

                        string extension = Path.GetExtension(Input.Foto.FileName).ToLower();

                        string nameOfFile = "" + g.ToString() + extension;
                        if(Input.Email.Substring(0, 1) == "a")
                        {
                            await _userManager.AddToRoleAsync(user, "autor");
                        }
                        else
                        {
                            await _userManager.AddToRoleAsync(user, "revisor");
                        }


                        Utilizadores novoUtilizador = new Utilizadores
                        {
                            Nome = Input.Utilizador.Nome,
                            Email = Input.Email,
                            UserID = user.Id,
                            Cargo = Input.Utilizador.Cargo
                        
                        };

                        novoUtilizador.Foto = nameOfFile;
                        string whereToStoreTheFile = _path.WebRootPath;
                        nameOfFile = Path.Combine(whereToStoreTheFile, "fotos", nameOfFile);

                        using var stream = new FileStream(nameOfFile, FileMode.Create);
                        await Input.Foto.CopyToAsync(stream);

                        _context.Add(novoUtilizador);
                        await _context.SaveChangesAsync();
                    }
                    catch (Exception)
                    {
                        await _userManager.DeleteAsync(user);
                    }

                        if (_userManager.Options.SignIn.RequireConfirmedAccount)
                    {
                        return RedirectToPage("RegisterConfirmation", new { email = Input.Email, returnUrl = returnUrl });
                    }
                    else
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return LocalRedirect(returnUrl);
                    }
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
