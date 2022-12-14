using Microsoft.VisualBasic.FileIO;


namespace TestWork2
{
    public class Pars
    {
        static void Log(string message)
        {
            File.AppendAllText("log.txt", message + "\n");
        }
        static void Main(string[] args)
        {
            Log("Запуск программы" + DateTime.Now);
            var Players = new List<Person>();
            using (TextFieldParser tfp = new TextFieldParser(@"C:\Users\tupae\OneDrive\Рабочий стол\Top100ChessPlayers.csv"))
            {
                tfp.TextFieldType = FieldType.Delimited;
                tfp.SetDelimiters(";");
                string[] str1 = tfp.ReadFields();
                while (!tfp.EndOfData)
                {
                    string[] str = tfp.ReadFields();
                    Person p = new Person()
                    {
                        Rank = int.Parse(str[0]),
                        Name = str[1],
                        Title = str[2],
                        Country = str[3],
                        Rating = int.Parse(str[4]),
                        Games = int.Parse(str[5]),
                        B_Year = int.Parse(str[6]),
                    };
                    Players.Add(p);
                }
            }
            int kol = 0;
            foreach (Person p in Players)
            {
                if (p.B_Year < 1980 && kol < 10)
                {
                    Log(p.ToString());
                    Console.WriteLine(p);
                    kol++;
                }
            }
            Log("Завершение программы" +  DateTime.Now);
        }
    }
}