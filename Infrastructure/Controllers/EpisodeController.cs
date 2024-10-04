using BackendAPI.Domain.Interfaces.UseCase;
using Microsoft.AspNetCore.Mvc;

namespace BackendAPI.Infrastructure.Controllers
{
    public class EpisodeController : ControllerBase
    {
        private readonly IEpisodeUseCase _episodeUseCase;

        public EpisodeController(IEpisodeUseCase episodeUseCase)
        {
            _episodeUseCase = episodeUseCase;
        }

        [HttpGet("/episodes")]
        public IActionResult GetEpisodes()
        {
            return Ok(_episodeUseCase.GetEpisodes());
        }
    }
}
