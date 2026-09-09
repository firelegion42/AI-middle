using UnityEngine;

public class EnemyInjuredState : MonoBehaviour
{
    private float moveSpeedCoef;

    private void EnterState(EnemyStateManager state)
    {
        moveSpeedCoef = 0.5f;

        Debug.Log("EnteredInjured");
    }

    private void OnHealthChanged(EnemyStateManager state, float health)
    {
        
    }

    private void UpdateState(EnemyStateManager state)
    {
        
    }
}
