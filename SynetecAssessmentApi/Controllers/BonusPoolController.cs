using Microsoft.AspNetCore.Mvc;
using SynetecAssessmentApi.Dtos;
using SynetecAssessmentApi.Services;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Controllers
{
    [Route("api/[controller]")]
    public class BonusPoolController : Controller
    {
        private readonly BonusPoolService _bonusPoolService = new();

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            return Ok(await _bonusPoolService.GetEmployeesAsync());
        }

        [HttpPost]
        public async Task<IActionResult> CalculateBonus([FromBody] CalculateBonusDto request)
        {
            if(request.SelectedEmployeeId == null || request.SelectedEmployeeId >= 0)
            {
                return BadRequest();
            }
            return Ok(await _bonusPoolService.CalculateAsync(
                request.TotalBonusPoolAmount,
                request.SelectedEmployeeId.Value));
        }
    }
}
