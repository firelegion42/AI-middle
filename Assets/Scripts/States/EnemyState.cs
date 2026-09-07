using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyState
{
    protected float moveSpeedCoef;

    public abstract void EnterState(EnemyStateManager state);

    public abstract void UpdateState(EnemyStateManager state);

    public abstract void OnHealthChanged(EnemyStateManager state, float health);
        


}
