namespace OCineplex.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CloudinaryDotNet;
    using CloudinaryDotNet.Actions;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using OCineplex.Data.Common.Repositories;
    using OCineplex.Data.Models;
    using OCineplex.Services;
    using OCineplex.Services.Data;
    using OCineplex.Web.ViewModels.Cinemas;

    public class CinemasController : Controller
    {
        private readonly ICinemasService cinemasService;
        private readonly ICloudinaryService cloudinaryService;

        public CinemasController(
            ICinemasService cinemasService,
            ICloudinaryService cloudinaryService)
        {
            this.cinemasService = cinemasService;
            this.cloudinaryService = cloudinaryService;
        }

        public ICinemasService CinemasService { get; }

        public IActionResult ById()
        {
            // TODO: read Cinema details
            return this.View();
        }

        [Authorize]
        public IActionResult Create()
        {
            return this.View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Create(CinemaCreateInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(input);
            }

            string pictureUrl = await this.cloudinaryService.UploadPictureAsync(input.Picture, input.Picture.FileName);

            var cinemaId = await this.cinemasService.CreateAsync(input.Name, input.Address, pictureUrl);

            return this.RedirectToAction("ById", new { id = cinemaId });
        }
    }
}
