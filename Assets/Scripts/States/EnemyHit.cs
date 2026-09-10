using UnityEngine;

public class EnemyHitState : EnemyState
{
    [SerializeField] protected GameObject[] targets;
    [SerializeField] protected float hitThreshold;

    public override float Evaluate()
    {
        if(_health.HealthPercent <= hitThreshold)
        {
            return 30f;
        }
        else
        {
            return 0f;
        }
    }

    public override void Execute()
    {
        moveSpeedCoef = 0.8f;

        agent.speed = moveSpeed * moveSpeedCoef;

        Debug.Log("Entered Hit state");

        Transform bestTarget = FindClosestTarget();

        agent.destination = bestTarget.position;
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
            }

            return bestTarget;
        }
    }
}
