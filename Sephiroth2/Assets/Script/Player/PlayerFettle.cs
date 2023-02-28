using System;
using System.Collections;
using System.Collections.Generic;
using Project;
using Project.Event;
using Project.PlayerHpData;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFettle : FettleGeneric
{
    public override void OnStart()
    {
        base.OnStart();
    }

    public override void OnDead()
    {
        EventBus.Post(new PlayerDeadDetected());
    }
}
