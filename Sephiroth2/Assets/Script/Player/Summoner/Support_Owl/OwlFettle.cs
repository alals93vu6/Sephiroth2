﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OwlFettle : FettleGeneric
{
    public override void OnStart()
    {
        _hpData.ShowPlayerHP = GameObject.Find("SummonBHpShow").GetComponent<Image>();
    }
}
