using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creat_Effect_Player : MonoBehaviour
{
    [Header("特效位置")]
    [SerializeField] public GameObject Buff_Recover_pos;
    [SerializeField] public GameObject Buff_Armor_pos;
    [Header("特效物件")]
    [SerializeField] public GameObject Buff_Recover;
    [SerializeField] public GameObject Buff_Armor;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Creat(Buff_Recover, Buff_Recover_pos);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Creat(Buff_Armor, Buff_Armor_pos);
        }

    }
    public void Creat(GameObject Effect, GameObject pos)
    {
        Instantiate(Effect, pos.transform.position, new Quaternion(0, 0, 0, 0));
    }
}
