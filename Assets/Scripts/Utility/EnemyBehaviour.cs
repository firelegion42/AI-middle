using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyBehaviour: MonoBehaviour, IBehaviour
{
    [SerializeField] protected AnimationCurve _utilityCurve;
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected NavMeshAgent agent;
    [SerializeField] protected Transform _player;
    [SerializeField] protected float _radius;
    protected BehaviourManager behaviourManager;
    
    protected float moveSpeedCoef;


    public void Init(BehaviourManager behaviour)
    {
        behaviourManager = behaviour;
    }

    public abstract float Evaluate();


    public abstract void Execute();
  
}
