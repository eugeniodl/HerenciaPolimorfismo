using TestIComparable;

Rectangle[] rects = new Rectangle[5];

rects[0] = new(7, 5);
rects[1] = new(6, 4);
rects[2] = new(4, 3);
rects[3] = new(7, 6);
rects[4] = new(5, 7);

foreach (Rectangle r in rects)
{
    Console.WriteLine(r);
}

Console.WriteLine("-----------------------");

Array.Sort(rects);

foreach (Rectangle r in rects)
{
    Console.WriteLine(r);
}
