// dog and friend

int distanse = 2000;
int speed_friend_one =15;
int speed_friend_two =20;
int speed_dog = 30;
int stop_distanse = 10;

int count = 0;
int friend_to = 2;

while(distanse > stop_distanse)
{
    if(friend_to == 1)
    {
        int time = distanse / (speed_friend_one + speed_dog);
        friend_to = 2;
    }
    else
    {
        int time = distanse / (speed_friend_two + speed_dog);
        friend_to = 1;
    }
    Console.WriteLine(distanse);
    distanse = distanse - (speed_friend_one + speed_friend_two);
    count++;
}
Console.WriteLine($"Собака пробежала: {count} раз.");