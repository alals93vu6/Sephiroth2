using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActor : MonoBehaviour
{
    [SerializeField] private IState CurrenState = new PlayerRound();

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
    }
    
    

    public void changeState(IState nextState)
    {
        //Debug.Log("StateChange");
        CurrenState.OnExitState(this);
        nextState.OnEnterState(this);
        CurrenState = nextState;
    }
}
