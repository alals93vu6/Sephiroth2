using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creat_Effect_Player : MonoBehaviour
{
    [Header("玩家一號位")]
    [SerializeField] public GameObject Buff_Recover_pos_1;
    [SerializeField] public GameObject Buff_Armor_pos_1;
    [Header("玩家二號位")]
    [SerializeField] public GameObject Buff_Recover_pos_2;
    [SerializeField] public GameObject Buff_Armor_pos_2;
    [Header("玩家三號位")]
    [SerializeField] public GameObject Buff_Recover_pos_3;
    [SerializeField] public GameObject Buff_Armor_pos_3;

    [Header("敵人一號位")]
    [SerializeField] public GameObject enemy_Pos_1;

    [Header("敵人二號位")]
    [SerializeField] public GameObject enemy_Pos_2;


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
            Creat(Buff_Recover, Buff_Recover_pos_1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Creat(Buff_Armor, Buff_Armor_pos_1);
        }

    }
    public static void Creat(GameObject Effect, GameObject pos)
    {
        Instantiate(Effect, pos.transform.position, new Quaternion(0, 0, 0, 0));
    }
}
