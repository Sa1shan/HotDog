namespace _Source
{
    public abstract class HotdogDecorator : Hotdog
    {
        protected Hotdog hotdog;

        public HotdogDecorator(Hotdog hotdog, string decoratorName, int decoratorCost, int decoratorWeight) 
            : base(hotdog.GetName() + " " + decoratorName, hotdog.GetCost() + decoratorCost, hotdog.GetWeight() + decoratorWeight)
        {
            this.hotdog = hotdog;
        }
    }
}