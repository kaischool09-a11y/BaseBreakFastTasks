using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BreakFastTasks.EventExercise
{
	internal class WaterHeater
	{
		private double currentTemperature;
		public string Location { get; set; }
        public string TempInFahrenheit
		{
			get
			{
				return ((currentTemperature * 9 / 5) + 32).ToString("F2") + " °F";
			}
		}
		public event EventHandler<TempertureEventArgs> OnTemperatureChange;
		public event EventHandler TargetReached;

		public async Task StartBoilerAsync(double temperature)
		{

			while (currentTemperature<temperature)
			{
				Thread.Sleep(150);
				currentTemperature += 0.5;
				OnTemperatureChange?.Invoke(this, new TempertureEventArgs(currentTemperature));
				//if (OnTemperatureChange != null)
				//{
				//	OnTemperatureChange(this, new TempertureEventArgs(currentTemperature));
				//}

			}
			if (TargetReached!=null)
			{
				TargetReached(this, new EventArgs());
			}
		


		}
		public async Task<double> CalculateHeatingCostAsync()
		{
            Task.Delay(30);
			Random rnd = new Random();
			int num = rnd.Next(2, 21);
			return num + this.currentTemperature * 0.18;

        }


    }




	
}
