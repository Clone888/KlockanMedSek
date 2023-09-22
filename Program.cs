int hour = 0;
int min = 0;
int sek = 0;



while (hour < 24)
{

    if (sek == 60)

    {       
        if (min == 60)
        {
            hour++;
            min = 0;
        }

        min++;
        sek = 0;
    }


    if (hour < 10)
    {
        Console.Write("0" + hour);
    }
    else if (hour >= 10)
    {
        Console.Write(hour);
    }

    if (min < 10)
    {
        Console.Write(":0" + min);
    }
    else if (min >= 10)
    {
        Console.Write(":" + min);
    }
    if (sek < 10)
    {
        Console.WriteLine(":0" + sek);
    }
    else if (sek >= 10)
    {
        Console.WriteLine(":" + sek);
    }




    hour++;
}

