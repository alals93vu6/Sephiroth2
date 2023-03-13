using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurntableGeneric : MonoBehaviour
{
    [SerializeField] public bool IsChess;
    [SerializeField] private AssignedDisplay iconDisplay;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var FindName = this.gameObject.name + "Icon";
        Debug.Log(FindName);
    }

    public void OnChoseEvent()
    {
        if(IsChess)
        {
            OnPointed();
        }
    }
    
    public virtual void OnPointed()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Pointer")
        {
            IsChess = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Pointer")
        {
            IsChess = false;
        }
    }
    
    /*
    public void OnChoseDefense()
    {
        if(IsChess && Tagged)
        {
            Debug.Log("DDDDD");
        }
    }
    */
}
