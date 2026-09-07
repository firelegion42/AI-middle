using UnityEngine;

public class EnemyInjuredState : EnemyState
{
    public override void EnterState(EnemyStateManager state)
    {
        moveSpeedCoef = 0.5f;
    }

    public override void OnHealthChanged(EnemyStateManager state, float health)
    {
        throw new System.NotImplementedException();
    }

    public override void UpdateState(EnemyStateManager state)
    {
        throw new System.NotImplementedException();
    }
}
