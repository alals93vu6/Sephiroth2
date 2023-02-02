using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIManager : MonoBehaviour
{

    [SerializeField] private PlayerManager _playerManager;

    [SerializeField] private GameObject ActorObj;
    [SerializeField] private GameObject DefencsobjA;
    [SerializeField] private GameObject DefencsobjB;
    // Start is called before the first frame update
    void Start()
    {
        _playerManager = FindObjectOfType<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        ShowActorPoints();
        ShowDefecnePoints();
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

    private void ShowDefecnePoints()
    {
        if (_playerManager._playerActor.RemainingDefense == 3)
        {
            DefencsobjA.SetActive(true);
            DefencsobjB.SetActive(true);
        }
        else if (_playerManager._playerActor.RemainingDefense == 2)
        {
            DefencsobjA.SetActive(false);
            DefencsobjB.SetActive(true);
        }
        else
        {
            DefencsobjA.SetActive(false);
            DefencsobjB.SetActive(false);
        }
    }
}
