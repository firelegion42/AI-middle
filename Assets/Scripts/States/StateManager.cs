using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;

public class StateManager : MonoBehaviour
{
    private EnemyState _activeBehaviour;

    [SerializeField] private List<EnemyState> _behaviours;

    private void Awake()
    {
        _behaviours = new List<EnemyState>(GetComponents<EnemyState>());

        foreach (var behaviour in _behaviours)
        {
            behaviour.Init(this);
        }
    }

    private void Start()
    {
        DecideAction();
    }

    public void OnHealthChange(float currentHealth)
    {
        DecideAction();
    }

    public void DecideAction()
    {
        float maxUtility = 0;
        EnemyState targetBehaviour = null;

        foreach (var behaviour in _behaviours)
        {
            var utility = behaviour.Evaluate();
            if (maxUtility < utility)
            {
                Debug.Log(behaviour.name);
                maxUtility = utility;
                targetBehaviour = behaviour;
            }
        }
        _activeBehaviour = targetBehaviour;
        _activeBehaviour.Execute();
    }
}

