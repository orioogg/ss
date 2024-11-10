using Player_S10270448;
List<Player> players = new List<Player>();
List<string> header = new List<string>();
InitialisePlayerCollection();
DisplayOutput();
ProcessAttack();
void InitialisePlayerCollection()
{
    using (StreamReader reader = new StreamReader("Players.csv"))
    {
        string? s = reader.ReadLine();
        if (s != null)
        {
            string[] head = s.Split(',');
            foreach (string h in head)
            {
                header.Add(h);

            }
            while (s != null)
            {
                s = reader.ReadLine();
                if (s != null)
                {
                    string[] data = s.Split(',');
                    Player player = new Player(Convert.ToInt32(data[0]), data[1], Convert.ToDouble(data[2]), Convert.ToInt32(data[3]), Convert.ToInt32(data[4]));
                    players.Add(player);
                }
            }
        }

    }
}
void DisplayOutput()
{
    Console.WriteLine($"{header[0],-5}{header[1],-19}{header[2],-6}{header[3],-16}{header[4]}     Level");
    foreach (Player player in players)
    {
        Console.WriteLine($"{player.Id,-5}{player.Name,-19}{player.Hp,-6}{player.AttackDamage,-16}{player.Xp,-7}{player.CalculateLevel()}");
    }
}
void ProcessAttack()
{
    Console.Write("Enter Attacker Player ID: ");
    int? attackerId = Convert.ToInt32(Console.ReadLine());
    bool attackerFound = false;
    if (attackerId != null)
    {
        foreach (Player player in players)
        {
            if (attackerId == player.Id)
            {
                attackerFound = true;
                attackerId = player.Id;
                
            }
            
        }
        if (attackerFound == false) 
        {
            Console.WriteLine("Attacker Player ID not found.");
            ProcessAttack();
        }
    }
    Console.Write("Enter Defender Player ID: ");
    int? defenderId = Convert.ToInt32(Console.ReadLine());
    bool defenderFound = false;
    if (defenderId != null) 
    {
        foreach (Player player in players)
        {
            if (defenderId == player.Id)
            {
                defenderFound = true;
                defenderId = player.Id;
            }
        }
        if (defenderFound == false)
        {
            Console.WriteLine("Defender Player ID not found.");
            ProcessAttack();
        }
        
    }
}

        