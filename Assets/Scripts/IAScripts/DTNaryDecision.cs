using System;
namespace IPCA.AI.DecisionTrees
{
    public class DTNaryDecision : DTNode
    {
        readonly DTNode[] actions;
        readonly Func<int> test;

        public DTNaryDecision(Func<int> test,
            params DTNode[] child)
        {
            this.test = test;
            this.actions = child;
        }

        public override DTAction MakeDecision()
        {
            int ans = test();
            if (ans < 0 || ans >= this.actions.Length)
                throw new Exception("Test function returned out of range integer");
            return this.actions[ans].MakeDecision();
        }
    }
}