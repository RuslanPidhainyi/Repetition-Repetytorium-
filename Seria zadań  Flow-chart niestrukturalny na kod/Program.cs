//Linq on info about this ex: https://e.wsei.edu.pl/mod/quiz/attempt.php?attempt=120320&cmid=19203

//Linq on ex: https://e.wsei.edu.pl/mod/quiz/attempt.php?attempt=120320&cmid=19203&page=1



using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

var split = Console.ReadLine().Split(" ");

Int32.TryParse(split[0], out int x);
Int32.TryParse(split[1], out int y);
Int32.TryParse(split[2], out int z);


////////////////////////////////////////////////////////








writeOut:


if (x > 0)
{
    if (y > 0)
    {
        x--; y--;
        Console.Write('C');
    }
    else if (y <= 0 || y < 0)
    {
        Console.Write('D');

        if (z <= 0 || z < 0)
        {
            Console.Write('G');
            return;
        }
        else if (z > 0)
        {
            return;
        }
    }
}
if (x <= 0 || x < 0)
{
    Console.Write('E');
    Console.Write('G');

    return;
}
goto writeOut;














/*
if (x > 0)
{
    writeOut:


    if (y > 0)
    {


        x--;
        y--;

        Console.Write("C");
        if (x > 0)
        {
            goto writeOut;
        }

    }
    else if(y < 0)
    {
        Console.WriteLine("D");
    }
    else if(z > 0)
    {
        Console.WriteLine();
    }
    else if(z < 0)
    {
        Console.Write("G");
    }

    
}
else if(x < 0)
{

    Console.Write("E");
    Console.Write("G");
}

*/











/*

write:

if(x > 0)
{
if(y > 0)
{
x =- 1;
y =- 1;



Console.WriteLine('C');
goto write;

}
else if( y < 0 ) 
{
//write = 'D'
Console.WriteLine('D');
goto write;

}
else if(z > 0)
{
//Console.WriteLine();

}
else if(z < 0)
{
//write = 'G';
Console.WriteLine('G');
goto write;

//Console.WriteLine();
}


}
else if(x < 0)
{
//write = 'E';

//write = 'G';
Console.WriteLine('E');
Console.WriteLine('G');
goto write;

//Console.WriteLine();
}

*/



/*
bool isFinished = false;
write:

if (x > 0)
{
    if (y > 0)
    {
        x = -1;
        y = -1;

        Console.Write('C');
        if (!isFinished) 
        { 
            goto write;
        }

    }
    else if (y < 0)
    {
        Console.Write('D');
        if (!isFinished)
        {
            goto write;
        }

    }
    else if (z > 0)
    {
        isFinished = true;
        Console.WriteLine();
    }
    else if (z < 0)
    {
        Console.Write('G');
        if (!isFinished)
        {
            goto write;
        }
        isFinished = true;
        Console.WriteLine();
    }


}
else if (x < 0)
{
    Console.Write('E');
    Console.Write('G');

    isFinished = true;
    Console.WriteLine();
}
*/



/*

bool isFinished = false;
write:

if (x > 0) //Yes
{
    if (y > 0) //Yes
    {
        x--;
        y--;

        Console.Write('C'); // C
        if (!isFinished || x > 0 || y > 0)
        {
            goto write;
        }

    }
    else if (y < 0) //No
    {
        Console.Write('D'); // D
    }
    else if (z > 0) //Yes
    {
        isFinished = true;
        Console.WriteLine();
    }
    else if (z < 0) //No
    {
        Console.Write('G');// G
        Console.WriteLine();
    }


}
else if (x < 0)// No
{
    Console.Write('E');
    Console.Write('G');


    Console.WriteLine();
}

*/









