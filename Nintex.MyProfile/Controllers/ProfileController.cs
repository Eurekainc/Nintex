using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using Nintex.MyProfile.Models;
using Nintex.MyProfile.Repository;
using Nintex.MyProfile.Data;

namespace Nintex.MyProfile.Controllers
{
    public class ProfileController : Controller
    {
        private IRepository<Person> _personRepository;
        private IRepository<PersonPermission> _personPermissionRepository;

        public ProfileController(
            IRepository<Person> personRepository,
            IRepository<PersonPermission> personPermissionRepository
            )
        {
            _personRepository = personRepository;
            _personPermissionRepository = personPermissionRepository;
        }

        // GET: Profile
        public async Task<ActionResult> Index()
        {
            var model = new ProfileViewModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangePassword(ChangePasswordModel model)
        {
            var person = _personRepository.GetById(model.ID);
            person.Password = model.NewPassword;
            _personRepository.Update(person);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> ChangeTimeZone(ChangeTimeZoneModel model)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> RequestPersonPermission(RequestPersonPermissionModel model)
        {
            return View();
        }

    }
}