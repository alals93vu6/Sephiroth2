using System.Collections;
using System.Collections.Generic;
using Project;
using Project.Event;
using Project.MonsterData;
using UnityEngine;
using UnityEngine.UI;

public class MonsterGeneric : MonoBehaviour
{
    [Header("數值")] 
    [SerializeField] public float EnemyMaxHP;
    [SerializeField] public float EnemyNowHP;
    [SerializeField] public int AttackCD;
    [SerializeField] public int AttackCycle;
    [SerializeField] public int AttackDamage;
    [SerializeField] public int PositionalOrder;

    [Header("UI數值")] 
    [SerializeField] public Image ShowHPimg;
    [SerializeField] public float ShowHPNumber;
    
    // Start is called before the first frame update
    public virtual void Start()
    {
        AttackCD = AttackCycle;
        EnemyNowHP = EnemyMaxHP;
        HPUISet();
        LocationCheck();
    }

    // Update is called once per frame
    public virtual void Update()
    {
        ShowEnemyHP();
    }

    public virtual void OnPassRound()
    {
        var StrikeTarget = FindObjectOfType<LocationManager>();
        if (AttackCD == 0)
        {
            AttackCD = AttackCycle;
            StrikeTarget.PlayerOnAttackDetected(AttackDamage);
        }
        else
        {
            AttackCD--;
        }
    }

    public virtual void HPUISet()
    {
        if (PositionalOrder == 0)
        {
            ShowHPimg = GameObject.Find("EnemyHpShowA").GetComponent<Image>();
        }
        else
        {
            if (PositionalOrder == 1)
            {
                ShowHPimg = GameObject.Find("EnemyHpShowB").GetComponent<Image>();
            }
            else
            {
                ShowHPimg = GameObject.Find("EnemyHpShowC").GetComponent<Image>();
            } 
        }
    }

    public virtual void LocationCheck()
    {
        var nowLocation = FindObjectOfType<LocationManager>();
        nowLocation.MonsterLocation[PositionalOrder] = this.gameObject.GetComponent<MonsterGeneric>();
    }

    public virtual void OnGitHit(float GetDamage)
    {
        var nowLocation = FindObjectOfType<LocationManager>();
        EnemyNowHP -= GetDamage;
        if (EnemyNowHP <= 0)
        {
            nowLocation.MonsterLocation[PositionalOrder] = null;
            nowLocation.CheckSurvivalEnemy();
        }
    }

    public virtual void ShowEnemyHP()
    {
        EnemyNowHP = Mathf.Clamp(EnemyNowHP, 0, EnemyMaxHP);
        ShowHPNumber = EnemyNowHP/EnemyMaxHP;
        ShowHPimg.fillAmount = Mathf.Lerp(ShowHPimg.fillAmount, ShowHPNumber, 0.06f);
    }

}
