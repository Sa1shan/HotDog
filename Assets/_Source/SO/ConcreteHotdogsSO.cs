namespace _Source.SO
{
    public class ClassicHotdogSo : HotdogSo
    {
        public ClassicHotdogSo(HotdogSettings settings) 
            : base(settings.classicHotdog.name, settings.classicHotdog.baseCost, settings.classicHotdog.baseWeight)
        {
        }
    }

    public class ChiliHotdogSo : HotdogSo
    {
        public ChiliHotdogSo(HotdogSettings settings) 
            : base(settings.chiliHotdog.name, settings.chiliHotdog.baseCost, settings.chiliHotdog.baseWeight)
        {
        }
    }

    public class BavarianHotdogSo : HotdogSo
    {
        public BavarianHotdogSo(HotdogSettings settings) 
            : base(settings.bavarianHotdog.name, settings.bavarianHotdog.baseCost, settings.bavarianHotdog.baseWeight)
        {
        }
    }
}