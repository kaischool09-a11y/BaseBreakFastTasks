using BreakFastTasks.EventExercise;
using CoreCollectionsAsync;
namespace BreakFastTasks

{


    internal class Program
    {
        static async Task Main(string[] args)
        {
            //SimpleBreakfast.MakeBreakfastDemo_1();
             await  SimpleBreakfast.MakeBreakFastDemo2();
            //  await SimpleBreakfast.MakeBreakFastDemo3();
            List<WaterHeater> heaters = new List<WaterHeater>();
            WaterHeater heater1 = new WaterHeater() { Location = "Living Room" };
            heaters.Add(heater1);
            WaterHeater heater2 = new WaterHeater() { Location = "Bedroom" };
            heaters.Add(heater2);
            WaterHeater heater3 = new WaterHeater() { Location = "Kitchen" };
            heaters.Add(heater3);
            DisplayUnit DisplayUnit = new DisplayUnit();
            AlarmSystem alarm= new AlarmSystem();
            foreach (var heater in heaters)
            {
                heater.OnTemperatureChange += DisplayUnit.DisplayTemp;
                heater.TargetReached += alarm.DisplayAlert;
            }
            List<Task> heatingTasks = new List<Task>();
            foreach (var heater in heaters)
            {
               
            }

            //         heater.OnTemperatureChange+=display.DisplayTemp;
            //       //  heater.StartBoiler(45);
            //         House h = new House();
            //         AlarmSystem alarm=new AlarmSystem();
            //         heater.TargetReached += alarm.DisplayAlert;
            //h.OnDoorOpened+=alarm.DisplayAlert;
            //         h.OpenDoor();
            //         heater.StartBoiler(5);










        }
    }
}