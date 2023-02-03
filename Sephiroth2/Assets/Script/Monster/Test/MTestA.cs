using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MTestA : MonsterGeneric
{
    // Start is called before the first frame update
    public override void Start()
    {
        base.Start();
        Debug.Log("Hi");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OnPassRound()
    {
        base.OnPassRound();
        Debug.Log("PassChike");
    }
}
