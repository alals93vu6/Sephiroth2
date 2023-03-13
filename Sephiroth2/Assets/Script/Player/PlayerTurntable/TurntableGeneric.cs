using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurntableGeneric : MonoBehaviour
{
    [SerializeField] public bool IsChess;
    [SerializeField] private string FindName;
    void Start()
    {
        FindName = this.gameObject.name + "Icon";
        ChangeIcon(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(FindName);
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

    public virtual void ChangeIcon(bool Display)
    {
        var IconCtrl = GameObject.Find(FindName).GetComponent<Image>();
        if (Display)
        {
            IconCtrl.color = new Color(255, 255, 255, 1);
        }
        else
        {
            IconCtrl.color = new Color(255, 255, 255, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Pointer")
        {
            IsChess = true;
            ChangeIcon(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Pointer")
        {
            IsChess = false;
            ChangeIcon(false);
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
