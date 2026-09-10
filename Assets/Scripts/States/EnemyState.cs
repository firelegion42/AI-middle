using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyState: MonoBehaviour, IBehaviour
{

    [SerializeField] protected EnemyHealth _health;
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected NavMeshAgent agent;     
    protected StateManager stateManager;
    protected float moveSpeedCoef;


    public void Init(StateManager state)
    {
        stateManager = state;
    }

    public abstract float Evaluate();


    public abstract void Execute();
  
}
