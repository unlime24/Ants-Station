using UnityEngine;

public class ChillState : State
{
    public override void Enter()
    {
        Debug.LogError("Муравей начал чилить!");
    }
    
    public override void UpdateState()
    {
        Debug.LogError("Муравей чилит!");
    }

    public override void Exit()
    {
        Debug.LogError("Муравей закончил чилить!");
    }
}
