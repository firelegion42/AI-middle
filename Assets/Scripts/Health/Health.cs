using UnityEngine;
using UnityEngine.Events;

public abstract class Health : MonoBehaviour
{
    [SerializeField] protected float _maxHealth;
    [SerializeField] protected float _hitThreshold;
    [SerializeField] protected float _injuredThreshold;
    protected float _currentHealth;
    protected bool _dead;

    public float CurrentHealth => _currentHealth;
    public float MaxHealth => _maxHealth;

    public bool Dead => _dead;

    public float HealthPercent => _currentHealth / _maxHealth;

    [SerializeField] public UnityEvent<float> healthChanged;
    [SerializeField] public UnityEvent death;

    private void Awake()
    {
        _currentHealth = _maxHealth;
    }

    public virtual void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        Debug.Log(_currentHealth);
        Debug.Log(HealthPercent);
        healthChanged.Invoke(CurrentHealth);
        if (_currentHealth <= 0)
        {
            _dead = true;
            death.Invoke();
            Death();
        }
    }

    public abstract void Death();
 
}
