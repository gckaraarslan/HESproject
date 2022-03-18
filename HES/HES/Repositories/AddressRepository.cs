using HES;
using Microsoft.EntityFrameworkCore;
public class AddressRepository : IAddressRepository
{
    private readonly HESContext _context;
    public AddressRepository(HESContext context)
    {
        _context = context;
    }
    public AddressRepository()
    {

    }
    public async Task<City> CreateCity(City city)
    {
       try{
           await _context.Set<City>().AddAsync(city);
           await _context.SaveChangesAsync();
           return city;
           
       }
       catch(Exception e)
       {
           return null;
       }
    }

    public async Task<District> CreateDistrict(District district)
    {
        try{
           await _context.Set<District>().AddAsync(district);
           await _context.SaveChangesAsync();
           return district;
           
       }
       catch(Exception e)
       {
           return null;
       }
    }

    public async Task<Address> DeleteAddress(int id)
    {
        var findedAddress= await _context.Addresses.FindAsync(id);
         _context.Remove(findedAddress);
         _context.SaveChanges();
        return findedAddress;
    }

    public async Task<City> DeleteCity(City city)
    {
        var findedCity= await _context.Set<City>().FindAsync(city);
         _context.Remove(findedCity);
         _context.SaveChanges();
         return findedCity;
    }

    public async Task<District> DeleteDistrict(District district)
    {
var findedDistrict= await _context.Set<District>().FindAsync(district);
         _context.Remove(findedDistrict);
         _context.SaveChanges();
         return findedDistrict;    }

    public async Task<City> FindCityByName(string cityName)
    {
    return await _context.Set<City>().FindAsync(cityName);
    }

    public async Task<District> FindDistrictByName(string districtName)
    {
        return await _context.Set<District>().FindAsync(districtName);
    }

    public async Task<Address> GetAddressByID(int id)
    {
        return  await _context.Addresses.FindAsync(id);
    }

    public async Task<List<Address>> GetAllAddress()
    {
        return await _context.Addresses.ToListAsync();
        }

    public Task<List<District>> GetAllDistrictsByCityId(int id) //city id diyor
    {
        throw new NotImplementedException();
    }

    public async Task<Address> RegisterAddress(Address address)
    {
        try
        {
            await _context.Set<Address>().AddAsync(address);
            await _context.SaveChangesAsync();
            return address;
        }
        catch (Exception e)
        {
            return null;

        }
    }

    public async Task<Address> UpdateAddress(int id)
    {
        var findedAddress= await _context.Addresses.FindAsync(id);//address.id li yapmalıyız bence
         _context.Addresses.Update(findedAddress);
         _context.SaveChanges();
        return findedAddress;
    }
}