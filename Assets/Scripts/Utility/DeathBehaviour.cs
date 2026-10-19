using UnityEngine;

public class DeathBehaviour : EnemyBehaviour
{

    [SerializeField] private float _deathTimer;
    private bool _isDead;    

    public override float Evaluate()
    {
        if(_isDead == true)
        {
            return float.MaxValue;
        }
        else
        {
            return 0f;
        }
    }

    public void TriggerDeath()
    {
        _isDead = true;
    }

    public override void Execute()
    {
        agent.isStopped = true;

        Debug.Log("Entered dead");
        animator.SetTrigger("Dead");

       

        Destroy(gameObject, _deathTimer);
    }
}
