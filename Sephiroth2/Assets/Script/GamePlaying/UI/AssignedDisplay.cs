using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignedDisplay : MonoBehaviour
{
    public void OnAssigned()
    {
        this.gameObject.SetActive(true);
    }

    public void ExitAssigned()
    {
        this.gameObject.SetActive(false);
    }
}
