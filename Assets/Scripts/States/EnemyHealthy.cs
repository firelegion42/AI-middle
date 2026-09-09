using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyHealthyState : MonoBehaviour
{
    private int moveSpeedCoef;

    private void EnterState(EnemyStateManager state)
    {
        Debug.Log("Entered Healthy");

        moveSpeedCoef = 1;

        state.Agent.speed = state.EnemySettings.EnemyMovespeed * moveSpeedCoef;
        
        int currentzone = Random.Range(0, state.Targets.Length);

        state.Agent.destination = state.Targets[currentzone].transform.position;

        Debug.Log("Current patrol target is " + currentzone);
    }

    private void OnHealthChanged(EnemyStateManager state, float health)
    {
        if (state.EnemyHealth.HealthPercent <= state.EnemyHealth.HitPercent)
        {
            
        }

    }

    private void UpdateState(EnemyStateManager state)
    {
        
    }
}
