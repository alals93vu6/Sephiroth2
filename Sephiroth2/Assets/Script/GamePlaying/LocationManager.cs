using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationManager : MonoBehaviour
{
    [SerializeField] public FettleGeneric[] PlayerLocation;
    [SerializeField] public int[] PlayerNowLocation;
    [SerializeField] public MonsterGeneric[] MonsterLocation;

    
    // Start is called before the first frame update
    void Start()
    {
        StartSet();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnChangeLocation()
    {
        PlayerLocation[4] = PlayerLocation[0];
    }

    private void StartSet()
    {
        
    }
}
