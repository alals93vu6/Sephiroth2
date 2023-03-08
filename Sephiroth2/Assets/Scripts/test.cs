using System.Collections;
using System.Collections.Generic;
using Map;
using UnityEngine;

public class test : MonoBehaviour
{
    public GameObject ga;
    public static int roomcode;
    public GameObject mapmanager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(roomcode);
        chang();
        set();
    }
    void set()
    {
        if (roomcode == 1)
        {
            ga.SetActive(false);
        }
    }
    void chang()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("rest");
            mapmanager.GetComponent<MapManager>().GenerateNewMap();
        }
    }
}
