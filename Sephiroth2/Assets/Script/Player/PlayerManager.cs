using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private PlayerActor _playerActor;
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
