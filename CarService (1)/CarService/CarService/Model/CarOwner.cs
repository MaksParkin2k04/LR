using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Model {
    /// <summary>
    /// Владелец автомобиля
    /// </summary>
    public class CarOwner {

        /// <summary>
        /// Создание объекта мастера по ремонту автомобиля.
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="firstName">Имя</param>
        /// <param name="lastName">Фамилия</param>
        /// <param name="phone">Номер телефона</param>
        public CarOwner(Guid id, string firstName, string lastName, string phone) {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
        }

        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; private set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; private set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public string Phone { get; private set; }

        /// <summary>
        /// Переопределяем метод базового класса, для правильного отображения данных в таблице.
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return $"{FirstName} {LastName} {Phone}";
        }
    }
}
