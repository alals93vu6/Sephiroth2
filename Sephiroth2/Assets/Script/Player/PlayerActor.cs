﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActor : MonoBehaviour
{
    [SerializeField] public IState CurrenState = new PlayerRound();
    [SerializeField] public int NowActorPoints;
    [SerializeField] public float RemainingDefense;

    public PointerManager _pointerManager;
    // Start is called before the first frame update
    void Start()
    {
        changeState(new PlayerRound());
        _pointerManager = FindObjectOfType<PointerManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        CurrenState.OnStayState(this);
        if (Input.GetKeyDown(KeyCode.S))
        {
            OnPlayerDefense();
        }
    }

    public void OnPlayerDefense()
    {
        RemainingDefense--;
        RemainingDefense = Mathf.Clamp(RemainingDefense, 0, 3);
        if (RemainingDefense > 0)
        {
            Debug.Log("SSS");
        }
    }


    public void changeState(IState nextState)
    {
        //Debug.Log("StateChange");
        CurrenState.OnExitState(this);
        nextState.OnEnterState(this);
        CurrenState = nextState;
    }
}
