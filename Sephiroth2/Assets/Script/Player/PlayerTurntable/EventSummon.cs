using System.Collections;
using System.Collections.Generic;
using Project;
using Project.Event;
using UnityEngine;

public class EventSummon : TurntableGeneric
{
    [SerializeField] public int ThisNo;
    [SerializeField] public bool IsSummon;
    public override void OnPointed()
    {
        if (IsSummon)
        {
            ChangeLocation();
        }
        else
        {
            CheckIsFirst();
        }
    }
    private void ChangeLocation()
    {
        string thisSummonerName = ThisNo == 1 ? "TheSummonerA" : "TheSummonerB";
        var ThisFettle = GameObject.Find(thisSummonerName).GetComponent<FettleGeneric>();
        ThisFettle.OnChangeLocation();
    }

    private void CheckIsFirst()
    {
        var locationM = FindObjectOfType<LocationManager>();
        var otherSummonerName = ThisNo == 1 ? "SummonB" : "SummonA";
        var thisSummonerName = ThisNo == 1 ? "TheSummonerA" : "TheSummonerB";
        var otherSummoner = GameObject.Find(otherSummonerName).GetComponent<EventSummon>();
        var targetIndex = otherSummoner.IsSummon ? 2 : 0;
        locationM.PlayerLocation[targetIndex] = GameObject.Find(thisSummonerName).GetComponent<FettleGeneric>();
        locationM.PlayerLocation[targetIndex].StatyLocation = otherSummoner.IsSummon ? 3 : 1;
        IsSummon = true;
    }
}
