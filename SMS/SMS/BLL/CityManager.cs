using System.Data;
using SMS.DAL;

namespace SMS.BLL
{
    public class CityManager
    {
        CityRepository _cityRepository= new CityRepository();

        public DataTable GetCityBindingDataSource()
        {
            DataTable dt = _cityRepository.GetCityBindingDataSource();
            return dt;
        }


    }
}