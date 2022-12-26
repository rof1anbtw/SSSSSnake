namespace Sssssssssnake
{
    public class Food
    {
        public Position foodPos = new Position();

        Random rnd = new Random();
        Field field = new Field();

        public Food()
        {

            foodPos.x = rnd.Next(5, field.Width);
            foodPos.y = rnd.Next(5, field.Height);
        }
        public void drawFood()
        {

            Console.SetCursorPosition(foodPos.x, foodPos.y);
            Console.Write("#");
        }

        public Position foodLocation()
        {
            return foodPos;
        }

        public void foodNewLocation()
        {
            foodPos.x = rnd.Next(5, field.Width);
            foodPos.y = rnd.Next(5, field.Height);
        }
    }
}
