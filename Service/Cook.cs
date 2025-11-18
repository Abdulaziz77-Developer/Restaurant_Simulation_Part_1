using Restaurant_Simulation_Part_1.Models;
using System.Threading.Tasks;

namespace Restaurant_Simulation_Part_1.Service
{
    public class Cook
    {
        private static int _idCounter = 1;
        public int Id { get; private set; }

        public Cook()
        {
            Id = _idCounter++;
        }

        public async Task ProcessAsync(TableRequest table)
        {
            // Готовим курицу
            foreach (var chicken in table.Get<ChickenOrder>())
            {
                chicken.CutUp();
                chicken.Cook();
                await Task.Delay(1000); // имитация времени приготовления
            }

            // Готовим яйца
            foreach (var egg in table.Get<Egg>())
            {
                using (egg)
                {
                    egg.Crack();
                    egg.Cook();
                }
                await Task.Delay(500);
            }

            // Напитки не требуют обработки
        }
    }
}
