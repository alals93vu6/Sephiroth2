using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creat_Effect_Player : MonoBehaviour
{
    public GameObject Buff_pos;

    public GameObject Buff_Recover;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Z");
            Creat_Effect(Buff_Recover);
        }
    }
    public void Creat_Effect(GameObject Effect)
    {
        Instantiate(Effect, Buff_pos.transform.position, new Quaternion(0, 0, 0, 0));
    }
}
