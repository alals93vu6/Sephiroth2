﻿using System;
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
        PlayerLocation[3] = PlayerLocation[PlayerNowLocation[0]];
        PlayerLocation[4] = PlayerLocation[PlayerNowLocation[1]];
        PlayerLocation[PlayerNowLocation[0]] = PlayerLocation[4];
        PlayerLocation[PlayerNowLocation[1]] = PlayerLocation[3];
    }

    public void PlayerOnAttackDetected(float DamageNumber)
    {
        
        int NowStrikeLocation;
        if (PlayerLocation[0] != null)
        {
            NowStrikeLocation = 0;
        }
        else
        {
            if (PlayerLocation[1] != null)
            {
                NowStrikeLocation = 1;
            }
            else
            {
                NowStrikeLocation = 2;
            }
        }
        
        PlayerLocation[NowStrikeLocation].OnHit(DamageNumber);
        /*
        int NowStrikeLocation = 1;
        for (int i = 0; i < PlayerLocation.Length; i++)
        {
            if (PlayerLocation[i] != null)
            {
                NowStrikeLocation = i + 1;
                break;
            }
        }
        PlayerLocation[NowStrikeLocation]
        */
    }

    private void StartSet()
    {
        PlayerLocation[1] = GameObject.Find("PlayerManager").GetComponent<FettleGeneric>();
        PlayerLocation[1].StatyLocation = 1;
    }
}
