using UnityEngine;

namespace _Source
{
    public class HotdogDebugger : MonoBehaviour
    {
        void Start()
        {
            DebugHotdogs();
        }

        public void DebugHotdogs()
        {
            // Базовые хотдоги
            Hotdog classic = new ClassicHotdog();
            Hotdog chili = new ChiliHotdog();
            Hotdog bavarian = new BavarianHotdog();

            Debug.Log($"{classic.GetName()} ({classic.GetWeight()}г) — {classic.GetCost()}р.");
            Debug.Log($"{chili.GetName()} ({chili.GetWeight()}г) — {chili.GetCost()}р.");
            Debug.Log($"{bavarian.GetName()} ({bavarian.GetWeight()}г) — {bavarian.GetCost()}р.");

            Debug.Log("Дополнительная информация:");

            // Хотдоги с декораторами
            Hotdog classicWithPickles = new PicklesDecorator(new ClassicHotdog());
            Hotdog classicWithOnion = new SweetOnionDecorator(new ClassicHotdog());

            Debug.Log($"{classicWithPickles.GetName()} ({classicWithPickles.GetWeight()}г) — {classicWithPickles.GetCost()}р.");
            Debug.Log($"{classicWithOnion.GetName()} ({classicWithOnion.GetWeight()}г) — {classicWithOnion.GetCost()}р.");
        }
    }
}