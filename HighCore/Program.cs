List<string> names = new List<string>();
List<int> scores = new List<int>();

SetScores(3, names, scores);
WriteScores(names, scores);

Console.ReadLine();

static void SetScores(int amount, List<string> names, List<int> scores)
{
    for (int i = 0; i < amount; i++)
    {
        string name = "";
        while (name == "")
        {
            Console.WriteLine("Write who set the score");
            name = Console.ReadLine();
        }

        bool isNumber = false;
        int score = 0;
        while (!isNumber)
        {
            Console.WriteLine("Write what the set score was");
            isNumber = int.TryParse(Console.ReadLine(), out score);
        }
        names.Add(name);
        scores.Add(score);

    }
}
static void WriteScores(List<string> names, List<int> scores)
{
    Console.WriteLine("Scores:");
    for (int i = 0; i < names.Count; i++)
    {
        Thingie(names, scores);

        Console.WriteLine(names[i] + " : " + scores[i]);
    }

    // not sure why
    static void Thingie(List<string> names, List<int> scores)
    {
        List<int> newScoreOrder = new List<int>();

        while (Blop(scores))
        {
            for (int i = 1; i < scores.Count; i++)
            {
                if (i != 0)
                {
                    if (scores[i] > scores[i - 1])
                    {
                        int save = scores[i];
                        scores[i] = scores[i - 1];
                        scores[i - 1] = save;

                        string saveName = names[i];
                        names[i] = names[i - 1];
                        names[i - 1] = saveName;
                    }
                }
            }
        }
        
        static bool Blop(List<int> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] > list[i - 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}