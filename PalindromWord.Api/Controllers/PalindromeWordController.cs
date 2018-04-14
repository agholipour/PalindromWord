using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PalindromWord.Api.Dto;
using PalindromWord.Api.Infrastructure.Persistance;
using PalindromWord.Domain;
using PalindromWord.services.Controllers;
using System.Collections.Generic;

namespace PalindromWord.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/palindromes")]
    public class PalindromeWordController : BaseApiController
    {
        public PalindromeWordController(IUnitOfWork unitOfWork, IMapper mapper)
            : base(unitOfWork, mapper)
        {
        }

        [HttpGet]
        public IActionResult Palindromes()
        {
            var palindromeWords = UnitOfWork.PalindromeWordRepository
                .List();

            var result = Mapper.Map<List<PalindromeDtoForRead>>(palindromeWords);

            return Ok(result);
        }

        [HttpGet("{id}", Name = "GetPalindrome")]
        public IActionResult GetPalindromeById(int id)
        {

            var entity = UnitOfWork.PalindromeWordRepository.FindById(id);

            if (entity == null)
            {
                return NotFound();
            }
            var result = Mapper.Map<PalindromeDtoForRead>(entity);

            return Ok(result);
        }

        [HttpPost]
        public IActionResult Palindromes([FromBody] PalindromeDtoForCreate palindromDtoForCreate)
        {
            if (palindromDtoForCreate == null)
            {
                return BadRequest();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var word = Mapper.Map<PalindromeWord>(palindromDtoForCreate);
            if (!TryValidateModel(word))
            {
                return BadRequest(ModelState);
            }
            
            this.UnitOfWork.PalindromeWordRepository.Add(word);
            if (!UnitOfWork.Save())
            {
                return StatusCode(500, "A problem happened while handling your request.");
            }

            var ResultDto = Mapper.Map<PalindromeDtoForRead>(word);

            return CreatedAtRoute("GetPalindrome", new
            { id = ResultDto.Id }, ResultDto);
        }

      
    }
}