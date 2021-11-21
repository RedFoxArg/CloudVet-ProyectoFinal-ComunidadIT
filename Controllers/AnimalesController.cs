using CloudVet.Data;
using CloudVet.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudVet.Controllers
{
    public class AnimalesController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AnimalesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Animales.ToList());
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guardar(string nombre, string especie, string raza, string sexo, DateTime fechaNacimiento, short edad, string mesesAños, float peso)
        {
            Animal nuevoAnimal = new()
            {
                Nombre = nombre,
                Especie = especie,
                Raza = raza,
                Sexo = sexo,
                FechaNacimiento = fechaNacimiento,
                Edad = edad,
                MesesAños = mesesAños,
                Peso = peso
            };

            // Guardar en la BD
            try
            {
                _context.Animales.Add(nuevoAnimal);
                _context.SaveChanges();
            }
            catch
            {
                Console.WriteLine("¿Cómo validar en la Vista que ingrese todos los campos requeridos?");
            }

            // ¿Cómo lanzar ventana modal de confirmación?
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            Animal editar = BuscarPorID(id);
            if(editar == null)
            {
                return RedirectToAction("Index");
            }
            return View(editar);
        }

        public IActionResult Actualizar(int id, string nombre, string especie, string raza, string sexo, DateTime fechaNacimiento, DateTime fechaFalle, short edad, string mesesAños, float peso)
        {
            Animal actualizar = BuscarPorID(id);
            if (actualizar != null)
            {
                actualizar.Nombre = nombre;
                actualizar.Especie = especie;
                actualizar.Raza = raza;
                actualizar.Sexo = sexo;
                actualizar.FechaNacimiento = fechaNacimiento;
                if (actualizar.Archivado)
                {
                    actualizar.FechaFalle = fechaFalle;
                }
                actualizar.Edad = edad;
                actualizar.MesesAños = mesesAños;
                actualizar.Peso = peso;
            }
            // Actualizar en la BD
            _context.Animales.Update(actualizar);
            _context.SaveChanges();

            // ¿Cómo lanzar ventana modal de confirmación?
            return Direccionar(actualizar.ID);
        }

        public IActionResult Direccionar(int id)
        {
            Animal encontrado = BuscarPorID(id);
            if (encontrado != null && encontrado.Archivado)
            {
                return RedirectToAction("VerArchivados");
            }
            return RedirectToAction("Index");
        }

        public IActionResult Archivar(int id)
        {
            Animal animal = BuscarPorID(id);
            if (animal != null)
            {
                animal.Archivado = true;
            }
            // Actualizar en la BD
            _context.Animales.Update(animal);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Desarchivar(int id)
        {
            Animal animal = BuscarPorID(id);
            if (animal != null)
            {
                animal.Archivado = false;
            }
            // Actualizar en la BD
            _context.Animales.Update(animal);
            _context.SaveChanges();
            return RedirectToAction("VerArchivados");
        }

        public IActionResult VerArchivados()
        {
            return View(_context.Animales.ToList());
        }

        public IActionResult Eliminar(int id)
        {
            Animal animal = BuscarPorID(id);
            if (animal != null)
            {
                animal.Inactivo = true;
            }
            // Actualizar en la BD
            _context.Animales.Update(animal);
            _context.SaveChanges();
            return Direccionar(id);
        }

        private Animal BuscarPorID(int id)
        {
            Animal encontrado = _context.Animales.Find(id);
            
            return encontrado;
        }
    }
}
