Random random = new Random();
int[,] Array = new int[5, 5];
int minValue = 1;
int maxValue = 1;  

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Array[i, j] = random.Next(-99,99);
    }
}

for (int k = 0; k < 5; k++)
{
for (int l = 0; l < 5; l++)
    {
        if (Array[k, l] < minValue)
        {
            minValue = Array[k, l];
        }
        if (Array[k, l] > maxValue)
        {
            maxValue = Array[k, l];
        }
    }
}

Console.WriteLine($"Minimal value in Array = {minValue}");
Console.WriteLine($"Maximal value in Array = {maxValue}");