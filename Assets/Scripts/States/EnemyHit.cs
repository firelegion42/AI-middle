using UnityEngine;

public class EnemyHitState : MonoBehaviour
{
    private float moveSpeedCoef;

    private void EnterState(EnemyStateManager state)
    {
        moveSpeedCoef = 0.8f;

        state.Agent.speed = state.EnemySettings.EnemyMovespeed * moveSpeedCoef;

        Debug.Log("Entered Hit state");

        Transform bestTarget = FindClosestTarget(state);

        state.Agent.destination = bestTarget.position;

    }

    private void OnHealthChanged(EnemyStateManager state, float health)
    {
        if (state.EnemyHealth.HealthPercent <= state.EnemyHealth.InjuredPercent)
        {
            
        }
    }

    private void UpdateState(EnemyStateManager state)
    {
        
    }

    private Transform FindClosestTarget(EnemyStateManager state)
    {
        Transform bestTarget = null;
        {
            Vector3 currentposition = state.Agent.transform.position;
            float closestDistance = float.MaxValue;

            foreach (GameObject obj in state.Targets)
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
