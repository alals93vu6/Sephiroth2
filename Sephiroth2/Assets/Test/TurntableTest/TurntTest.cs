using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurntTest : MonoBehaviour
{
    [SerializeField] public bool IsRun;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsRun){transform.Rotate(0,0,-150 * Time.deltaTime);}

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (IsRun){IsRun = false;}
            else{IsRun = true;}
        }
    }
}
