using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyHealthyState : EnemyState
{
    [SerializeField] protected GameObject[] targets;

    public override float Evaluate()
    {
        return 1f;
    }

    public override void Execute()
    {
        Debug.Log("Entered Healthy");

        moveSpeedCoef = 1;

        agent.speed = moveSpeed * moveSpeedCoef;

        int currentzone = Random.Range(0, targets.Length);

        agent.destination = targets[currentzone].transform.position;

        Debug.Log("Current patrol target is " + currentzone);
    }

   
}
