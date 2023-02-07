using System.Collections;
using System.Collections.Generic;
using Project;
using Project.Event;
using UnityEngine;

public class EventSummon : TurntableGeneric
{
    [SerializeField] public int ThisState;
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
        var OnSummon = FindObjectOfType<PlayerManager>();
        if (OnSummon._turntable.SummonState == ThisState)
        {
            OnSummon.CauseDamage = 1;
            EventBus.Post(new PlayerAttackDetected());
        }
        else
        {
            OnSummon._turntable.OnPlayerSummon(ThisState);
        }
    }
}
