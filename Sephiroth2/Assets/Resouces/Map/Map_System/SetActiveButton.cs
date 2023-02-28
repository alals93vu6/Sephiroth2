using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveButton : MonoBehaviour
{
    [SerializeField] public bool is_end = false;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        is_end = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(is_end);
        SHOWHIDE();
        test(KeyCode.N);
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
    void test(KeyCode key) // 切換按鈕狀態
    {
        if (Input.GetKeyDown(key))
        {
            is_end = true;
        }
    }
}


