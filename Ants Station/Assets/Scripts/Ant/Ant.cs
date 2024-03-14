using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Ant : MonoBehaviour
{
    [SerializeField] private AntStateMachine _stateMachine;
    [Space] [SerializeField] private State _chillState;
    [SerializeField] private State _mineState;

    [SerializeField] private Transform _resourcePoint;

    public Transform ResourcePoint => _resourcePoint;
    
    

    private void Start()
    {
        _stateMachine.Initialize(_chillState);
        
        if(_stateMachine.CurrentState != null)
            _stateMachine.CurrentState.Enter();
    }

    private void Update()
    {
        StateChange();
        _stateMachine.CurrentState.UpdateState();
    }

    private void StateChange()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            _stateMachine.SetState(_mineState);
        }
        
        if (Input.GetKeyDown(KeyCode.C))
        {
            _stateMachine.SetState(_chillState);
        }
    }
}
