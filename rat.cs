int[,] map = new int [5,5];
int linebreaker = 0;

map[0, 0] = 2;
map[1, 0] = 0;
map[2, 0] = 1;
map[3, 0] = 1;
map[4, 0] = 1;

map[0, 1] = 1;
map[1, 1] = 0;
map[2, 1] = 0;
map[3, 1] = 0;
map[4, 1] = 0;

map[0, 2] = 0;
map[1, 2] = 0;
map[2, 2] = 1;
map[3, 2] = 1;
map[4, 2] = 0;

map[0, 3] = 0;
map[1, 3] = 1;
map[2, 3] = 1;
map[3, 3] = 1;
map[4, 3] = 0;

map[0, 4] = 0;
map[1, 4] = 0;
map[2, 4] = 0;
map[3, 4] = 0;
map[4, 4] = 3;

foreach (int block in map)
{
    if (linebreaker == 5)
    {
        Console.Write("\n");
        linebreaker = 0;
    }
    linebreaker++;
    switch (block)
    {
        case 0:
            Console.Write($"[    {block}   ]");
            break;
        case 1:
            Console.Write($"[    {block}   ]");
            break;
        case 2:
            Console.Write("[  Rato  ]");
            break;
        case 3:
            Console.Write("[ Queijo ]");
            break;
    } 
}