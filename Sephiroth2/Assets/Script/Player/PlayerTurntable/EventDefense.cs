using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventDefense : TurntableGeneric
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public override void OnPointed()
    {
        var player = FindObjectOfType<PlayerManager>();
        player._playerFettle._hpData.ArmorValue += player._playerFettle._hpData.ArmorDefense;
    }
}
