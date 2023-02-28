using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WolfFettle :FettleGeneric
{
    public override void OnStart()
    {
        base.OnStart();
        _hpData.ArmorValue = 3;
    }
    
    public override void OnDead()
    {
        var Turntable = FindObjectOfType<TurntableManager>();
        var UI = FindObjectOfType<GameUIManager>();
        base.OnDead();
        Turntable.SummonerTurntable[0].SetActive(false);
        UI.TurntableUI[0].SetActive(false);
    }
}
