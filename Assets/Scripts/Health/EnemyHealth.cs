using UnityEngine;

public class EnemyHealth : Health, IDamageable
{

    public override void Death()
    {
        Debug.Log(_currentHealth);
        Debug.Log("Dead");
        Destroy(gameObject);
    }
}
