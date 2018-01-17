using System;

namespace IPCA.AI.DecisionTrees
{

    public class DTAction : DTNode
    {
        readonly Action action;

        public DTAction(Action action)
        {
            this.action = action;
        }

        public override DTAction MakeDecision()
        {
            return this;
        }

        public void Run()
        {
            this.action();
        }
    }
}