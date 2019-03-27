﻿using static System.Console;
/*
 Наследование.

1. Разработать приложение «Резервная копия» 
Цель: произвести расчет необходимого количества внешних носителей информации
при переносе за один раз важной информации (565 Гб, файлы по 780 Мб)
с рабочего компьютера на домашний компьютер и затрачиваемое на данный процесс время.
Вы имеете в распоряжении следующие типы носителей информации: 
●	Flash-память,
●	DVD-диск,
●	съемный HDD.
Каждый носитель информации является объектом соответствующего класса: 
●	Flash-память — класс «Flash»;
●	класс DVD-диск — класс «DVD»;
●	класс съемный HDD — класс «HDD».
Все три класса являются производными от абстрактного класса «Носитель информации» — класс «Storage».
Базовый класс («Storage») содержит следующие закрытые поля:
●	наименование носителя;
●	модель.
Класс обладает всеми необходимыми свойствами для доступа к полям, а также абстрактными методами: 
●	получение объема памяти;
●	копирование данных (файлов/папок) на устройство,
●	получение информации о свободном объеме памяти на устройстве;
●	получение общей/полной информации об устройстве.
Кроме того, каждый из производных классов дополняется следующими полями:
●	класс Flash-память: скорость USB 3.0, объем памяти;
●	класс DVD-диск: скорость чтения / записи, тип (односторонний (4.7 Гб) /двусторонний (9 Гб)); 
●	класс съемный HDD: скорость USB 2.0, количество разделов, объем разделов.
Работа с объектами соответствующих классов производится через ссылки на базовый класс («Storage»),
которые хранятся в массиве. 
Приложение должно предоставлять следующие возможности:
●	расчет общего количества памяти всех устройств;
●	копирование информации на устройства;
●	расчет времени необходимого для копирования;
●	расчет необходимого количества носителей информации представленных типов для переноса информации.
*/
namespace eighth_homework
{
	public class DVD:Storage
	{
		int nineThousand = 9000;
		int fourAndSevenThousand = 4700;

		public int SpeedReadAndWriteDVD { set; get; } = 20;

		public bool DVDSide { set; get; } //0 - односторонний (4.7 Гб) /1 - двусторонний (9 Гб)
		public int DVDMemory
		{
			get
			{
				if (DVDSide == true) { return nineThousand; }
				else { return fourAndSevenThousand; }
			}
		}
		public DVD(string name, string model)
		{
			Name = name;
			Model = model;
			FullMemory = DVDMemory;
		}
		public override void GetFullInfo()
		{
			base.GetFullInfo();
			WriteLine($"Speed : {SpeedReadAndWriteDVD} MB/Sec");			
			WriteLine($"\nActual time for copying with this speed: {TransportingMemory / SpeedReadAndWriteDVD} sec");
		}
		public override void CopyData()
		{
			CopyDataVirtual();
		}
	}
}
