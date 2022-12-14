// task about dog and two friends
double distance = 10000, firstFriendSpeed = 1, secondFriendSpeed = 2, dogSpeed = 5, time = 0;
int count = 0;
string friend = "friend1";

while (distance > 10)
{
    if (friend == "friend1")
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = "friend2";
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed) * time;
    count = count + 1;
    friend = "friend1";
}
Console.WriteLine("Dog will run " + count + " times");