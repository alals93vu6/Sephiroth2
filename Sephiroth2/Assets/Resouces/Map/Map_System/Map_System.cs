using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Map_System : MonoBehaviour
{
    [Header("地圖物件")]
    [SerializeField] public GameObject[] Map;
    //00 是起始地圖
    //05 是小黑房間
    [Header("黑幕物件")]
    [SerializeField] public GameObject shady;
    [Header("篝火物件")]
    [SerializeField] public GameObject recover;
    [SerializeField] public static bool is_next_map = false;
    [SerializeField] public static int Map_level = 0;

    [Header("地圖狀態")]
    [SerializeField] public static bool Start_map = true;
    [SerializeField] public static bool Basic_map = false;
    [SerializeField] public static bool Black_map = false;
    [SerializeField] public static bool Recover_map = false;
    [SerializeField] public static bool Boss_map = false;


    int new_map;
    public static int old_a = 0;

    // Start is called before the first frame update
    void Start()
    {
        load_Map(old_a);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(is_next_map);
        // Debug.Log(Map_level);
        load_test();
        next_basic_map(1, 4, 9);
    }

    void load_Map(int new_a)
    {
        DestroyWithTag("Map");
        Instantiate(Map[old_a]);
        Instantiate(shady);
        old_a = new_a;
        // Debug.Log(new_a);
        is_next_map = false;
    }

    void load_test() //測試用
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            load_Map(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            load_Map(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            load_Map(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            load_Map(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            load_Map(4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            load_Map(5);
        }
    }
    void DestroyWithTag(string destroyTag) //刪除地圖物件
    {
        GameObject[] destroyObject;
        destroyObject = GameObject.FindGameObjectsWithTag(destroyTag);
        foreach (GameObject oneObject in destroyObject)
            Destroy(oneObject);
    }
    void next_basic_map(int black_level, int recover_level, int boss_level) // set_level
    {
        if (is_next_map)
        {
            if (Map_level != black_level) //一般戰鬥
            {
                map_reader(false, true, false, false, false);

                if (Map_level % recover_level == 0)//恢復點
                {
                    Debug.Log("Recover_level");
                    map_reader(false, false, false, true, false);
                    Instantiate(recover);
                }

                if (Map_level == boss_level) //Boss房間
                {
                    Debug.Log("Boss_level");
                    map_reader(false, false, false, false, true);
                }

                new_map = Random.Range(1, 5);
                load_Map(new_map);
                load_Map(new_map);
                Map_level++;
            }
            if (Map_level == black_level)//小黑取得
            {
                map_reader(false, false, true, false, false);
                load_Map(5);
                load_Map(5);
                Map_level++;
            }
        }
    }
    public void is_next_map_button() //按鈕執行用
    {
        is_next_map = true;
    }
    void map_reader(bool start, bool basic, bool black, bool recover, bool boss)
    {
        Start_map = start;
        Basic_map = basic;
        Black_map = black;
        Recover_map = recover;
        Boss_map = boss;
    }
}
