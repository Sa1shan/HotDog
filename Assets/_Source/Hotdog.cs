namespace _Source
{
    public abstract class Hotdog
    {
        protected string name;
        protected int cost;
        protected int weight;

        public Hotdog(string name, int cost, int weight)
        {
            this.name = name;
            this.cost = cost;
            this.weight = weight;
        }

        public virtual string GetName()
        {
            return name;
        }

        public virtual int GetCost()
        {
            return cost;
        }

        public virtual int GetWeight()
        {
            return weight;
        }
    }
}