var n = int.Parse(Console.ReadLine() ?? "0");
var socks = Console.ReadLine()
    ?.Split(' ')
    .Select(sock => int.Parse(sock))
    .ToArray()
    ?? new int[0];

using TextWriter textWriter =
    new StreamWriter(@"./output.txt", true);
var result = CountPairs(n, socks);
textWriter.WriteLine(result);

int CountPairs(int n, int[] socks)
{
    var pairsCount = 0;
    var pairs = new Dictionary<int, int>();

    foreach (var sock in socks)
    {
        if (!pairs.ContainsKey(sock))
            pairs.Add(sock, 0);

        pairs[sock]++;

        if (pairs[sock] % 2 == 0)
        {
            pairsCount++;
            pairs[sock] = 0;
        }
    }

    return pairsCount;
}
