using System;
using System.Collections.Generic;

namespace CarConsole
{
    public interface ICarService
    {
        ICar AddCar(IAddCar addCar);
        IEnumerable<ICar> GetCars();
        ICar GetCar(Guid guid);
        ICar UpdateCar(IUpdateCar updateCar, Guid guid);
        void DeleteCar(Guid guid);

    }
}
