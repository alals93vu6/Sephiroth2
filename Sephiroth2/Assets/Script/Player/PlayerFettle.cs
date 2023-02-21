using System.Collections;
using System.Collections.Generic;
using Project.PlayerHpData;
using UnityEngine;
using UnityEngine.UI;

public class PlayerFettle : MonoBehaviour
{
    [SerializeField] public HpData _hpData;
    // Start is called before the first frame update
    void Start()
    {
        _hpData.ShowPlayerHP = GameObject.Find("PlayerHpShow").GetComponent<Image>();
        _hpData.NowHP =  _hpData.MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            HpHit(10);  
        }
        _hpData.NowHP = Mathf.Clamp(_hpData.NowHP, 0, _hpData.MaxHP);
        _hpData.ShowHPFloat =  _hpData.NowHP /  _hpData.MaxHP;
        _hpData.ShowPlayerHP.fillAmount = Mathf.Lerp( _hpData.ShowPlayerHP.fillAmount,  _hpData.ShowHPFloat, 0.02f);
    }

    public void HpHit(float GetDamage)
    {
        _hpData.NowHP -= GetDamage;
    }
}
