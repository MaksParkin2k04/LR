using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using CarService.Model;

namespace CarService.Data {
    public class ApplicationData {

        private const string DATA_FILE_NAME = "data.json";

        public ApplicationData() {
            Malfunctions = new List<Malfunction>();
       //     Masters = new List<Master>();
            RepairOrders = new List<RepairOrder>();

            Initialize();
        }

        public List<Malfunction> Malfunctions { get; private set; }
   //     public List<Master> Masters { get; private set; }
        public List<RepairOrder> RepairOrders { get; private set; }

        /// <summary>
        /// Начальная инициализация учебных данных.
        /// </summary>
        private void Initialize() {
            // Добавляем мастеров
      //      Masters.Add(new Master(Guid.NewGuid(), "Тимофей", "Чичеров", "+7 (938) 956-35-96"));
       //     Masters.Add(new Master(Guid.NewGuid(), "Геннадий", "Лыков", "+7 (979) 851-25-96"));
       //     Masters.Add(new Master(Guid.NewGuid(), "Николай", "Шестаков", "+7 (950) 589-99-73"));

            // Добавляем возможные неисправности
            Malfunctions.Add(new Malfunction(Guid.NewGuid(), "ВАЗ", "Замена масла", 1000, new TimeSpan(1, 0, 0)));
            Malfunctions.Add(new Malfunction(Guid.NewGuid(), "ВАЗ", "Замена свечей", 700, new TimeSpan(0, 30, 0)));
            Malfunctions.Add(new Malfunction(Guid.NewGuid(), "ВАЗ", "Регулировка зажигания", 1500, new TimeSpan(1, 30, 0)));
            Malfunctions.Add(new Malfunction(Guid.NewGuid(), "ВАЗ", "Балансировка колес", 1200, new TimeSpan(0, 40, 0)));
            Malfunctions.Add(new Malfunction(Guid.NewGuid(), "ВАЗ", "Регулировка  развал схождение колес", 1600, new TimeSpan(1, 20, 0)));

            Malfunctions.Add(new Malfunction(Guid.NewGuid(), "Москвич", "Замена масла", 1100, new TimeSpan(1, 2, 0)));
            Malfunctions.Add(new Malfunction(Guid.NewGuid(), "Москвич", "Замена свечей", 900, new TimeSpan(0, 45, 0)));
            Malfunctions.Add(new Malfunction(Guid.NewGuid(), "Москвич", "Регулировка зажигания", 1700, new TimeSpan(1, 30, 0)));
            Malfunctions.Add(new Malfunction(Guid.NewGuid(), "Москвич", "Балансировка колес", 1200, new TimeSpan(0, 40, 0)));
            Malfunctions.Add(new Malfunction(Guid.NewGuid(), "Москвич", "Регулировка  развал схождение колес", 1600, new TimeSpan(1, 20, 0)));

            Malfunctions.Add(new Malfunction(Guid.NewGuid(), "Волга", "Замена масла", 1200, new TimeSpan(1, 30, 0)));
            Malfunctions.Add(new Malfunction(Guid.NewGuid(), "Волга", "Замена свечей", 1100, new TimeSpan(0, 45, 0)));
            Malfunctions.Add(new Malfunction(Guid.NewGuid(), "Волга", "Регулировка зажигания", 1500, new TimeSpan(1, 30, 0)));
            Malfunctions.Add(new Malfunction(Guid.NewGuid(), "Волга", "Балансировка колес", 1300, new TimeSpan(0, 45, 0)));
            Malfunctions.Add(new Malfunction(Guid.NewGuid(), "Волга", "Регулировка  развал схождение колес", 1600, new TimeSpan(1, 20, 0)));


            // Добавляем заказ
            RepairOrder repairOrder = new RepairOrder(
                Guid.NewGuid(),
                new Car(Guid.NewGuid(), "ВАЗ", "ВАЗ 2101 0000001"),
                new CarOwner(Guid.NewGuid(), "Егор", "Енютин", "+7 (910) 440-85-16"),
              //  Masters[0],
                [Malfunctions[0], Malfunctions[2], Malfunctions[4]],
                DateTime.Now
             );

            RepairOrders.Add(repairOrder);
        }
    }
}
