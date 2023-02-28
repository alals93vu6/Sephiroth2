using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OwlFettle : FettleGeneric
{
    [SerializeField] public bool DoubleReady;
    public override void OnStart()
    {
        base.OnStart();
    }

    public override void OnDead()
    {
        var Turntable = FindObjectOfType<TurntableManager>();
        var UI = FindObjectOfType<GameUIManager>();
        base.OnDead();
        Turntable.SummonerTurntable[1].SetActive(false);
        UI.TurntableUI[1].SetActive(false);
    }
}
