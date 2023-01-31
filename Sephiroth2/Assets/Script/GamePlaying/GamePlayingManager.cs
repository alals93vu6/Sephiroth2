using System;
using System.Collections;
using System.Collections.Generic;
using Project;
using Project.Event;
using UnityEngine;

public class GamePlayingManager : MonoBehaviour
{
    [SerializeField] private PlayerManager _playerManager;
    [SerializeField] public TurntableGeneric[] _turntableGenerics;
    // Start is called before the first frame update
    void Start()
    {
        EventBus.Subscribe<StopTruntableDetected>(OnStopTruntable);
        EventBus.Subscribe<NewRoundDetected>(OnNewRound);
        
        _turntableGenerics = FindObjectsOfType<TurntableGeneric>();
        _playerManager = FindObjectOfType<PlayerManager>();
    }

    private void OnNewRound(NewRoundDetected obj)
    {
        _playerManager._playerActor.changeState(new PlayerRound());
        _playerManager._playerActor.RemainingDefense = 3f;
    }

    private void OnStopTruntable(StopTruntableDetected obj)
    {
        Array.ForEach(_turntableGenerics,turnyable => turnyable.OnChessEvent());
        /*
        foreach (var VARIABLE in _turntableGenerics)
        {
            VARIABLE.OnChessEvent();
        }
        */
    }
}
