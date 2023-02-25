using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_System : MonoBehaviour
{
    [Header("地圖物件")]
    [SerializeField] public GameObject[] Map;
    [SerializeField] public GameObject shady;
    public int old_a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        load_test();
    }

    void load_scenes(int new_a)
    {
        Map[old_a].SetActive(false);
        Instantiate(shady);
        Map[new_a].SetActive(true);
        old_a = new_a;
        Debug.Log(new_a);
    }

    void load_test()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            load_scenes(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            load_scenes(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            load_scenes(2);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            load_scenes(3);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            load_scenes(4);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            load_scenes(5);
        }
    }
}
