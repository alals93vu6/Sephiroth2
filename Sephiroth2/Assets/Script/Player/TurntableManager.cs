using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurntableManager : MonoBehaviour
{
    [SerializeField] public int SummonState;
    // Start is called before the first frame update
    void Start()
    {
        SummonState = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SimonCheck()
    {
        
    }

    public void OnPlayerSummon()
    {
        int NowSummon = (SummonState == 1) ? PlayerPrefs.GetInt("NowSummonA") : (SummonState == 2) ? PlayerPrefs.GetInt("NowSummonB") : 0;

        switch (NowSummon)
        {
            case 0:
                GameObject.FindWithTag("Summoner");
                break;
            case 1:
                break;
            case 2:
                break;
            case 3:
                break;
        }
    }
    
    
}
