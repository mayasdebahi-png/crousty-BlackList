using Microsoft.AspNetCore.Mvc;
using CroustyClickCollect.Data;
using CroustyClickCollect.Services;

namespace CroustyClickCollect.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly IHorairesService _horairesService;

        public RestaurantsController(
            IRestaurantRepository restaurantRepository,
            IHorairesService horairesService)
        {
            _restaurantRepository = restaurantRepository;
            _horairesService = horairesService;
        }

        // GET: /Restaurants
        public IActionResult Index()
        {
            // S2-01 : récupérer tous les restaurants, triés par nom
            var restaurants = _restaurantRepository.GetAll();

            var maintenant = DateTime.Now;

            // S2-04 : indiquer pour chaque restaurant s'il est ouvert en ce moment
            var viewModel = restaurants.Select(r => new RestaurantViewModel
            {
                Restaurant = r,
                EstOuvert = _horairesService.EstOuvert(r, maintenant)
            }).ToList();

            return View(viewModel);
        }
    }
}