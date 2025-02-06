using Backend.Data;
using Backend.DTOs;
using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Services
{
    public class BeerServices : IBeerServices
    {

        private StoreContext _storeContext;
       
    public  BeerServices(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }
        public async Task<IEnumerable<BeerDto>> Get() =>
          await _storeContext.Beers.Select(b => new BeerDto
          {
              Id = b.BeerID,
              Name = b.Name,
              Alcohol = b.Alcohol,
              BrandID = b.BrandID
          }).ToListAsync();


        public async Task<BeerDto> GetById(int id)
        {
            var beer = await _storeContext.Beers.FindAsync(id);
            if(beer != null)
            {
                var beerDto = new BeerDto
                {
                    Id = beer.BeerID,
                    Name = beer.Name,
                    Alcohol = beer.Alcohol,
                    BrandID = beer.BrandID
                };
                return beerDto;
            }
            return null;
        }

        public async Task<BeerDto> Add(BeerDto beerInsertDto)
        {
            throw new NotImplementedException();
        }
        public async Task<BeerDto> Update(int id, BeerDto beerUpdateDto)
        {
            throw new NotImplementedException();
        }

        public async Task<BeerDto> Delete(int id)
        {
            throw new NotImplementedException();
        }

    }
}
