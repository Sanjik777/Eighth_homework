using static System.Console;

namespace Workbench
{
	public class Craft
	{
		public void Crafting(int[,] data, int wood, int stone, int iron, int stick)
		{
			SetCursorPosition(1, 23);
			//топор
			if (data[0, 0] == wood  && data[0, 1] == wood && data[1, 0] == wood
		   	 && data[1, 1] == stick && data[2, 1] == stick)
			{
				WriteLine("Собрана деревянная топор!\t");
			}
			else if (data[0, 0] == stone && data[0, 1] == stone && data[1, 0] == stone
			      && data[1, 1] == stick && data[2, 1] == stick)
			{
				WriteLine("Собрана каменная топор!\t");
			}
			else if (data[0, 0] == iron  && data[0, 1] == iron && data[1, 0] == iron
			      && data[1, 1] == stick && data[2, 1] == stick)
			{
				WriteLine("Собрана железная топор!\t");
			}
			//кирка
			else if (data[0, 0] == wood  && data[0, 1] == wood && data[0, 2] == wood
				  && data[1, 1] == stick && data[2, 1] == stick)
			{
				WriteLine("Собрана деревянная кирка!\t");
			}
			else if (data[0, 0] == stone && data[0, 1] == stone && data[0, 2] == stone
			      && data[1, 1] == stick && data[2, 1] == stick)
			{
				WriteLine("Собрана каменная кирка!\t");
			}
			else if (data[0, 0] == iron  && data[0, 1] == iron && data[0, 2] == iron
			      && data[1, 1] == stick && data[2, 1] == stick)
			{
				WriteLine("Собрана железная кирка!\t");
			}
			//лопата
			else if (data[0, 1] == wood
				  && data[1, 1] == stick && data[2, 1] == stick)
			{
				WriteLine("Собрана деревянная лопата!\t");
			}
			else if (data[0, 1] == stone
			      && data[1, 1] == stick && data[2, 1] == stick)
			{
				WriteLine("Собрана каменная лопата!\t");
			}
			else if (data[0, 1] == iron
			      && data[1, 1] == stick && data[2, 1] == stick)
			{
				WriteLine("Собрана железная лопата!\t");
			}
		}
	}
}