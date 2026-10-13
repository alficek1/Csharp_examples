// Celý kód přesunut do poznámek (komentářů)
// Originální kód:
/*
Console.WriteLine("Malá násobilka 10×10:");
for (int row = 1; row <= 10; row++)
{
    for (int col = 1; col <= 10; col++)
    {
        // zarovnaný výstup na šířku 4 znaků
        Console.Write("{0,4}", row * col);
    }
    Console.WriteLine();
}
Console.WriteLine("Stiskněte libovolnou klávesu...");
Console.ReadKey();
*/

// Nový kód: KALKULAČKA opakovaně dokud uživatel odpoví "ano"
while (true)
{
    Console.WriteLine("Vítejte v kalkulačce");

    Console.Write("Zadejte první číslo: ");
    string? s1 = Console.ReadLine();
    if (!float.TryParse(s1, out float a))
    {
        Console.WriteLine("Neplatné číslo. Zkusit znovu.");
        continue;
    }

    Console.Write("Zadejte druhé číslo: ");
    string? s2 = Console.ReadLine();
    if (!float.TryParse(s2, out float b))
    {
        Console.WriteLine("Neplatné číslo. Zkusit znovu.");
        continue;
    }

    Console.WriteLine("Zvolte si operaci:");
    Console.WriteLine("1 - sčítání");
    Console.WriteLine("2 - odčítání");
    Console.WriteLine("3 - násobení");
    Console.WriteLine("4 - dělení");
    Console.Write("Volba: ");
    string? sv = Console.ReadLine();
    if (!int.TryParse(sv, out int volba))
    {
        Console.WriteLine("Neplatná volba. Zkusit znovu.");
        continue;
    }

    float vysledek = 0;
    bool valid = true;
    switch (volba)
    {
        case 1:
            vysledek = a + b;
            break;
        case 2:
            vysledek = a - b;
            break;
        case 3:
            vysledek = a * b;
            break;
        case 4:
            if (b == 0)
            {
                Console.WriteLine("Chyba: dělení nulou.");
                valid = false;
            }
            else
            {
                vysledek = a / b;
            }
            break;
        default:
            valid = false;
            break;
    }

    if (valid)
        Console.WriteLine($"Výsledek: {vysledek}");
    else
        Console.WriteLine("Neplatná volba nebo chyba. Zkusit znovu.");

    Console.Write("Chcete pokračovat? (ano/ne): ");
    string? odpoved = Console.ReadLine();
    if (odpoved == null || !odpoved.Trim().Equals("ano", StringComparison.OrdinalIgnoreCase))
        break;

    Console.Clear();
}

Console.WriteLine("Děkuji za použití kalkulačky, aplikaci ukončíte libovolnou klávesou.");
Console.ReadKey();
