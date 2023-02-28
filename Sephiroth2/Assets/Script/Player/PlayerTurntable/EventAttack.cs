using System.Collections;
using System.Collections.Generic;
using Project;
using Project.Event;
using UnityEngine;

public class EventAttack : TurntableGeneric
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
        var AttackNumber = FindObjectOfType<LocationManager>();
        AttackNumber.EnemyOnAttackDetected(2);
    }
}
