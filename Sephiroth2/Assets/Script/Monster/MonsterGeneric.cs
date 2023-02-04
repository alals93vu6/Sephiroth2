using System.Collections;
using System.Collections.Generic;
using Project;
using Project.Event;
using Project.MonsterData;
using UnityEngine;

public class MonsterGeneric : MonoBehaviour
{
    [Header("數值")] 
    [SerializeField] public float EnemyMaxHP;
    [SerializeField] public float EnemyNowHP;
    [SerializeField] public int AttackCD;
    [SerializeField] public int AttackCycle;
    
    // Start is called before the first frame update
    public virtual void Start()
    {
        AttackCD = AttackCycle;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void OnPassRound()
    {
        if (AttackCD == 0)
        {
            AttackCD = AttackCycle;
            EventBus.Post(new OnEnemyActorDetected());
        }
        else
        {
            AttackCD--;
        }
    }
    
}
