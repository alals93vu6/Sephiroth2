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
        EventLoad();
        ReLoadEventTuntable();
        
        _MonsterGenerics = FindObjectsOfType<MonsterGeneric>();
        _playerManager = FindObjectOfType<PlayerManager>();
    }

    private void EventLoad()
    {
        EventBus.Subscribe<StopTruntableDetected>(OnStopTruntable);
        EventBus.Subscribe<NewRoundDetected>(OnNewRound);
        EventBus.Subscribe<OnEnemyActorDetected>(OnEnemyActor);
        EventBus.Subscribe<PlayerAttackDetected>(OnPlayerAttack);
        EventBus.Subscribe<DefenseAttackDetected>(OnDefenseAttack);
        EventBus.Subscribe<PlayerOnSummonDetected>(OnPlayerSummon);
        EventBus.Subscribe<PlayerDeadDetected>(OnPlayerDead);
        EventBus.Subscribe<RoundStartDetected>(OnFightStart);
        EventBus.Subscribe<RoundOverDetected>(OnFightEnd);
    }

    private void OnFightStart(RoundStartDetected obj)
    {
        var PointerRun = FindObjectOfType<PointerManager>();
        var PointerShow = GameObject.Find("UIPointer").GetComponent<PointerUI>();
        PointerShow.gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        PointerRun.gameObject.transform.rotation = new Quaternion(0, 0, 0, 0);
        PointerRun.IsRun = true;
        PointerShow.MoveSpeed = -180f;
    }

    private void OnFightEnd(RoundOverDetected obj)
    {
        var PlayerWin = FindObjectOfType<Ending_effect>();
        var Pointer = FindObjectOfType<PointerManager>();
        var PointerShow = GameObject.Find("UIPointer").GetComponent<PointerUI>();
        Pointer.IsRun = false;
        PointerShow.MoveSpeed = 0f;
        PlayerWin.OnPlayerWin();
    }

    private void OnPlayerDead(PlayerDeadDetected obj)
    {
        var PlayerDead = FindObjectOfType<Ending_effect>();
        var Pointer = FindObjectOfType<PointerManager>();
        var PointerShow = FindObjectsOfType<PointerUI>();
        PlayerDead.OnPlayerDead();
        Pointer.IsRun = false;
        Array.ForEach(PointerShow,OnStop => OnStop.OnStopPointer());
        //Debug.Log("PlayerDead!!");
    }

    private void OnPlayerSummon(PlayerOnSummonDetected obj)
    {
        ReLoadEventTuntable();
    }

    private void OnPlayerAttack(PlayerAttackDetected obj)
    {
        var PlayerDamage = FindObjectOfType<PlayerManager>();
        Array.ForEach(_MonsterGenerics,GetDamage=>GetDamage.OnGitHit(PlayerDamage.CauseDamage));
    }

    private void OnEnemyActor(OnEnemyActorDetected obj)
    {
        //_playerManager._playerFettle.HpHit();
    }

    private void OnNewRound(NewRoundDetected obj)
    {
        _playerManager._playerActor.changeState(new PlayerRound());
        _playerManager._playerActor.RemainingDefense = 3f;
        Array.ForEach(_MonsterGenerics,monsters => monsters.OnPassRound());
    }
    
    private void OnDefenseAttack(DefenseAttackDetected obj)
    {
        //Array.ForEach(_turntableGenerics,turnyable => turnyable.OnChoseDefense());
    }
    private void OnStopTruntable(StopTruntableDetected obj)
    {
        Array.ForEach(_turntableGenerics,turnyable => turnyable.OnChoseEvent());
    }

    public void ReLoadEventTuntable()
    {
        _turntableGenerics = FindObjectsOfType<TurntableGeneric>();
    }


}
