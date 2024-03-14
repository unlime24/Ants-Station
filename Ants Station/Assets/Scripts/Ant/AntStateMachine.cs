using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Ant))]
public class AntStateMachine : MonoBehaviour
{
    public State CurrentState { get; private set; }

    public void Initialize(State startState)
    {
        CurrentState = startState;
    }
    
    public void SetState(State state)
    {
        CurrentState.Exit();
        CurrentState = state;
        CurrentState.Enter();
    }
}
