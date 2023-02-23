using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WolfFettle :FettleGeneric
{
    public override void OnStart()
    {
        _hpData.ShowPlayerHP = GameObject.Find("SummonAHpShow").GetComponent<Image>();
    }
}
