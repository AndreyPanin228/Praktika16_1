using Praktika16_1;

Console.WriteLine("Введите слово, которое хотите найти(с маленькой буквы)");
string slovo = Console.ReadLine().ToLower();
if (Exam.ExamFirst(slovo) == false)
{
    Console.WriteLine(Exam.First(slovo));
}
else
{
    Console.WriteLine("Ошибка");
}
