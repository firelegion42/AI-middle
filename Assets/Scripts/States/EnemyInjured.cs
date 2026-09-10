using UnityEngine;

public class EnemyInjuredState : EnemyState
{
    [SerializeField] GameObject[] hideTargets;
    [SerializeField] protected float injuredThreshold;

    public override float Evaluate()
    {
        if(_health.HealthPercent <= injuredThreshold)
        {
            return 50f;
        }
        else
        {
            return 0f;
        }
    }

    public override void Execute()
    {
        moveSpeedCoef = 0.5f;

        agent.speed = moveSpeed * moveSpeedCoef;

        int currentzone = Random.Range(0, hideTargets.Length);

        agent.destination = hideTargets[currentzone].transform.position;

        Debug.Log("Entered Injured");
    }
}
