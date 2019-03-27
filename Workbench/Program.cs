using static System.Console;

namespace Workbench
{
	class Program
	{
		static void Main(string[] args)
		{
			const int SIZE_OF_CELLS = 3;

			int wood  = 1,
				stone = 2,
				iron  = 3,
				stick = 4;

			int[,] data = new int[SIZE_OF_CELLS, SIZE_OF_CELLS];

			WriteLine("Вертсак: ");
			SetCursorPosition(1, 10);
			WriteLine("\nВведите материал, перемещаясь по клеткам верстака:\n" +
				"1-дерево\n" +
				"2-камень\n" +
				"3-железо\n" +
				"4-палка");

			int material = 0;
			int posX = 0, posY = 0;

			Craft craft = new Craft();
			Cells cell  = new Cells();

			while (true)
			{
				SetCursorPosition(1, 1);

				//-------------прорисовка верстака, перемещение стрелки и выбор материала----------------
				cell.InitCells(data, ref posX, ref posY, ref material, wood, stone, iron, stick);

				//----------------------------сборка рецептов---------------------------
				craft.Crafting(data, wood, stone, iron, stick);
			}
		}
	}
}