namespace EMail
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //adatszerkezet
            List<String> e_mailok = new List<String>();
            e_mailok.Add("alma1@kört.hu");
            e_mailok.Add("alma2@dfdfdf.hu");
            e_mailok.Add("alma3@ssdsds.hu");
            e_mailok.Add("kovacsk3@kkszki.hu");
            e_mailok.Add("alma.korte@alma.hu");

            //menüvezérlés
            while (true)
            {
                Console.WriteLine("0. Kilépés");
                Console.WriteLine("1. e-mailek listázása");
                Console.WriteLine("2. új e-mail");
                Console.WriteLine("3. e-mail törlése");
                Console.WriteLine("4. érvényes e-mailok listázása");

                string valasztas = Console.ReadLine();
                switch (valasztas)
                {
                    case "0": return;

                    case "1": 
                        Console.Clear();
                        Console.WriteLine("e - mailek listázása");
                        int sorszam = 0;
                        foreach (String e_mail in e_mailok)
                        {
                            Console.WriteLine($"{sorszam++}. {e_mail}");
                        }
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("új e - mailek");
                        String uj = Console.ReadLine();
                        e_mailok.Add(uj);
                        break;
                    case "3": Console.WriteLine("e - mail törlés");
                        Console.WriteLine("Adja meg a törlendő e-mail azonosítóját:");
                        int index = Convert.ToInt32(Console.ReadLine());
                        e_mailok.RemoveAt(index);
                        break;
                    case "4": Console.WriteLine("érvényes e - mailek listázása");
                        foreach (String e_mail in e_mailok)
                        {
                            if (e_mail.Contains(".") && e_mail.Contains("@"))
                                Console.WriteLine($"{e_mail}");
                        }
                        break;
                    default: Console.Clear(); Console.WriteLine("rossz parancs"); break;
                }
                Console.ReadKey();
            }
        }
    }
}
