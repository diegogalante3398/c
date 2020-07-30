using System;

namespace ProvaQuestao03
{
    public class Televisao
    {
		private int canal = 12;
		private int volume = 10;

		public int Volume{ get { return volume; } }

		public int Canal { get { return canal; } }

		public void aumentarVolume() { volume++; }

		public void diminuitVolume() { volume--; }

		public void subirCanal() { canal++; }

		public void descerCanal() { canal--; }

		public void alterarCanal(int canal) { this.canal = canal; }

		public string consultar()
		{
			return "Canal: " + Canal + "\nVolume: " + Volume;
		}
	}
}
