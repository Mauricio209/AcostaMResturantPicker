//MAcosta
//10-17-22
//Today we will make a random resturant randomizer
//
Random rnd = new Random();

string[] resturants =  {"IHop","Texas Road House","Apple Bees","Bob's Cafe","Red Lobster","Arbys","Chillys","Dennys","Olive Garden","Quiznos"};
int index = rnd.Next(resturants.Length);
Console.WriteLine(resturants[index]);
