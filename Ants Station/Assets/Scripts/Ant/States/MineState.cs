using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineState : State
{
    public override void Enter()
    {
        FindResources();
    }

    private void FindResources()
    {
        throw new NotImplementedException();
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
