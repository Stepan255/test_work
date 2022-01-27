namespace test_work
{
	class Program
	{
		static void Main(string[] args)
		{
			ushort length = GetLengthFromConsole();

			string[] stringArray = GetStringArray(length);
			string[] shortStringArray = CreateShortItemArrayFrom(stringArray);
			Console.WriteLine("\nМассив в котором длинна любой строки не превышает 3, созданный на основе введенных вами данных:");
			Console.WriteLine(ArrayStringToText(shortStringArray));
		}

		static ushort GetLengthFromConsole()
		{
			Console.WriteLine("Введите длинну массива");
			Console.Write("Длинна массива: ");
			ushort length = 0;
			while (!ushort.TryParse(Console.ReadLine(), out length))
			{
				Console.WriteLine("\nВы ввели некоректтную длинну.\nВведите длину массива.");
				Console.Write("Длинна массива: ");
			}
			return length;
		}

		static string[] GetStringArray(ushort length)
		{
			string[] stringArray = new string[length];
			for (int i = 0; i < length; i++)
			{
				Console.Write($"Введите {i + 1} строку: ");
				stringArray[i] = Console.ReadLine();
			}
			return stringArray;
		}

		static string[] CreateShortItemArrayFrom(string[] startArray)
		{
			string[] stringArray = new string[startArray.Length];
			int index = 0;
			for (int i = 0; i < startArray.Length; i++)
			{
				if (startArray[i].Length <= 3)
				{
					stringArray[index++] = startArray[i];
				}
			}
			Array.Resize(ref stringArray, index);
			return stringArray;
		}

		static string ArrayStringToText(string[] stringArray)
		{
			string text = string.Empty;
			for (int i = 0; i < stringArray.Length - 1; i++)
			{
				text += '"' + stringArray[i] + '"' + ", ";
			}
			text += '"' + stringArray[stringArray.GetUpperBound(0)] + '"';
			return text;
		}
	}
}