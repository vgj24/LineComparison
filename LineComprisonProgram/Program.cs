// See https://aka.ms/new-console-template for more information
using LineComparisonProgram;

Console.WriteLine("Line Comparison");
#region Line comparison
Linecomparison ln1 = new Linecomparison(12, 5, 14, 5);
Linecomparison ln2 = new Linecomparison(10, 5, 14, 5);
double l1 = ln1.findlength();
double l2 = ln2.findlength();

if (l1.CompareTo(l2) > 0)
{
    Console.WriteLine("line one with length ={0} is greater", l1);

}
else
{
    Console.WriteLine("line one with length ={0} is greater", l2);
}
#endregion
