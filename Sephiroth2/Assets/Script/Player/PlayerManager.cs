using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [Header("數值")]
    [SerializeField] public float CauseDamage;

    [SerializeField] private int MinNumber;
    
    
    [Header("物件")]
    [SerializeField] public PlayerActor _playerActor;
    [SerializeField] public PlayerFettle _playerFettle;
    [SerializeField] public TurntableManager _turntable;
    // Start is called before the first frame update
    void Start()
    {
        _playerActor = FindObjectOfType<PlayerActor>();
        _playerFettle = FindObjectOfType<PlayerFettle>();
        _turntable = FindObjectOfType<TurntableManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GetCompareNumber()
    {
        var HpGetTest = FindObjectOfType<LocationManager>();
        float CompareA, CompareB, CompareC;
        if (HpGetTest.PlayerLocation[0] == null)
        {
            CompareA = 99;
        }
        else
        {
            CompareA = HpGetTest.PlayerLocation[0]._hpData.NowHP;
        }
        
        if (HpGetTest.PlayerLocation[1] == null)
        {
            CompareB = 99;
        }
        else
        {
            CompareB = HpGetTest.PlayerLocation[1]._hpData.NowHP;
        }
        
        if (HpGetTest.PlayerLocation[2] == null)
        {
            CompareC = 99;
        }
        else
        {
            CompareC = HpGetTest.PlayerLocation[2]._hpData.NowHP;
        }
        OnCompareNumber(CompareA,CompareB,CompareC);
        Debug.Log(HpGetTest.PlayerLocation[MinNumber]._hpData.NowHP);
    }

    private void OnCompareNumber(float NumberA,float NumberB,float NumberC)
    {
        if (NumberA < NumberB && NumberA < NumberC)
        {
            MinNumber = 0;
        }
        
        if (NumberB < NumberA && NumberB < NumberC)
        {
            MinNumber = 1;
        }
        
        if (NumberC < NumberB && NumberC < NumberA)
        {
            MinNumber = 2;
        }
    }


}
