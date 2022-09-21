static void emptyString(int howmanyString)        // Выводит нужное кол-во пустых строк
{
    int a = 0;
    while (a < howmanyString)
    {
     Console.WriteLine();
     a++;
    }
}
string text = new String('*', 40); // Выводит заданное количество символов,

void ArrayInput(string[] collect) //Заполнение массива строками: ввод с консоли
        {
            int index = 0;
            int length = collect.Length;
            while (index < length)
            {
                Console.Write("Введите строку стиха:  ");
                collect[index] = Console.ReadLine();
                index++;
            }
        }

        void ArrayPrint(string[] series)    //Выводит элементы массива на экран
        {
            int i=0;
            int length = series.Length;
            while(i<length)
            { Console.WriteLine($" \t {series[i]}"); i++;}
        }  

        void ArrayReducing(string[] set, int index, int excluded)// уменьшает размер массива, начиная с указанного индекса, на указанное количество строк
        {
            for (int i = index; i < set.Length - excluded; i++)
            {
                set[i] = set[i+1];
            }
            Array.Resize(ref set,  set.Length - excluded);
            ArrayPrint(set);
        }   
                
        string[] array = new string[4];
        Console.Write("Укажите автора:  ");
        string author = Console.ReadLine();
        Console.Write("Укажите название:  ");
        string title = Console.ReadLine();
        ArrayInput(array);
        emptyString(2);
        Console.WriteLine(text);
        Console.WriteLine($"\t\t\t {author}\n\t    {title}");
        Console.ForegroundColor = ConsoleColor.Green; 
        Console.WriteLine(text);
        emptyString(2);
        ArrayPrint(array);
        emptyString(2);
        Console.WriteLine(text);
        Console.ResetColor();
        ArrayReducing(array, 2, 1);
