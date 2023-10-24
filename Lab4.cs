Console.WriteLine("Введите a,b,c,d,e");
int chet = 0;
for (int i = 1; i <= 5; i++)
{
    int n = Convert.ToInt32(Console.ReadLine());
    void m()
    {
        chet++;
    }
    if (n % 2 == 0)
    {
        m();
    }
}
Console.WriteLine($"Четные числа - {chet}");
