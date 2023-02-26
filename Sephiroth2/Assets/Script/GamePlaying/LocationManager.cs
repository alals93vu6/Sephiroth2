using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocationManager : MonoBehaviour
{
    [SerializeField] public FettleGeneric[] PlayerLocation;
    [SerializeField] public int[] PlayerNowLocation;
    [SerializeField] public MonsterGeneric[] MonsterLocation;
    [SerializeField] private Transform P1, P2, P3, E1, E2, E3;

    
    // Start is called before the first frame update
    void Start()
    {
        StartSet();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayChangeLocation();
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
    }

    private void StartSet()
    {
        PlayerLocation[1] = GameObject.Find("PlayerManager").GetComponent<FettleGeneric>();
        PlayerLocation[1].StatyLocation = 1;
    }

    private void DisplayChangeLocation()
    {
        if (PlayerLocation[0] != null)
        {
            PlayerLocation[0].transform.position = Vector3.Lerp(PlayerLocation[0].transform.position,P1.position,0.05f);
        }
        if (PlayerLocation[1] != null)
        {
            PlayerLocation[1].transform.position = Vector3.Lerp(PlayerLocation[1].transform.position,P2.position,0.05f);
        }
        if (PlayerLocation[2] != null)
        {
            PlayerLocation[2].transform.position = Vector3.Lerp(PlayerLocation[2].transform.position,P3.position,0.05f);
        }
    }
}
