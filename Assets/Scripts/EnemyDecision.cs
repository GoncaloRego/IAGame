using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IPCA.AI.DecisionTrees;

public class EnemyDecision : MonoBehaviour
{
    public Transform target;

    public float distanceToPlayer = 0f;
    public bool isClose = false;

	void Update ()
	{
	    distanceToPlayer = Vector3.Distance(transform.position, target.position);

        //Debug.Log("Distance: " + distanceToPlayer);

	    DTBinaryDecision tree = new DTBinaryDecision(() =>
	        {
	            return distanceToPlayer < 50f;
	        },

	        new DTAction(() =>
	        {
	            Attack();
	        }),

	        new DTAction(() =>
	        {
	            Debug.Log("Waiting");
	            isClose = false;
	        }));

            new DTBinaryDecision(() =>
	        {
	            return distanceToPlayer < 10f;
	        },
            
            new DTAction(() =>
            {
                    Debug.Log("You died");
            }),
            new DTAction(() =>
            {
                Debug.Log("Continue");
            }));

        tree.MakeDecision().Run();
	}

    void Attack()
    {
        isClose = true;
        transform.GetComponent<Unit>().target = target;
    }
}
