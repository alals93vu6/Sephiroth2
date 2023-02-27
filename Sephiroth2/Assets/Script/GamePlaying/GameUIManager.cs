using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{

    [SerializeField] private PlayerManager _playerManager;

    [SerializeField] private GameObject ActorObj;
    // Start is called before the first frame update
    void Start()
    {
        _playerManager = FindObjectOfType<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        ShowActorPoints();
    }

    private void ShowActorPoints()
    {
        if (_playerManager._playerActor.NowActorPoints == 1)
        {
            ActorObj.SetActive(true);
        }
        else
        {
            ActorObj.SetActive(false);
        }
    }
    
}
