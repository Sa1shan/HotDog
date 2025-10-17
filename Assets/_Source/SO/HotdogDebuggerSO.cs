using UnityEngine;

namespace _Source.SO
{
    public class HotdogDebuggerSo : MonoBehaviour
    {
        [SerializeField] private HotdogSettings hotdogSettings;

        void Start()
        {
            if (hotdogSettings != null)
            {
                DebugHotdogsWithSO();
            }
            else
            {
                Debug.LogError("HotdogSettings not assigned!");
            }
        }

        public void DebugHotdogsWithSO()
        {
            // Базовые хотдоги с настройками из SO
            Hotdog classic = new ClassicHotdogSo(hotdogSettings);
            Hotdog chili = new ChiliHotdogSo(hotdogSettings);
            Hotdog bavarian = new BavarianHotdogSo(hotdogSettings);

            Debug.Log($"{classic.GetName()} ({classic.GetWeight()}г) — {classic.GetCost()}р.");
            Debug.Log($"{chili.GetName()} ({chili.GetWeight()}г) — {chili.GetCost()}р.");
            Debug.Log($"{bavarian.GetName()} ({bavarian.GetWeight()}г) — {bavarian.GetCost()}р.");

            Debug.Log("Дополнительная информация:");

            // Хотдоги с декораторами с настройками из SO
            Hotdog classicWithPickles = new PicklesDecoratorSo(new ClassicHotdogSo(hotdogSettings), hotdogSettings);
            Hotdog classicWithOnion = new SweetOnionDecoratorSo(new ClassicHotdogSo(hotdogSettings), hotdogSettings);

            Debug.Log($"{classicWithPickles.GetName()} ({classicWithPickles.GetWeight()}г) — {classicWithPickles.GetCost()}р.");
            Debug.Log($"{classicWithOnion.GetName()} ({classicWithOnion.GetWeight()}г) — {classicWithOnion.GetCost()}р.");
        }
    }
}