using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab11.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab11.Pages
{
    public class ProfessorModel : PageModel
    {
        private readonly LabDbContext _context;
        public List<Professor> Professors {get; set;}
        public SelectList ProfessorDropDown {get; set;}

        public ProfessorModel(LabDbContext context)
        {
            _context = context;
        }
        
        public void OnPost()
        {
            var professors = _context.Professor.Include(c => c.Courses).Select(p => p);
            Professors = _context.Professor.ToList();
            ProfessorDropDown = new SelectList(Professors, "ProfessorID", "FirstName", 2);
        }

        public void OnGet()
        {
            var professors = _context.Professor.Include(c => c.Courses).Select(p => p);
            Professors = _context.Professor.ToList();
            ProfessorDropDown = new SelectList(Professors, "ProfessorID", "FirstName", 2);
        }
    }
}