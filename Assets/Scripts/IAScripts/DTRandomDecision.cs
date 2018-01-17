using System;
namespace IPCA.AI.DecisionTrees
{
    public class DTRandomDecision : DTNode
    {
        readonly DTNode[] actions;
        readonly Random rng;

        public DTRandomDecision(params DTNode[] child)
        {
            this.actions = child;
            rng = new Random();
        }

        public override DTAction MakeDecision()
        {
            return actions[rng.Next(actions.Length)].MakeDecision();
        }
    }
}