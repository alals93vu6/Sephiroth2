using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDefense : TurntableGeneric
{
    
    public override void OnPointed()
    {
        var player = FindObjectOfType<PlayerManager>();
        player._playerFettle._hpData.ArmorValue += player._playerFettle._hpData.ArmorDefense;
    }
}
