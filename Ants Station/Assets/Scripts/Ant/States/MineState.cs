using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineState : State
{
    public override void Enter()
    {
        Debug.LogError("Муравей начал собирать ресурсы!");
    }

    public override void UpdateState()
    {
        Debug.LogError("Муравей собирает ресурсы!");
    }

    public override void Exit()
    {
        Debug.LogError("Муравей закончил собирать ресурсы!");
    }
}
