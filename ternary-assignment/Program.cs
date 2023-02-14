//
for (int idx = 1; idx <= 30; idx++)
{
    bool isDivBy3 = (idx % 3 == 0) ? true : false;
    bool isDivBy5 = (idx % 5 == 0) ? true : false;
    bool isDivBy3n5 = isDivBy3 && isDivBy5 ? true : false;


    if (isDivBy3n5)
    {
        Console.Write(" FIZZBUZZ ");
        continue;
    }
    if (isDivBy3)
    {
        Console.Write(" FIZZ ");
        continue; //optional
    }
    if (isDivBy5)
    {
        Console.Write(" BUZZ ");
        continue;
    }
    Console.Write($" {idx} ");
}


/* I had the following:
for (int idx = 1; idx <= 30; idx++)
{
    if (idx % 3 == 0 && idx % 5 == 0)
        Console.Write(" FIZZBUZZ ");
    else if (idx%3==0 && idx%5!=0)
        Console.Write(" FIZZ ");
    else if (idx%3!=0 && idx%5==0)
        Console.Write(" BUZZ ");
    else
        Console.Write(" {idx} ");
    idx++;

}
*/

