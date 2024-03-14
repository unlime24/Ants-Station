using UnityEngine;

public abstract class State : MonoBehaviour
{
    public virtual void Enter(){}
    public virtual void UpdateState(){}
    public virtual void Exit(){}
}
