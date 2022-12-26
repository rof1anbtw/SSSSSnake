namespace Sssssssssnake
{
    public class Field
    {
        public int Width;
        public int Height;


        public Field()
        {
            Width = 45;
            Height = 25;

            Console.CursorVisible = false;
        }


        public void drawfield()
        {
            Console.Clear();
            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("=");
            }
            for (int i = 0; i < Width; i++)
            {
                Console.SetCursorPosition(i, Height);
                Console.Write("=");
            }

            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("||");
            }

            for (int i = 0; i < Height; i++)
            {
                Console.SetCursorPosition(Width, i);
                Console.Write("||");
            }
        }
    }
}
