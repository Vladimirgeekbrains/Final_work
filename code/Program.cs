// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.WriteLine("Hello, World!");

string str = Console.ReadLine()!;
string[] strArray = str.Split();
string[] CheckString(string[] stringArray){
    string[] ModArray = new string[stringArray.Length];
    for (int i = 0; i != stringArray.Length; i++){
        if (stringArray[i].Length <= 3){
            ModArray[i] += stringArray[i];
        }
        else{
            break;
        }
            // if (stringArray[i].Length <= 3){
                
            // }
            // else{
            //     break;
            // }
        }
    }
    return ModArray;
}
