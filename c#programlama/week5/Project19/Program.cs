namespace Project19;

class Program
{
    static void RandomStudents(string[] students)
    {
        Random rnd = new Random();
        int randomIndex;
        for (int i = 0; i < students.Length; i++)
        {
            randomIndex = rnd.Next(students.Length);//7
            string temp = students[i];
            students[i] = students[randomIndex];
            students[randomIndex] = temp;
        }
    }
    static void Main(string[] args)
    {
        string[] students ={
            "Hakan Çakdı",
            "Tunacan Eşki",
            "Rojin Çetiz",
            "Elif Öztürk",
            "Ömer Taştekin",
            "Enes Kılıçaslan",
            "Atlas Uyar",
            "Erdem Yüce Gül",
            "Enes Can Aydemir",
            "Irmak Özen",
            "Burhan Torun",
            "Miraç Katmer",
            "Bedirhan Çaylı",
            "Melina Balcı",
            "Merve Kahraman",
            "Kerem Can Kırpar",
            "Gizem Yüksel",
            "Celal Uğur Koçan",
            "Tahir Burak Avar",
            "Samet Önür",
            "Aleyna Çelen",
            "Elifnur Binici",
            "Doğukan Babayiğit",
            "Emre Kılıç"
        };

        string[] teamNames = {
            "Debuggers",
            "CodeWars",
            "Algorithmics",
            "BinaryCoders",
            "NullPointers",
            "DevDynamics"
        };

        double memberCount = 4;
        int teamCount = (int)Math.Ceiling(students.Length / memberCount);

        string[] teams = new string[teamCount];

        //Students dizimizi karıştırıyoruz

        //ref kullanarak yaparsak nasıl olur ödev!!
        Random rnd = new Random();
        int randomIndex;
        for (int i = 0; i < students.Length; i++)
        {
            randomIndex = rnd.Next(students.Length);//7
            string temp = students[i];
            students[i] = students[randomIndex];
            students[randomIndex] = temp;
        }











        // foreach (string s in students)
        // {
        //     Console.WriteLine(s);
        // }
    }
}
