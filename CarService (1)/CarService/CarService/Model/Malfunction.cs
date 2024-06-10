using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Model {
    /// <summary>
    /// Неисправность
    /// </summary>
    public class Malfunction {

        /// <summary>
        /// Создает объект описывающий неисправность автомобиля
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="carModel">Модель автомобиля</param>
        /// <param name="name">Название</param>
        /// <param name="price">Стоимость ремонта</param>
        /// <param name="repairTime">Продолжительность ремонта</param>
        public Malfunction(Guid id, string carModel, string name, decimal price, TimeSpan repairTime) {
            Id = id;
            CarModel = carModel;
            Name = name;
            Price = price;
            RepairTime = repairTime;
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Модель автомобиля
        /// </summary>
        public string CarModel { get; private set; }

        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Стоимость ремонта
        /// </summary>
        public decimal Price { get; private set; }

        /// <summary>
        /// Продолжительность ремонта
        /// </summary>
        public TimeSpan RepairTime { get; private set; }

        /// <summary>
        /// Переопределяем метод базового класса, для правильного отображения данных в таблице.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return $"{CarModel}: {Name} {Price} {RepairTime}";
        }
    }
}
