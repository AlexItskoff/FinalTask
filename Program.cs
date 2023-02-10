
//******************  вводим исходный текст **************************
string text = "Нападающий Криштиану Роналду занимается на тренировочной базе Реала ";

//**************** определяем слова из скольких букв мы хотим видеть после обрезания
Console.WriteLine("Введите число. Оно определит количество знаков в словах, которые останутся после обрезания элементов массива");
int CutNumber = int.Parse(Console.ReadLine()!);

// ***************** трансформируем исходный текст в массив строк. 
//*****************  в каждую строку попадает одно слово. Разделитель - пробел
string[] words = text.Split(' ');

// **************** выводим исходный массив на печать
 foreach (var item in  words)
   {
    Console.WriteLine(item);
   }


// ************* создаем второй массив, в который попадут только слова с определенной нами длиной
string[] wordsCut = new string[words.Length];

// ***************** процедура наполнения второго массива
void SecondArray(string[] words, string[] wordsCut)
{
    int count = 0;
    for (int i = 0; i < words.Length; i++)
    {
    if(words[i].Length <= CutNumber)
        {
        wordsCut[count] = words[i];
        count++;
        }
    }
}

// ****************** вывод массива на печать
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// ***********  исполняем созданные процедуры, подставляя нужные параметры
SecondArray(words, wordsCut);
PrintArray(wordsCut);



