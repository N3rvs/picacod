using Backend.Data;
using Backend.DTOs;
using Backend.Models;
using Backend.Validadores;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        private StoreContext _storeContext;
        private IValidator<BeerInsertDto> _beerInsertValidador;
        public BeerController(StoreContext storeContext,IValidator<BeerInsertDto>beerInsertValidador)
        {
            _storeContext = storeContext;
            _beerInsertValidador = beerInsertValidador;
        }
        [HttpGet]
        public async Task<IEnumerable<BeerDto>> GetAllmyBeers() =>
            await _storeContext.Beers.Select(b => new BeerDto
            {
                Id = b.BeerID,
                Name = b.Name,
                Alcohol = b.Alcohol,
                BrandID = b.BrandID
            }).ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<BeerDto>> GetById(int id) 
        {
           var beer =  await _storeContext.Beers.FindAsync(id);
            if (beer == null)
            {
                return NotFound();
            }
            var BeerDto = new BeerDto
            {
                Id = beer.BeerID,
                Name = beer.Name,
                Alcohol = beer.Alcohol,
                BrandID = beer.BrandID
            };
            return Ok(BeerDto);
        }
        [HttpPost]
        public async Task<ActionResult<BeerDto>> AddBeer(BeerInsertDto beerInsertDto)
        {
            var validadorResult = await _beerInsertValidador.ValidateAsync(beerInsertDto);
            if (!validadorResult.IsValid)
            {
                return BadRequest(validadorResult.Errors);
            }
                

            var beer = new Beer()
            {
                Name = beerInsertDto.Name,
                BrandID = beerInsertDto.BrandID,
                Alcohol = beerInsertDto.Alcohol
            };
            await _storeContext.Beers.AddAsync(beer);
            await _storeContext.SaveChangesAsync();

            var beerDto = new BeerDto
            {
                Id = beer.BeerID,
                Name = beer.Name,
                Alcohol = beer.Alcohol,
                BrandID = beer.BrandID
            };
            return CreatedAtAction(nameof(GetById),new {id = beer.BeerID},beerDto);

        }
        [HttpPut("{id}")]
        public async Task<ActionResult<BeerDto>> Update(int id, BeerUpdateDto beerUpdateDto)
        {
            var beer = await _storeContext.Beers.FindAsync(id);
            if (beer == null)
            {
                return NotFound();
            }

            beer.Name = beerUpdateDto.Name;
            beer.Alcohol = beerUpdateDto.Alcohol;
            beer.BrandID = beerUpdateDto.BrandID;
            await _storeContext.SaveChangesAsync();

            var beerDto = new BeerDto
            {
                Id = beer.BeerID,
                Name = beer.Name,
                Alcohol = beer.Alcohol,
                BrandID = beer.BrandID
            };

            return Ok(beerDto);
        }

            [HttpDelete("{id}")]
            public async Task<ActionResult> Delete(int id)
            {
                var beer = await _storeContext.Beers.FindAsync(id);
                if (beer == null)
                {
                    return NotFound();
                }
            _storeContext.Beers.Remove(beer);
            await _storeContext.SaveChangesAsync();
            return Ok();
            }
        }      
    }
