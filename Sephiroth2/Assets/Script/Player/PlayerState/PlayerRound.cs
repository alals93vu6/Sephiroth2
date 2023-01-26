using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRound : IState
{
    public void OnEnterState(object action)
    {
        var actor = (PlayerActor) action;
        //throw new System.NotImplementedException();
    }

    public void OnStayState(object action)
    {
        var actor = (PlayerActor) action;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            actor._pointerManager.OnStopPointer();
            actor.changeState(new EnemyRound());
        }
    }

    public void OnExitState(object action)
    {
        var actor = (PlayerActor) action;
        //throw new System.NotImplementedException();
    }
}
