using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event_WolfDefnse : TurntableGeneric
{
    public override void OnPointed()
    {
        var wolf = FindObjectOfType<WolfManager>();
        wolf._summonerFettle._hpData.ArmorValue += wolf._summonerFettle._hpData.ArmorDefense;
    }
    
}
