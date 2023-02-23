using System;
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

    public void PlayerOnAttackDetected(float DamageNumber)
    {
        int NowStrikeLocation;
        //判斷當前位置並選擇最前排傷害
        if (PlayerLocation[0] != null)
        {
            NowStrikeLocation = 1;
        }
        else
        {
            if (PlayerLocation[1] != null)
            {
                NowStrikeLocation = 2;
            }
            else
            {
                NowStrikeLocation = 3;
            }
        }
        Array.ForEach(PlayerLocation,OnStrike => OnStrike.OnHitDetected(NowStrikeLocation,DamageNumber));
    }

    private void StartSet()
    {
        
    }
}
