using RentACar.BusinessLayer.Dtos;
using RentACar.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.BusinessLayer.Abstract
{
    public interface ICarService : IGenericService<Car>
    {
        List<Car> TGetAll();

        List<Car> GetLast5Cars();
        List<Car> GetLast3Cars();

        public List<CategoryDto> GetCategoryCount();

    }
}
