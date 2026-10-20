using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyBehaviour: MonoBehaviour, IBehaviour
{
    [SerializeField] protected AnimationCurve _utilityCurve;
    [SerializeField] protected float moveSpeed;
    [SerializeField] protected NavMeshAgent agent;
    [SerializeField] protected Transform _player;
    [SerializeField] protected float _radius;
    [SerializeField] protected Animator animator;
    
    protected BehaviourManager behaviourManager;
    
    protected float moveSpeedCoef;

    protected const float LookAround = 0f;

    protected const float Walk = 0.5f;

    protected const float Run = 1f;


    public void Init(BehaviourManager behaviour)
    {
        behaviourManager = behaviour;
    }

    public abstract float Evaluate();


    public abstract void Execute();
  
}
