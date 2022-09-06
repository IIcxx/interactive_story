string p1 = "null";
string p21 = "null";
string p22 = "null";
string p311 = "null";

/* i am very uncreative so this is a shit story but idc and it shows my ability to code which is the point */
Console.WriteLine("You are lost in a forest, you are presented with two roads, which one do you take? 'left' or 'right'.");


p1 = Console.ReadLine();

if (p1 == "right")
{
    Console.WriteLine("You now get presented with a house, do you enter? 'yes' or 'no'.");
    p21 = Console.ReadLine();
}

else if (p1 == "left")
{
    Console.WriteLine("After walking for a bit you come to a lake, do you 'stay' or 'turn around'?");
}

else
{ 
    Console.WriteLine("ok i see you tryna be funny with it, don't.");
}

p22 = Console.ReadLine();

if (p22 == "stay")
{
    Console.WriteLine("you stay at the side of the lake until nightfall, after that you continue walking in the middle of the night. You end up walking to far away and sadly never find home. thanks for playing.");
}
else if (p22 == "turn around")
{
    Console.WriteLine("When you turn around you see a new path that you take, after walking for a while you end up finding home, thanks for playing.");
}



  if (p21 == "yes")
{
    Console.WriteLine("you walk around the house for a bit and realise its empty but it seems cozy, do you 'stay' or do you 'leave'.");
}
else if (p21 =="no")
{
    Console.WriteLine("You continue walking for a while but finally you find home, thanks for playing.");

 
}
p311 = Console.ReadLine();
if (p311 == "stay")
{
    Console.WriteLine("welcome to your new home, thanks for playing.");
}
if (p311 == "leave")
{
    Console.WriteLine("leaving seems like it was a bad idea, you end up wandering alone until the end of time. thanks for playing.");
}
Console.ReadLine();



