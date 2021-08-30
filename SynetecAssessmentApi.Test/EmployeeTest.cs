using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using SynetecAssessmentApi.Controllers;
using SynetecAssessmentApi.Dtos;
using SynetecAssessmentApi.Services;
using System.Threading.Tasks;

namespace SynetecAssessmentApi.Test
{
    public class EmployeeTest
    {
        private readonly BonusPoolController _bonusPoolController = new();

        [Test]
        public void CalculateEmployeeBonusTest()
        {
            var totalBonus = new CalculateBonusDto { TotalBonusPoolAmount = 10000, SelectedEmployeeId = 1 };
            var result = _bonusPoolController.CalculateBonus(totalBonus);
            Assert.IsInstanceOf<Task<IActionResult>>(result);
        }


    }
}