using System;
using System.Data.Entity;

namespace OOP2_Visual
{
    public class ElectricityConsumer
    {
        public readonly string nameConsumers;
        public readonly float consumptionOnPlan;
        public readonly float consumptionInFact;
        public readonly float mistake;
        public readonly float pMistake;

        public ElectricityConsumer(string name, float OnPlan, float InFact)
        {
            nameConsumers = name;
            consumptionOnPlan = OnPlan;
            consumptionInFact = InFact;
            mistake = Math.Abs(consumptionOnPlan - consumptionInFact);
            pMistake = (mistake * 100) / consumptionOnPlan;
        }
    }
    class ConsumersContext : DbContext
    {
        public ConsumersContext() : base("ElectricityConsumerConnectionString")
        { }

        public DbSet<ElectricityConsumer> ElectricityConsumer { get; set; }
    }
}
