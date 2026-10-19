using NUnit.Framework.Constraints;
using UnityEngine;

public class ChaseBehaviour : EnemyBehaviour
{
    public override float Evaluate()
    {
        var distance = Vector3.Distance(transform.position, _player.position);
        var utility = _utilityCurve.Evaluate(1 - distance / _radius);
            return Mathf.Clamp01(utility);
        
    }

    public override void Execute()
    {
        animator.SetInteger("CurrentState", 2);

        moveSpeedCoef = 1f;

        agent.speed = moveSpeed * moveSpeedCoef;

        Debug.Log("Entered Patrol");

        agent.destination = _player.transform.position;
    }
}
