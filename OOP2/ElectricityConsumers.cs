using System;


namespace OOP2
{
    class ElectricityConsumers
    {
        public readonly string nameConsumers;
        public readonly float consumptionOnPlan;
        public readonly float consumptionInFact;
        public readonly float mistake;
        public readonly float pMistake;

        public ElectricityConsumers(string name, float OnPlan, float InFact)
        {
            nameConsumers = name;
            consumptionOnPlan = OnPlan;
            consumptionInFact = InFact;
            mistake = Math.Abs(consumptionOnPlan - consumptionInFact);
            pMistake = (mistake * 100) / consumptionOnPlan;
        }
    }
}
