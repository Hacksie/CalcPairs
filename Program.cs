

internal class Program
{
    public static List<int> deck = new List<int>();
    private static void Main(string[] args)
    {
        long sum = 0;
        int count = 10000000;
        for (int j = 1; j < count; j++)
        {
            ResetDeck();
            int i = 0;
            for (i = 0; i <= 51; i++)
            {
                if (i == 51)
                {
                    sum += 52;
                    break;
                }
                
                if (deck[i] == deck[i + 1])
                {
                    sum += i;
                    break;
                }
            }

        }

        Console.WriteLine("Avg: " + sum + "/" + count + "=" + ((float)sum / count));
    }

    public static void ResetDeck()
    {
        deck.Clear();
        for (int i = 1; i <= 13; i++)
        {
            deck.Add(i);
            deck.Add(i);
            deck.Add(i);
            deck.Add(i);
        }
        deck = deck.OrderBy(x => Random.Shared.Next()).ToList();
    }
};