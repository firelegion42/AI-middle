using UnityEngine;
using UnityEngine.Assemblies;
using static UnityEngine.GraphicsBuffer;

public class PatrolBehaviour : EnemyBehaviour
{

    [SerializeField] protected GameObject[] targets;

    [SerializeField] private float distanceToTarget;


    public override float Evaluate()
    {
        var distance = Vector3.Distance(transform.position, _player.position);
        var utility = _utilityCurve.Evaluate(1 - distance / _radius);
        if(utility > 0)
        {
            return Mathf.Clamp01(utility);
        }
        else
        {
            return 1f;
        }
        
    }

    public override void Execute()
    {
        moveSpeedCoef = 0.8f;

        agent.speed = moveSpeed * moveSpeedCoef;

        Debug.Log("Entered Patrol");

        Transform bestTarget = FindClosestTarget();

        agent.destination = bestTarget.position;

        float distance = Vector3.Distance(transform.position, bestTarget.position);

        if(distance <= distanceToTarget)
        {
            animator.SetInteger("CurrentState", 1);
        }
        else
        {
            animator.SetInteger("CurrentState", 0);
        }
        


    }

    private Transform FindClosestTarget()
    {
        Transform bestTarget = null;
        {
            Vector3 currentposition = agent.transform.position;
            float closestDistance = float.MaxValue;

            foreach (GameObject obj in targets)
            {
                Vector3 differenceToTarget = obj.transform.position - currentposition;
                float distance = differenceToTarget.sqrMagnitude;

                if (distance < closestDistance)
                {
                    closestDistance = distance;
                    bestTarget = obj.transform;
                    Debug.Log("Found Closest Target");
                }

                else if (distance < distanceToTarget)
                {
                    animator.SetBool("IsRunning", false);
                    animator.SetBool("LookingAround", true);
                }
            }

            return bestTarget;
        }
    }
}
