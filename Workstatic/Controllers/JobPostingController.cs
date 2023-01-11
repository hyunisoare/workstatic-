﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Workstatic.Data;
using Workstatic.Models;


namespace Workstatic.Controllers
{
    [Authorize]
    public class JobPostingController : Controller
    {
        private readonly ApplicationDbContext _context;
        public JobPostingController(ApplicationDbContext context)
        {
           _context = context; 
        }
        public IActionResult Index() 
        {

            if (User.IsInRole("Admin"))
            {
                var allPostings = _context.JobPostings.ToList();
                return View(allPostings);
            }

            var jobPostingsFromDb = _context.JobPostings.Where(x => x.OwnerUsername == User.Identity.Name).ToList();
            //benutzer Name x. Wenn der Nutzer Name von X (was für JobPosting steht)
            //der Benutzername ist, mit dem wir gerade eingeloggt sind   
            return View(jobPostingsFromDb);

        }
        
        public IActionResult CreateEditJobPosting(int id)
        {
            if (id != 0)
            {
                var jobPostingFromDb = _context.JobPostings.SingleOrDefault(x => x.Id == id);

                if ((jobPostingFromDb.OwnerUsername != User.Identity.Name) && !User.IsInRole("Admin"))
                {
                    return Unauthorized();
                }

                if (jobPostingFromDb != null)
                {
                    return View(jobPostingFromDb);
                }
                else
                {
                    return NotFound();
                }
            }
            return View();
        }

        public IActionResult CreateEditJob(JobPosting jobPosting, IFormFile file) 
        {
            jobPosting.OwnerUsername = User.Identity.Name;

            if (file != null)
            {
                using (var ms = new MemoryStream())
                {
                    file.CopyTo(ms);
                    var bytes = ms.ToArray();
                    jobPosting.CompanyImage = bytes;
                }
            }

            if (jobPosting.Id == 0)
            {
                // Add new job if it's not editing. 
                _context.JobPostings.Add(jobPosting);
            }
            else
            {
                var jobFromDb = _context.JobPostings.SingleOrDefault(x => x.Id == jobPosting.Id);

                if (jobFromDb == null)
                    return NotFound();
                

                jobFromDb.CompanyImage = jobPosting.CompanyImage;
                jobFromDb.CompanyName = (jobPosting.CompanyName == null) ? "Keinen Name vorhanden." : jobPosting.CompanyName;
                jobFromDb.ContactMail = (jobPosting.ContactMail == null) ? "Keine Email vorhanden." : jobPosting.ContactMail;
                jobFromDb.ContactPhone = (jobPosting.ContactPhone==null) ? "Keine Tel. vorhanden." : jobPosting.ContactPhone;
                jobFromDb.ContactWebsite = (jobPosting.ContactWebsite == null) ? "Keine Website vorhanden." : jobPosting.ContactWebsite;
                jobFromDb.Description = (jobPosting.Description == null) ? "Keine Description vorhanden." : jobPosting.Description;
                jobFromDb.JobLocation = (jobPosting.JobLocation == null) ? "Keine JobLocation vorhanden." : jobPosting.JobLocation;
                jobFromDb.JobTitle = (jobPosting.JobTitle == null) ? "Keinen JobTitle vorhanden." : jobPosting.JobTitle;
                jobFromDb.Salary = jobPosting.Salary;    
                jobFromDb.StartDate = jobPosting.StartDate;
                //jobFromDb.OwnerUsername = (jobPosting.OwnerUsername == null) ? "Keinen OwnerUsername vorhanden." : jobPosting.OwnerUsername;
            }

            _context.SaveChanges();

            // todo: write jobposting to db 
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteJobPostingById(int id)
        {
            if (id == 0)
                return BadRequest();

            var jobPostingFromDb = _context.JobPostings.SingleOrDefault(x => x.Id == id);

            if (jobPostingFromDb == null)
                return NotFound();

            _context.JobPostings.Remove(jobPostingFromDb);
            _context.SaveChanges();

            return Ok();
            
        }
    }

}
