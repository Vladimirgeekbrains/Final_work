// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//  При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


void PrintArray(string[] str){
    Console.Write("[ ");
    for (int i = 0; i != str.Length; i++){
        Console.Write($" '{str[i]}' ");
    }
    Console.WriteLine("]");
}

string[] CheckAndSetString(string[] stringArray){
    int count = 0;
    for (int k = 0; k != stringArray.Length; k++){
        if (stringArray[k].Length <= 3){
            count++;
        }
    }
    string[] ModArray = new string[count];

    count = -1;
    for (int i = 0; i != stringArray.Length; i++){
        if (stringArray[i].Length <= 3){
            count++;
            ModArray[count] += stringArray[i];
        }
            // if (stringArray[i].Length <= 3){
            // }
            // else{
            //     break;
            // }
    }
    return ModArray;
}


Console.WriteLine("Input string: ");

string str = Console.ReadLine()!;
string[] strArray = str.Split();
PrintArray(strArray);
Console.WriteLine("-----------------------");
PrintArray(CheckAndSetString(strArray));

