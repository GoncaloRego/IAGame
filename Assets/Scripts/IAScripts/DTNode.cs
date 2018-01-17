using System;
namespace IPCA.AI.DecisionTrees
{
    abstract public class DTNode
    {
        abstract public DTAction MakeDecision();
    }
}