using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IBD.MEDEM.Entities;

namespace IBD.MEDEM.WebMVC.Controllers
{
    public class GrupoController : Controller
    {
        // GET: Grupo
        public ActionResult Index()
        {
            var model = new List<ObtenerGrupos> {
                new ObtenerGrupos{
                    CapacidadKW = (decimal)32423.34,
                     Estatus = true,
                     EstatusClientes = true,
                     EstatusFases = "en captura",
                     EstatusPuntoCarga = true,
                     Fase = "Prospectos",
                     FechaCreacion = DateTime.Now,
                     Nombre = "Gp 1 test",
                     TotalClientes = 2,
                     TotalPuntoCarga = 5                     
                },
                new ObtenerGrupos{
                    CapacidadKW = (decimal)32423.34,
                     Estatus = true,
                     EstatusClientes = true,
                     EstatusFases = "enviado",
                     EstatusPuntoCarga = true,
                     Fase = "Prospectos",
                     FechaCreacion = DateTime.Now,
                     Nombre = "Gp 2 test",
                     TotalClientes = 4,
                     TotalPuntoCarga = 13
                },
                new ObtenerGrupos{
                    CapacidadKW = (decimal)32423.34,
                     Estatus = true,
                     EstatusClientes = true,
                     EstatusFases = "rechazado",
                     EstatusPuntoCarga = true,
                     Fase = "Prospectos",
                     FechaCreacion = DateTime.Now,
                     Nombre = "Gp 3 test",
                     TotalClientes = 12,
                     TotalPuntoCarga = 37
                }
            };


            Session["CatalogoGiros"] = new List<TiposGiros> {
                 new TiposGiros{
                    IdTipoGiro = 0,
                    Descripcion = "Seleccione Giro"
                },
                new TiposGiros{
                    IdTipoGiro = 1,
                    Descripcion = "Industriales"
                },
                 new TiposGiros{
                    IdTipoGiro = 2,
                    Descripcion = "Extractivas"
                },
                  new TiposGiros{
                    IdTipoGiro = 3,
                    Descripcion = "Manufactureras"
                },
                   new TiposGiros{
                    IdTipoGiro = 4,
                    Descripcion = "Agropecuaria"
                },
                    new TiposGiros{
                    IdTipoGiro = 5,
                    Descripcion = "Comerciales"
                },
                     new TiposGiros{
                    IdTipoGiro = 6,
                    Descripcion = "Mayoristas"
                },
                      new TiposGiros{
                    IdTipoGiro = 7,
                    Descripcion = "Minoristas"
                },
                       new TiposGiros{
                    IdTipoGiro = 8,
                    Descripcion = "Comisionistas"
                },
                        new TiposGiros{
                    IdTipoGiro = 9,
                    Descripcion = "Transporte"
                },
                         new TiposGiros{
                    IdTipoGiro = 10,
                    Descripcion = "Turismo"
                },
                new TiposGiros{
                    IdTipoGiro = 11,
                    Descripcion = "Instituciones Financieras"
                },
                new TiposGiros{
                    IdTipoGiro = 12,
                    Descripcion = "Servicios Públicos"
                },
                new TiposGiros{
                    IdTipoGiro = 13,
                    Descripcion = "Servicios Profesionales"
                },
                new TiposGiros{
                    IdTipoGiro = 14,
                    Descripcion = "Educación"
                },
                new TiposGiros{
                    IdTipoGiro = 15,
                    Descripcion = "Salud"
                },
                new TiposGiros{
                    IdTipoGiro = 16,
                    Descripcion = "Comunicación"
                }
            };


            return View(model);
        }

        // GET: Grupo/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Grupo/Create
        public ActionResult Create()
        {
          
            var model = new IBD.MEDEM.Entities.Grupos {
                Contactos = new List<Contactos> { new Contactos { IdGrupo = 0} }
            };

            ViewBag.CatalogoGiros =  (List<TiposGiros>)Session["CatalogoGiros"];

            return PartialView("Create",model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ActionName()
        {
            var model = new List<ObtenerGrupos> {
                new ObtenerGrupos{
                    CapacidadKW = (decimal)32423.34,
                     Estatus = true,
                     EstatusClientes = true,
                     EstatusFases = "en captura",
                     EstatusPuntoCarga = true,
                     Fase = "Prospectos",
                     FechaCreacion = DateTime.Now,
                     Nombre = "Gp 1 test",
                     TotalClientes = 2,
                     TotalPuntoCarga = 5
                },
                new ObtenerGrupos{
                    CapacidadKW = (decimal)32423.34,
                     Estatus = true,
                     EstatusClientes = true,
                     EstatusFases = "enviado",
                     EstatusPuntoCarga = true,
                     Fase = "Prospectos",
                     FechaCreacion = DateTime.Now,
                     Nombre = "Gp 2 test",
                     TotalClientes = 4,
                     TotalPuntoCarga = 13
                },
                new ObtenerGrupos{
                    CapacidadKW = (decimal)32423.34,
                     Estatus = true,
                     EstatusClientes = true,
                     EstatusFases = "rechazado",
                     EstatusPuntoCarga = true,
                     Fase = "Prospectos",
                     FechaCreacion = DateTime.Now,
                     Nombre = "Gp 3 test",
                     TotalClientes = 12,
                     TotalPuntoCarga = 37
                }
            };


            Session["CatalogoGiros"] = new List<TiposGiros> {
                 new TiposGiros{
                    IdTipoGiro = 0,
                    Descripcion = "Seleccione Giro"
                },
                new TiposGiros{
                    IdTipoGiro = 1,
                    Descripcion = "Industriales"
                },
                 new TiposGiros{
                    IdTipoGiro = 2,
                    Descripcion = "Extractivas"
                },
                  new TiposGiros{
                    IdTipoGiro = 3,
                    Descripcion = "Manufactureras"
                },
                   new TiposGiros{
                    IdTipoGiro = 4,
                    Descripcion = "Agropecuaria"
                },
                    new TiposGiros{
                    IdTipoGiro = 5,
                    Descripcion = "Comerciales"
                },
                     new TiposGiros{
                    IdTipoGiro = 6,
                    Descripcion = "Mayoristas"
                },
                      new TiposGiros{
                    IdTipoGiro = 7,
                    Descripcion = "Minoristas"
                },
                       new TiposGiros{
                    IdTipoGiro = 8,
                    Descripcion = "Comisionistas"
                },
                        new TiposGiros{
                    IdTipoGiro = 9,
                    Descripcion = "Transporte"
                },
                         new TiposGiros{
                    IdTipoGiro = 10,
                    Descripcion = "Turismo"
                },
                new TiposGiros{
                    IdTipoGiro = 11,
                    Descripcion = "Instituciones Financieras"
                },
                new TiposGiros{
                    IdTipoGiro = 12,
                    Descripcion = "Servicios Públicos"
                },
                new TiposGiros{
                    IdTipoGiro = 13,
                    Descripcion = "Servicios Profesionales"
                },
                new TiposGiros{
                    IdTipoGiro = 14,
                    Descripcion = "Educación"
                },
                new TiposGiros{
                    IdTipoGiro = 15,
                    Descripcion = "Salud"
                },
                new TiposGiros{
                    IdTipoGiro = 16,
                    Descripcion = "Comunicación"
                }
            };


            //return new ContentResult() { Content = "Recepción satisfactoria" };
            return PartialView("Index",model);
        }

        // POST: Grupo/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Grupo/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Grupo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Grupo/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Grupo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
