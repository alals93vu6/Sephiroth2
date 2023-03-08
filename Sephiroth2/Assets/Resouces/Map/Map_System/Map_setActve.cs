using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map_setActve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Map_System.is_map_time == true)
        {
            Destroy(this.gameObject);
        }
    }
}
