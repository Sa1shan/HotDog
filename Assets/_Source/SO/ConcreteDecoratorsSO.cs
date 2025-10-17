namespace _Source.SO
{
    public class PicklesDecoratorSo : HotdogDecorator
    {
        public PicklesDecoratorSo(Hotdog hotdog, HotdogSettings settings) 
            : base(hotdog, settings.picklesDecorator.name, 
                settings.picklesDecorator.additionalCost, 
                settings.picklesDecorator.additionalWeight)
        {
        }
    }

    public class SweetOnionDecoratorSo : HotdogDecorator
    {
        public SweetOnionDecoratorSo(Hotdog hotdog, HotdogSettings settings) 
            : base(hotdog, settings.sweetOnionDecorator.name, 
                settings.sweetOnionDecorator.additionalCost, 
                settings.sweetOnionDecorator.additionalWeight)
        {
        }
    }
}