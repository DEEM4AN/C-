class Task2 {
    public static void Main(string [] args) {
        string upperCase = "AbcdEFgHjKlmnoPqRsTuVWxyZ";
        Console.WriteLine(StringToLowerCase(upperCase));
    }
    static string StringToLowerCase (string str) {
        return str.ToLower();
    }
}