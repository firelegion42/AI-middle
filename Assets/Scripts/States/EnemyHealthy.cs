using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyHealthyState : EnemyState
{
    public override void EnterState(EnemyStateManager state)
    {
        Debug.Log("Entered Healthy");

        moveSpeedCoef = 1;

        state.Agent.speed = state.EnemySettings.EnemyMovespeed * moveSpeedCoef;
        
        int currentzone = Random.Range(0, state.Targets.Length);

        state.Agent.destination = state.Targets[currentzone].transform.position;

        Debug.Log("Current patrol target is " + currentzone);
    }

    public override void OnHealthChanged(EnemyStateManager state, float health)
    {
        if (state.EnemyHealth.HealthPercent <= state.EnemyHealth.HitPercent)
        {
            state.SwitchState(state.HitState);
        }

    }

    public override void UpdateState(EnemyStateManager state)
    {
        
    }
}
