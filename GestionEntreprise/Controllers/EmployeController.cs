using GestionEntreprise.BackConfig.Context;
using GestionEntreprise.BackConfig.UnitofWork;
using GestionEntreprise.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionEntreprise.Controllers
{
    public class EmployeController : Controller
    {
        public IActionResult Index() {

            UnitofWork unitOfwork = new UnitofWork(EntrepriseDbContext.Instance);
            IEnumerable<Employé> Employes = unitOfwork.employe.GetAll();
            return View(Employes);


        }

        public IActionResult Create() {

            UnitofWork unitOfwork = new UnitofWork(EntrepriseDbContext.Instance);
            IEnumerable<Secteur> Secteurs = unitOfwork.secteur.GetAll();
            ViewBag.listeSecteurs = Secteurs;
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employé model)
        {
            UnitofWork unitOfwork = new UnitofWork(EntrepriseDbContext.Instance);
            if (ModelState.IsValid)
            {
                UnitofWork unitOfwork1 = new UnitofWork(EntrepriseDbContext.Instance);
                Secteur secteur=unitOfwork.secteur.GetById(Convert.ToInt32(model.NomSecteur));
                model.NomSecteur = secteur.SecteurName;
                unitOfwork1.employe.Add(model);
                unitOfwork1.Complete();
                return RedirectToAction("Index");
            }
            
            IEnumerable<Secteur> Secteurs = unitOfwork.secteur.GetAll();
            ViewBag.listeSecteurs = Secteurs;
            return View();
        }

        public IActionResult Edit(int id) {

            UnitofWork unitOfwork = new UnitofWork(EntrepriseDbContext.Instance);
            IEnumerable<Secteur> Secteurs = unitOfwork.secteur.GetAll();
            ViewBag.listeSecteurs = Secteurs;
            Employé  employé = unitOfwork.employe.GetById(id);
            return View("Create",employé);
        }

        [HttpPost]
        public IActionResult Edit(int id,Employé model) {
            if(ModelState.IsValid)
            {
                UnitofWork unitOfwork1 = new UnitofWork(EntrepriseDbContext.Instance);
                unitOfwork1.employe.Update(id,model);
                unitOfwork1.Complete();
                return RedirectToAction(nameof(Index));

            }
            UnitofWork unitOfwork = new UnitofWork(EntrepriseDbContext.Instance);
            IEnumerable<Secteur> Secteurs = unitOfwork.secteur.GetAll();
            ViewBag.listeSecteurs = Secteurs;
            return View(model);
        }

        public IActionResult Delete(int id)
        {
            UnitofWork unitOfwork = new UnitofWork(EntrepriseDbContext.Instance);
            Employé employé = unitOfwork.employe.GetById(id);
            unitOfwork.employe.Remove(employé);
            unitOfwork.Complete();
            return RedirectToAction("Index");
        }
    }
}
