using System.Collections.Generic;

public interface IAddressRepository
{

    Task<City> FindCityByName(string cityName);//galiba bunları hep class.property şeklinde yani City.Cityname gibi yapmamız daha doğru olacak
    Task<District> FindDistrictByName(string districtName);
    Task<List<Address>> GetAllAddress();
    Task<Address> GetAddressByID(int id);   //buraya parametre olarak profile verip, içeriye profile.ID falan dene
    Task<List<District>> GetAllDistrictsByCityId(int id);
    Task<Address> RegisterAddress(Address address);
    Task<Address> DeleteAddress(int id);
    Task<Address> UpdateAddress(int id);
    Task<City> CreateCity(City city);
    Task<District> CreateDistrict(District district);
    Task<City> DeleteCity(City city);
    Task<District> DeleteDistrict(District district);
}