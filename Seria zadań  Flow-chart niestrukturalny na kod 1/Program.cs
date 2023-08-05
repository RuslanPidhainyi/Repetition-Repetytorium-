//Linq on info about this ex: https://e.wsei.edu.pl/mod/quiz/attempt.php?attempt=120320&cmid=19203

//Linq on ex: https://e.wsei.edu.pl/mod/quiz/attempt.php?attempt=120320&cmid=19203&page=2

var split = Console.ReadLine().Split();

Int32.TryParse(split[0], out int x);
Int32.TryParse(split[1], out int y);
Int32.TryParse(split[2], out int z);





for(int i = 0; i < split.Length; i++)
{
    if (x > 0 )
    {
        if(y > 0)
        {
            x--; y--;
            Console.Write('C');
        }
        else if(y <= 0 || y < 0 )
        {
            Console.Write('D');

            if( z <= 0 || z < 0)
            {
                Console.Write('G');
                break;
            }
            else if(z > 0)
            {
                break;
            }
        }
    }
    if( x <= 0 || x < 0)
    {
        Console.Write('E');
        Console.Write('G');

        break;
    }
}















/* //////////////////////////////////////////////////////////
 
for(int i = 0; i < split.Length; i++)
{
    if(x > 0)
    {
        if(y > 0)
        {
            x--;
            y--; 
            Console.Write('C');
        }
    }
    break;
}
/*
if(y <= 0 || y < 0)
{
    Console.Write('D');
}
if(z > 0 )
{
    return;
}
if( z<=0|| z < 0)
{
    Console.Write('G');
    return;
}
*/
/*          usuń
if(x <= 0 || x < 0)
{
    Console.Write('E');
    Console.Write('G');

    return;
}

//////////////////////////////////////////////////////////*/
