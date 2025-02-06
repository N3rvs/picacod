using Backend.DTOs;

namespace Backend.Services
{
    public interface IBeerServices
    {
        Task<IEnumerable<BeerDto>> Get();
        Task<BeerDto> GetById(int id);
        Task<BeerDto> Add(BeerDto beerInsertDto);
        Task <BeerDto> Update(int id,BeerDto beerUpdateDto);
        Task<BeerDto> Delete(int id);

    }
}
