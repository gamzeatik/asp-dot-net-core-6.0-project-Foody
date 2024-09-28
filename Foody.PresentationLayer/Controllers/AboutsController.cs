using AutoMapper;
using Foody.BusinessLayer.Abstract;
using Foody.DtoLayer.Dtos.AboutDtos;
using Foody.DtoLayer.Dtos.SliderDtos;
using Foody.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class AboutsController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAboutService _service;

        public AboutsController(IAboutService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public IActionResult AboutList()
        {
            var values = _service.TGetAll();
            return View(_mapper.Map<List<ResultAboutDto>>(values));
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto request)
        {
            var value = _mapper.Map<About>(request);
            _service.TInsert(value);
            return RedirectToAction("AboutList");
        }
        public IActionResult DeleteAbout(int id)
        {
            _service.TDelete(id);
            return RedirectToAction("AboutList");
        }

        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = _service.TGetById(id);
            return View(_mapper.Map<GetByIdAboutDto>(value));
        }
        [HttpPost]
        public IActionResult UpdateAbout(UpdateAboutDto request)
        {
            var value = _mapper.Map<About>(request);
            _service.TUpdate(value);
            return RedirectToAction("AboutList");
        }
    }
}
