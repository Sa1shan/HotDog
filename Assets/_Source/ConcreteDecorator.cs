namespace _Source
{
    public class PicklesDecorator : HotdogDecorator
    {
        public PicklesDecorator(Hotdog hotdog) : base(hotdog, "с маринованными огурцами", 50, 20)
        {
        }
    }

    public class SweetOnionDecorator : HotdogDecorator
    {
        public SweetOnionDecorator(Hotdog hotdog) : base(hotdog, "со сладким луком", 30, 10)
        {
        }
    }
}