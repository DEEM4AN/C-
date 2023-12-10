class Program
{
    public static void Main(string[] args)
    {

        char[,] chars = {
        {'a', 'b', 'c'},
        {'d', 'e', 'f'},
        {'g', 'h', 'i'}
                        };

        Console.WriteLine(CreateString(chars));
    }

    static string CreateString(char[,] chars)
    {
        string result = string.Empty;
        for (int i = 0; i < chars.GetLength(0); i++)
        {
            for (int j = 0; j < chars.GetLength(1); j++)
            {
                result += chars[i,j];
            }
        }
        return result;
    }
}