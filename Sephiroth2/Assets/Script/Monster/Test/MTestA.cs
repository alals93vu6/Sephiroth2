using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MTestA : MonsterGeneric
{
    [SerializeField] private Text CDTest;
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        ShowHPimg = GameObject.Find("EnemyHpShow").GetComponent<Image>();
    }

    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        CDTest.text = "AttackCD：" + AttackCD;
    }

    public override void OnPassRound()
    {
        base.OnPassRound();
    }

    public override void ShowEnemyHP()
    {
        base.ShowEnemyHP();
    }
}
