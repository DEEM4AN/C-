class Task3 {
    public static void Main(string[] args) {
        string example = "Топот";
        Console.WriteLine(IsPalindrome(example));
    }

    static bool IsPalindrome(string str) {
        char[] charArrayReverse = str.ToLower().ToCharArray();
        Array.Reverse(charArrayReverse);
        string stringRevers = new string(charArrayReverse);
        Console.WriteLine(stringRevers);
        if (str.ToLower().Equals(stringRevers)) {
            return true;
        } else return false;
    }
}