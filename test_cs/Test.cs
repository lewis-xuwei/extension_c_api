using lewis;

int code = FlatRoute.Exec(10);
if (code != 0)
{
    Console.WriteLine($"{code}");
    return;
}

Console.WriteLine($"Size of instance = {FlatRoute.GetNumNodes()}");
for (int i = 0; i < FlatRoute.GetNumNodes(); i++)
{
    Console.WriteLine($"{FlatRoute.GetNode(i)}");
}

FlatRoute.Exit();
