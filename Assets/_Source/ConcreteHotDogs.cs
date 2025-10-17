namespace _Source
{
    public class ClassicHotdog : Hotdog
    {
        public ClassicHotdog() : base("Хот-дог классический", 210, 150)
        {
        }
    }

    public class ChiliHotdog : Hotdog
    {
        public ChiliHotdog() : base("Хот-дог чили", 250, 160)
        {
        }
    }

    public class BavarianHotdog : Hotdog
    {
        public BavarianHotdog() : base("Хот-дог баварский", 280, 170)
        {
        }
    }
}