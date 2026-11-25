using Tyuiu.VazhnikLN.Sprint6.Task2.V13.Lib;
DataService ds = new DataService();
double[] res = ds.GetMassFunction(-5, 5);
for (int i = 0; i < 11; i++)
{
    Console.WriteLine($"{i}, {res[i]}");
}
