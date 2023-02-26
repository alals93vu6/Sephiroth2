using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveButton : MonoBehaviour
{
    public static bool is_end = false;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        is_end = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(is_end);
        SHOWHIDE();
        if (Input.GetKeyDown(KeyCode.N))
        {
            is_end = true;
        }
    }
    void SHOWHIDE()
    {
        if (is_end == false)
        {
            button.SetActive(false);
        }
        else
        {
            button.SetActive(true);
        }
    }
}


