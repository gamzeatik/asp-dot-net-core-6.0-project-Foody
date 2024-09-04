using AutoMapper;
using Foody.BusinessLayer.Abstract;
using Foody.DtoLayer.Dtos.SliderDtos;
using Foody.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.Controllers
{
    public class SliderController : Controller
    {
        private readonly ISliderService _service;
        private readonly IMapper _mapper;

        public SliderController(ISliderService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public IActionResult SliderList()
        {
            var value = _service.TGetAll();
            return View(_mapper.Map<List<ResultSliderDto>>(value));
        }

        [HttpGet]
        public IActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSlider(CreateSliderDto request)
        {
            var value = _mapper.Map<Slider>(request);
            _service.TInsert(value);
            return RedirectToAction("SliderList");
        }

        public IActionResult DeleteSlider(int id)
        {
            _service.TDelete(id);
            return RedirectToAction("SliderList");
        }

        [HttpGet]
        public IActionResult UpdateSlider(int id)
        {
            var value = _service.TGetById(id);
            return View(_mapper.Map<GetByIdSliderDto>(value));
        }
        [HttpPost]
        public IActionResult UpdateSlider(UpdateSliderDto request)
        {
            var value = _mapper.Map<Slider>(request);
            _service.TUpdate(value);
            return RedirectToAction("SliderList");
        }
    }
}
