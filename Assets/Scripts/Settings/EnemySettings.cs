using UnityEngine;

[CreateAssetMenu(fileName = "Settings", menuName = "Scriptable Objects/EnemySettings")]
public class EnemySettings : ScriptableObject
{
    [SerializeField] private float _enemyMaxHealth;

    [SerializeField] private float _enemyInjuredThreshold;

    [SerializeField] private float _enemyMoveSpeed;

    public float EnemyMaxHealth => _enemyMaxHealth;
    public float EnemyInjuredThreshold => _enemyInjuredThreshold;

    public float EnemyMovespeed => _enemyMoveSpeed;
}
