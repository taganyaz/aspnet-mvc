using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SocialAssistanceProgram.Core.Application.DTOs;
using SocialAssistanceProgram.Core.Application.Interfaces;
using SocialAssistanceProgram.Core.Domain.Models;
using SocialAssistanceProgram.Infrastructure.Data;
using SocialAssistanceProgram.ViewModels;

namespace SocialAssistanceProgram.Controllers
{
    public class ApplicantsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IApplicantService _applicantService;
        private  readonly IMapper _mapper;

        public ApplicantsController(ApplicationDbContext context, IApplicantService applicantService, IMapper mapper)
        {
            _context = context;
            _applicantService = applicantService;
            _mapper = mapper;
        }

        // GET: Applicants
        public async Task<IActionResult> Index()
        {
            var applicants = await _applicantService.GetAllApplicantsAsync();
            return View(applicants);
        }

        // GET: Applicants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicant = await _applicantService.GetApplicantByIdAsync(id.Value);
            if (applicant == null)
            {
                return NotFound();
            }

            return View(applicant);
        }

        // GET: Applicants/Create
        public IActionResult Create()
        {
            PopulateDropDowns(default(ApplicantDto));
            return View();
        }

        // POST: Applicants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateApplicantViewModel viewModel)
        {
            var applicantDto = _mapper.Map<ApplicantDto>(viewModel);
            if (ModelState.IsValid)
            {
                await _applicantService.AddApplicantAsync(applicantDto);
                return RedirectToAction(nameof(Index));
            }

            PopulateDropDowns(applicantDto);
            return View(viewModel);
        }

        // GET: Applicants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicant = await _applicantService.GetApplicantByIdAsync(id.Value);
            if (applicant == null)
            {
                return NotFound();
            }
            PopulateDropDowns(applicant);
            return View(_mapper.Map<EditApplicantViewModel>(applicant));
        }

        // POST: Applicants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditApplicantViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return NotFound();
            }

            var applicantDto = _mapper.Map<ApplicantDto>(viewModel);
            if (ModelState.IsValid)
            {
                try
                {
                    await _applicantService.UpdateApplicantAsync(applicantDto);
                }
                catch (ArgumentException ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
                return RedirectToAction(nameof(Index));
            }
            PopulateDropDowns(applicantDto);
            return View(viewModel);
        }

        // GET: Applicants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var applicant = await _applicantService.GetApplicantByIdAsync(id.Value);
            if (applicant == null)
            {
                return NotFound();
            }

            return View(applicant);
        }

        // POST: Applicants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _applicantService.DeleteApplicantAsync(id);
            return RedirectToAction(nameof(Index));
        }

        // AJAX endpoints for cascading dropdowns
        [HttpGet]
        public async Task<IActionResult> GetSubCounties(int countyId)
        {
            var subCounties = await _context.Set<SubCounty>()
                .Where(sc => sc.CountyId == countyId)
                .Select(sc => new { value = sc.Id, text = sc.Name })
                .ToListAsync();

            return Json(subCounties);
        }

        [HttpGet]
        public async Task<IActionResult> GetLocations(int subCountyId)
        {
            var locations = await _context.Set<Location>()
                .Where(l => l.SubCountyId == subCountyId)
                .Select(l => new { value = l.Id, text = l.Name })
                .ToListAsync();

            return Json(locations);
        }

        [HttpGet]
        public async Task<IActionResult> GetSubLocations(int locationId)
        {
            var subLocations = await _context.Set<SubLocation>()
                .Where(sl => sl.LocationId == locationId)
                .Select(sl => new { value = sl.Id, text = sl.Name })
                .ToListAsync();

            return Json(subLocations);
        }

        [HttpGet]
        public async Task<IActionResult> GetVillages(int subLocationId)
        {
            var villages = await _context.Set<Village>()
                .Where(v => v.SubLocationId == subLocationId)
                .Select(v => new { value = v.Id, text = v.Name })
                .ToListAsync();

            return Json(villages);
        }

        private void PopulateDropDowns(ApplicantDto? applicant)
        {
            ViewData["GenderId"] = new SelectList(_context.Set<Gender>(), "Id", "Name", applicant?.GenderId);
            ViewData["MaritalStatusId"] = new SelectList(_context.Set<MaritalStatus>(), "Id", "Name", applicant?.MaritalStatusId);
            ViewData["OfficerId"] = new SelectList(_context.Set<Officer>(), "Id", "FullName", applicant?.OfficerId);
            ViewData["SocialProgramId"] = new SelectList(_context.Set<SocialProgram>(), "Id", "Name", applicant?.SocialProgramId);
            ViewData["VillageId"] = new SelectList(_context.Set<Village>(), "Id", "Name", applicant?.VillageId);

            ViewData["CountyId"] = new SelectList(_context.Set<County>(), "Id", "Name", applicant?.CountyId);
            ViewData["SubCountyId"] = new SelectList(Enumerable.Empty<SelectListItem>(), "Id", "Name", applicant?.SubCountyId);
            ViewData["LocationId"] = new SelectList(Enumerable.Empty<SelectListItem>(), "Id", "Name", applicant?.LocationId);
            ViewData["SubLocationId"] = new SelectList(Enumerable.Empty<SelectListItem>(), "Id", "Name", applicant?.SubLocationId);
            ViewData["VillageId"] = new SelectList(Enumerable.Empty<SelectListItem>(), "Id", "Name", applicant?.VillageId);
        }
    }
}
