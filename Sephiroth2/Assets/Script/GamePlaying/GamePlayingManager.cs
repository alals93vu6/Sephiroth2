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
    [SerializeField] public MonsterGeneric[] _MonsterGenerics;
    // Start is called before the first frame update
    void Start()
    {
        EventBus.Subscribe<StopTruntableDetected>(OnStopTruntable);
        EventBus.Subscribe<NewRoundDetected>(OnNewRound);
        EventBus.Subscribe<OnEnemyActorDetected>(OnEnemyActor);
        
        _turntableGenerics = FindObjectsOfType<TurntableGeneric>();
        _MonsterGenerics = FindObjectsOfType<MonsterGeneric>();
        _playerManager = FindObjectOfType<PlayerManager>();
    }

    private void OnEnemyActor(OnEnemyActorDetected obj)
    {
        var PlayerHP = FindObjectOfType<HpTest>();
        PlayerHP.HpHit();
    }

    private void OnNewRound(NewRoundDetected obj)
    {
        _playerManager._playerActor.changeState(new PlayerRound());
        _playerManager._playerActor.RemainingDefense = 3f;
        Array.ForEach(_MonsterGenerics,monsters => monsters.OnPassRound());
    }

    private void OnStopTruntable(StopTruntableDetected obj)
    {
        Array.ForEach(_turntableGenerics,turnyable => turnyable.OnChessEvent());
    }
    
    
}
