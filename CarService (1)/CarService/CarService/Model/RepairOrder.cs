using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarService.Model {
    public class RepairOrder {

        /// <summary>
        /// Заказ ремонта автомобиля
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="car">Автомобиль</param>
        /// <param name="carOwner">Владелец автомобиля</param>
        /// <param name="master">Мастер который будет выполнять ремонт</param>
        /// <param name="typeRepairs">Список неисправностей</param>
        /// <param name="startRepair">Время начала ремонта</param>
        public RepairOrder(Guid id, Car car, CarOwner carOwner, IEnumerable<Malfunction> typeRepairs, DateTime startRepair) {
            Id = id;
            Car = car;
            CarOwner = carOwner;
            Master = master;
            Repairs = typeRepairs != null ? new List<Malfunction>(typeRepairs) : new List<Malfunction>();
            StartRepair = startRepair;
        }

        public Guid Id { get; private set; }

        /// <summary>
        /// Владелец автомобиля
        /// </summary>
        public CarOwner CarOwner { get; private set; }

        /// <summary>
        /// Автомобиль
        /// </summary>
        public Car Car { get; private set; }

        /// <summary>
        /// Мастер который будет выполнять ремонт
        /// </summary>
        public Master Master { get; private set; }

        /// <summary>
        /// Список неисправностей
        /// </summary>
        public List<Malfunction> Repairs { get; private set; }

        /// <summary>
        /// Время начала ремонта
        /// </summary>
        public DateTime StartRepair { get; private set; }

        /// <summary>
        /// Время окончания ремонта
        /// </summary>
        public DateTime EndRepair {
            get {
                long repairTimeTicks = Repairs.Sum(o => o.RepairTime.Ticks);
                TimeSpan repairTime = TimeSpan.FromTicks(repairTimeTicks);
                return StartRepair.Add(repairTime);
            }
        }

        /// <summary>
        /// Возвращает общую стоимость ремонта
        /// </summary>
        public decimal Price {
            get {
                return Repairs.Sum(r => r.Price);
            }
        }

    }
}

