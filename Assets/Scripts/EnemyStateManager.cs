using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;

public class EnemyStateManager : MonoBehaviour
{
   private EnemyState currentState;
 [SerializeField]  private Settings _enemySettings;
   private Health _health;
   private NavMeshAgent _agent;
  [SerializeField]  private GameObject[] targets;

    public Health EnemyHealth => _health;
    public Settings EnemySettings => _enemySettings;

    public NavMeshAgent Agent => _agent;

    private  EnemyHealthyState _healthyState = new EnemyHealthyState();
    private  EnemyHitState _hitState = new EnemyHitState();
    private EnemyInjuredState _injuredState = new EnemyInjuredState();

    public EnemyHealthyState HealthyState => _healthyState;
    public EnemyHitState HitState => _hitState;
    public EnemyInjuredState InjuredState => _injuredState;




    public GameObject[] Targets => targets; 

    public void Start()
    {
        currentState = HealthyState;

        _agent = GetComponent<NavMeshAgent>();
        _health = GetComponent<Health>();

        currentState.EnterState(this);
    }

    public void HealthChanged(float health)
    {
        currentState.OnHealthChanged(this, health);
    }

    public void Update()
    {
        currentState.UpdateState(this);
    }
      
   public void SwitchState(EnemyState state)
    {
        currentState = state;
        state.EnterState(this);
    }
}
