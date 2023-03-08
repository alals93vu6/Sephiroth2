using System.Collections;
using System.Collections.Generic;
using Map;
using UnityEngine;

public class map_time : MonoBehaviour
{
    public GameObject mapmanager;

    public GameObject[] map;
    // Start is called before the first frame update
    void Start()
    {
        map = GameObject.FindGameObjectsWithTag("ChooseMap");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            Map_System.is_map_time = !Map_System.is_map_time;
        }
        ResetMap();
        if (Map_System.is_map_time == true)
        {
            SetActiveWithTag(true);
        }
        if (Map_System.is_map_time == false)
        {
            SetActiveWithTag(false);
        }
    }
    void SetActiveWithTag(bool now_bool) //刪除地圖物件
    {
        foreach (GameObject oneObject in map)
            if (oneObject != null)
            {
                oneObject.SetActive(now_bool);
            }
        ;
    }

    void ResetMap()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log("rest");
            mapmanager.GetComponent<MapManager>().GenerateNewMap();
            Map_System.is_map_time = true;
            Map_System.Map_level = 0;
            map = GameObject.FindGameObjectsWithTag("ChooseMap");
        }
    }
}
