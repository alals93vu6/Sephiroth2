using System.Collections;
using System.Collections.Generic;
using Project;
using Project.Event;
using UnityEngine;

public class Event_OwlAttack : TurntableGeneric
{
    public override void OnPointed()
    {
        var AttackNumber = FindObjectOfType<PlayerManager>();
        AttackNumber.CauseDamage = 1;
        EventBus.Post(new PlayerAttackDetected());
    }
}
