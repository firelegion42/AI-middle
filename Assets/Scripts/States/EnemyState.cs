using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyState : MonoBehaviour, IBehaviour
{

    [SerializeField] protected EnemyHealth _health;
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected NavMeshAgent agent;
    protected EnemyStateManager stateManager;
    protected float moveSpeedCoef;


    public void Init(EnemyStateManager state)
    {
        stateManager = state;
    }

    public abstract float Evaluate();


    public abstract void Execute();
}
