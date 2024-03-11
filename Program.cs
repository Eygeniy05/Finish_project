static string[] EnterArrayFromKeyboard() {
    string [] array = new string [0];

    Console.WriteLine("Введите элементы массива. Для выхода нажмите клавишу Q");

    while(true) {
        string str = Console.ReadLine();

        if (str == "q") {
            Console.WriteLine("[stopped]");
            Console.WriteLine();
            break;
        }

        Array.Resize(ref array, array.Length + 1);
        array[array.Length - 1] = str;
    }

    return array;
}

static void PrintArray(string [] array) {
    Console.Write("[");

    for (int i = 0; i < array.Length; i++) {
        Console.Write('"' + array[i] + '"');
        if (i != array.Length - 1) {
            Console.Write(", ");
        }
    }
    
    Console.Write("]");

    Console.WriteLine();
}

static string[] FilterArrayByItemLength(string [] array, int limit) {
    string [] result = new string [0];

    for (int i = 0; i < array.Length; i++) {
        if (array[i].Length <= 3) {
            Array.Resize(ref result, result.Length + 1);
            result[result.Length - 1] = array[i];
        }
    }

    return result;
}

int lengthLimit = 3;
string [] array = EnterArrayFromKeyboard();
Console.WriteLine("Введенный массив:");
PrintArray(array);
string [] filteredArray = FilterArrayByItemLength(array, lengthLimit);
Console.WriteLine("Результат:");
PrintArray(filteredArray);