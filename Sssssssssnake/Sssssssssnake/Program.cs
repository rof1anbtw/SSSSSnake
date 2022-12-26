using System.Xml.Linq;

namespace Sssssssssnake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            Field field = new Field();
            Snake snake = new Snake();
            Food food = new Food();


            Console.WriteLine("\t \t \t НАЖМИТЕ ENTER ЧТОБЫ НАЧАТЬ");
            Console.Read();
            while (!finished)
            {
                try
                {

                    field.drawfield();

                    Console.SetCursorPosition(90, 5);
                    Console.Write("Ваши очки: {0}", snake.score);
                    snake.Input();
                    food.drawFood();
                    snake.drawSnake();
                    snake.moveSnake();
                    snake.Eat(food.foodLocation(), food);
                    snake.hitWall(field);

                }
                catch (Exception e)
                {
                    Console.Clear();
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Restart (y/n)");
                    char c = char.Parse(Console.ReadLine());

                    switch (c)
                    {
                        case 'y':

                            snake.x = 20;
                            snake.y = 20;
                            snake.score = 0;
                            snake.snakeBody.RemoveRange(0, snake.snakeBody.Count - 1);


                            break;
                        case 'n':

                            finished = true;
                            break;

                    }

                }

            }
        }
    }
}