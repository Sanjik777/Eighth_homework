using System;
using static System.Console;
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
	public abstract class Storage
	{
		private string name;
		private string model;

		public int FullMemory { set; get; }
		public int FilledMemory { set; get; } = 500; //по умолчанию занято у всех 500 MB
		public int FreeMemory { get { return FullMemory - FilledMemory; } }
		
		public int File { set; get; } = 780; //один файл = 780 mb
		public int TransportingMemory { set; get; } = 565000; //всего надо скопировать = 565000 mb
		public double AmountOfFiles { get { return Math.Ceiling((double)TransportingMemory / File); } }

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public string Model
		{
			get { return model; }
			set { model = value; }
		}		
		public virtual void GetFullInfo()
		{
			WriteLine($"\n-------------{name}------------\n");
			WriteLine("Name : " + Name);
			WriteLine("Model : " + Model);
			WriteLine($"Free Memory : { FreeMemory } MB");
			WriteLine($"Full Memory : { FullMemory} MB");
		}
		public virtual void CopyDataVirtual()
		{
			//находим необходимое кол-во устройств для переноса данных без учёта заполненной памяти
			//в одном из устройств:
			double amounts = Math.Ceiling((double)TransportingMemory / FullMemory);

			//находим остаточную память от последнего устройства:
			double furtherMemory = (FullMemory * amounts) - TransportingMemory;
			WriteLine($"\nFurther Memory of last device =  {furtherMemory} MB");

			//находим необходимое кол-во устройств для переноса данных с учётом заполненной памяти
			//в одном из устройств:
			if (TransportingMemory > FullMemory)
			{
				if (FilledMemory > furtherMemory)
				{
					amounts += amounts / amounts;//+1
					WriteLine($"\nData copying denied! Need {amounts} amount of this devices!");
				}
				else { WriteLine($"\nData copying denied! Need {amounts} amount of this devices!"); }
			}
			else { WriteLine($"\nData is copied for {Name}"); }
		}
		public abstract void CopyData();
	}
}
