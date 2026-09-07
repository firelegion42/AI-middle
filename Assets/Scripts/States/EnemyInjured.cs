using UnityEngine;

public class EnemyInjuredState : EnemyState
{
    public override void EnterState(EnemyStateManager state)
    {
        moveSpeedCoef = 0.5f;

        Debug.Log("EnteredInjured");
    }

    public override void OnHealthChanged(EnemyStateManager state, float health)
    {
        
    }

    public override void UpdateState(EnemyStateManager state)
    {
        
    }
}
