// Alexandra Camarena
// MIS 3013 HW5 Part 1 Array

string[] clientNamesArr;
clientNamesArr = new string[10];
double[] bankBalancesArr;
bankBalancesArr = new double[10];
string m;
for (int i = 0; i < clientNamesArr.Length; i++)
{
    m = string.Format($"Please input the client {i + 1} name: ");
    Console.Write(m);
    string name = Console.ReadLine();
    clientNamesArr[i] = name;

    m = string.Format($"Please input the client {i+1} balance: ");
    Console.Write(m);
    string balanceStr = Console.ReadLine();
    double balanceDbl = Convert.ToDouble(balanceStr);

    bankBalancesArr[i] = balanceDbl;
}

Console.Write("\nThe clients' names:\n");
for (int i = 0; i < clientNamesArr.Length; i++)
{
    Console.WriteLine(clientNamesArr[i]);
}
Console.WriteLine("\nPlease input a client name: ");
string searchClientName = Console.ReadLine();
for (int i = 0; i < clientNamesArr.Length; i++)
{
    if (clientNamesArr[i] == searchClientName)
    {
        m = string.Format($"Client name: {searchClientName}, Balance: {bankBalancesArr[i]:C2}");
        Console.WriteLine(m);
    }
}