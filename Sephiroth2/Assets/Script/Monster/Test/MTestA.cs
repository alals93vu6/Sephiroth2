using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MTestA : MonsterGeneric
{
    [SerializeField] private Text CDTest;
    // Start is called before the first frame update
    
    // Update is called once per frame
    public override void Update()
    {
        base.Update();
        CDTest.text = "CD：" + AttackCD;
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
