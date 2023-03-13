using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AssignedDisplay : MonoBehaviour
{
    [SerializeField] private GameObject disPlayIcon;

    public void OnAssigned()
    {
        disPlayIcon.SetActive(false);
    }

    public void ExitAssigned()
    {
        disPlayIcon.SetActive(true);
    }
}
