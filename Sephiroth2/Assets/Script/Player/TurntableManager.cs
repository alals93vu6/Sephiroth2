using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurntableManager : MonoBehaviour
{
    [Header("物件")]
    [SerializeField] public int SummonState;
    [SerializeField] public GameObject[] Summoner;
    //[SerializeField] public GameObject[] SummonerTurntable;
    [Header("Offset")]
    [SerializeField] private Vector3 SummonerOffset;
    [SerializeField] private Vector3 TurntableOffset;
    // Start is called before the first frame update
    void Start()
    {
        SummonState = 0;
        
        PlayerPrefs.SetInt("NowSummonA",1);
        PlayerPrefs.SetInt("NowSummonB",2);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            OnPlayerSummon();
        }
    }

    public void SimonCheck()
    {
        
    }

    public void OnPlayerSummon()
    {
        int NowSummon = (SummonState == 1) ? PlayerPrefs.GetInt("NowSummonA") : (SummonState == 2) ? PlayerPrefs.GetInt("NowSummonB") : 0;
        Destroy(GameObject.FindWithTag("Summoner"));
        //Destroy(GameObject.FindWithTag("SummonerTurntable"));
        Instantiate(Summoner[NowSummon], this.transform.position, this.transform.rotation);
        //Instantiate(SummonerTurntable[NowSummon], this.transform.position, this.transform.rotation);
    }
    /*
    var NowSummoner = GameObject.FindWithTag("Summoner");
    var NowSummonerSkill = GameObject.FindWithTag("SummonerTurntable");
    */
}
