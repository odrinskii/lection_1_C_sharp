// Лекция №3

//Вид 1 Ничего не принимают, ничего не возвращают. 

// void Method1()
// {
//     Console.WriteLine("Author ....");

// }

//Method1();


//Вид2 Что-то принимают, ничего не возвращают.

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения"); //или
// Method2(msg: "Текст сообщения");


// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21(count: 4, msg: "Текст"); // можно указывать внутри метода принадлежность к аргументу, 
                                    //причем не обязательно по порядку 



// Вид 3 Ничего не принимают, что-то возвращают.

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// // Console.WriteLine(year);

// Вид 4  Методы что-то принимают, что-то возвращают. 

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;

//     }
//     return result;
// }
// string res = Method4(10, "asdf");
// Console.WriteLine(res);


//----------------------------------------
// string Method4(int count, string text)
// {
//     string result = String.Empty;

//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
        
//     }
//     return result;
// }

// string res = Method4(10, "asdf");
// // Console.WriteLine(res);

//------------------------------------------------------

// for (int i = 2; i <= 10; i++) // Вывод табл.умножения
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i*j}");
//     }
//     Console.WriteLine();
// }

//----------------------------------------------------------

// Задача 1

// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы "к" заменить большими "К", 
// а большие "С" заменить маленькими "с".


string text = "- Я думаю, - Сказал князь, улыбаяСь, - что, "
            + "ежели бы вас послали вместо нашего Винценгероде,"
            + "вы бы вязли приступом Согласие прусского короля. "
            + "Вы так краСноречивы. Вы дадите мне чаю?";

// string s = qwerty
//            012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }


    return result;    
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText);