namespace ExplicitInterfaceGeekout
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExplodingBalloon explodingBalloon = new ExplodingBalloon();

            IBomb bomb = explodingBalloon;
            bomb.BlowUp();

            IBalloon balloon = explodingBalloon;
            balloon.BlowUp();

        }
    }


    public class ExplodingBalloon : IBomb, IBalloon
    {
        void IBomb.BlowUp() { Console.WriteLine("Kaboom!"); }
        void IBalloon.BlowUp() { Console.WriteLine("Whoosh"); }

    }

    public interface IBomb { void BlowUp(); }
    public interface IBalloon { void BlowUp(); }
}