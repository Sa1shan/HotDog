using System;
using UnityEngine;

namespace _Source.SO
{

    [CreateAssetMenu(fileName = "HotdogSettings", menuName = "Hotdog/Hotdog Settings")]
    public class HotdogSettings : ScriptableObject
    {
        [Serializable]
        public class HotdogConfig
        {
            public string name;
            public int baseCost;
            public int baseWeight;
        }

        [Serializable]
        public class DecoratorConfig
        {
            public string name;
            public int additionalCost;
            public int additionalWeight;
        }

        public HotdogConfig classicHotdog;
        public HotdogConfig chiliHotdog;
        public HotdogConfig bavarianHotdog;

        public DecoratorConfig picklesDecorator;
        public DecoratorConfig sweetOnionDecorator;
    }
}