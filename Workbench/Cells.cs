using System;
using static System.Console;

namespace Workbench
{
	public class Cells
	{
		const int UPPER_BOUND_OF_ARROW = 0;
		const int LOWER_BOUND_OF_ARROW = 2;

		public void InitCells(int[,] data, ref int posX, ref int posY, ref int material,
			int wood, int stone, int iron, int stick)
		{
			//------------------------прорисовка верстака---------------------
			string Cells = $"\n-------\n" +
			   $"|{data[0, 0]}|{data[0, 1]}|{data[0, 2]}|\n" +
			   $"-------\n" +
			   $"|{data[1, 0]}|{data[1, 1]}|{data[1, 2]}|\n" +
			   $"-------\n" +
			   $"|{data[2, 0]}|{data[2, 1]}|{data[2, 2]}|\n" +
			   $"-------";
			Write(Cells);
			//-----------------------перемещение по верстаку------------------
			ConsoleKeyInfo keyButton = ReadKey();
			switch (keyButton.Key)
			{
				case ConsoleKey.LeftArrow: { if (posX > UPPER_BOUND_OF_ARROW) { posX--; } break; }
				case ConsoleKey.RightArrow:{ if (posX < LOWER_BOUND_OF_ARROW) { posX++; } break; }
				case ConsoleKey.UpArrow:   { if (posY > UPPER_BOUND_OF_ARROW) { posY--; } break; }
				case ConsoleKey.DownArrow: { if (posY < LOWER_BOUND_OF_ARROW) { posY++; } break; }
				case ConsoleKey.Enter:     { data[posY, posX] = material; break; }
			}
			//--------------------------Выбор материала-----------------------
			SetCursorPosition(1, 20);
			//if (keyButton.KeyChar == 27) { Clear(); WriteLine("\nПока!\n"); break; }
			switch (keyButton.KeyChar)
			{
				case '1': { material = wood;  WriteLine("Выбрано дерево\t"); break; }
				case '2': { material = stone; WriteLine("Выбран камень\t");  break; }
				case '3': { material = iron;  WriteLine("Выбрано железо\t"); break; }
				case '4': { material = stick; WriteLine("Выбрано палка\t");  break; }
			}
		}
	}
}