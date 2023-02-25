﻿using System.Collections;
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
    [SerializeField] public static bool is_next_map = false;
    [SerializeField] public int Map_level = 0;
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
        Debug.Log(is_next_map);
        Debug.Log(Map_level);
        load_test();
        next_basic_map(2);
    }

    void load_Map(int new_a)
    {
        DestroyWithTag("Map");
        Instantiate(Map[old_a]);
        Instantiate(shady);
        old_a = new_a;
        Debug.Log(new_a);
        is_next_map = false;
    }

    void load_test()
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
    void DestroyWithTag(string destroyTag)
    {
        GameObject[] destroyObject;
        destroyObject = GameObject.FindGameObjectsWithTag(destroyTag);
        foreach (GameObject oneObject in destroyObject)
            Destroy(oneObject);
    }
    void next_basic_map(int black_level)
    {
        if (Map_level == black_level)
        {
            load_Map(5);
            load_Map(5);
            Map_level++;
        }
        if (is_next_map && Map_level != black_level)
        {
            new_map = Random.Range(1, 5);
            load_Map(new_map);
            load_Map(new_map);
            Map_level++;
        }
    }
    public void is_next_map_button()
    {
        is_next_map = true;
    }

}
