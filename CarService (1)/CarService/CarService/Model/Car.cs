using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Model {
    /// <summary>
    /// Автомобиль
    /// </summary>
    public class Car {

        /// <summary>
        /// Создание объекта представляющего автомобиль.
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="model">Модель автомобиля</param>
        /// <param name="vinCode">VIN номер автомобиля</param>
        public Car(Guid id, string model, string vinCode) {
            Id = id;
            Model = model;
            VinCode = vinCode;
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Модель автомобиля
        /// </summary>
        public string Model { get; private set; }

        /// <summary>
        /// VIN номер автомобиля
        /// </summary>
        public string VinCode { get; private set; }

        /// <summary>
        /// Переопределяем метод базового класса, для правильного отображения данных в таблице.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return $"{Model}: {VinCode}";
        }
    }
}
