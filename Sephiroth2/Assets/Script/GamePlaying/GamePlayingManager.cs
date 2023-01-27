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
        
        _turntableGenerics = FindObjectsOfType<TurntableGeneric>();
        _playerManager = FindObjectOfType<PlayerManager>();
    }

    private void OnStopTruntable(StopTruntableDetected obj)
    {
        foreach (var VARIABLE in _turntableGenerics)
        {
            VARIABLE.OnChessEvent();
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
