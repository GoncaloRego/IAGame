using System;
namespace IPCA.AI.DecisionTrees
{

    public class DTBinaryDecision : DTNode
    {
        readonly Func<Boolean> testFunction;
        readonly DTNode trueTree, falseTree;

        public DTBinaryDecision(Func<Boolean> test, DTNode tTree, DTNode fTree)
        {
            testFunction = test;
            trueTree = tTree;
            falseTree = fTree;
        }

        public override DTAction MakeDecision()
        {
            bool value = testFunction();
            return (value ? trueTree : falseTree).MakeDecision();
        }
    }
}