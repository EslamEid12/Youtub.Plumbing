﻿using EntityLayer.WebApplication.Entities;
using EntityLayer.WebApplication.ViewModels.Contact;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Filters.WebApplication;
using ServiceLayer.Services.WebApplication.Abstract;

namespace YouTube.Plumbing.Areas.Admin.Controllers
{
    [Authorize(Policy = "AdminObserver")]
    [Area("Admin")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IValidator<ContactAddVM> _addValidator;
        private readonly IValidator<ContactUpdateVM> _updateValidator;

        public ContactController(IContactService contactService, IValidator<ContactAddVM> addValidatior, IValidator<ContactUpdateVM> updateValidator)
        {
            _contactService = contactService;
            _addValidator = addValidatior;
            _updateValidator = updateValidator;
        }

        public async Task<IActionResult> GetContactList()
        {
            var contactList = await _contactService.GetAllListAsync();
            return View(contactList);
        }

        [ServiceFilter(typeof(GenericAddPreventationFilter<ContactUs>))]
        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddContact(ContactAddVM request)
        {
            var validation = await _addValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _contactService.AddContactAsync(request);
                return RedirectToAction("GetContactList", "Contact", new { Area = ("Admin") });
            }

            validation.AddToModelState(this.ModelState);
            return View();
        }
        [ServiceFilter(typeof(GenericNotFoundFilter<ContactUs>))]
        [HttpGet]
        public async Task<IActionResult> UpdateContact(int id)
        {
            var contact = await _contactService.GetContactById(id);
            return View(contact);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateContact(ContactUpdateVM request)
        {
            var validation = await _updateValidator.ValidateAsync(request);
            if (validation.IsValid)
            {
                await _contactService.UpdateContactAsync(request);
                return RedirectToAction("GetContactList", "Contact", new { Area = ("Admin") });
            }

            validation.AddToModelState(this.ModelState);
            return View();
        }

        [Authorize(Roles = "SuperAdmin")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            await _contactService.DeleteContactAsync(id);
            return RedirectToAction("GetContactList", "Contact", new { Area = ("Admin") });

        }
    }
}