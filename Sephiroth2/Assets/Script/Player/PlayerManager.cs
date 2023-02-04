using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] public PlayerActor _playerActor;
    [SerializeField] public float CauseDamage;
    // Start is called before the first frame update
    void Start()
    {
        _playerActor = FindObjectOfType<PlayerActor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}
