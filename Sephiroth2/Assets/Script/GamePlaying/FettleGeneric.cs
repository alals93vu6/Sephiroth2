using System.Collections;
using System.Collections.Generic;
using Project.PlayerHpData;
using UnityEngine;
using UnityEngine.UI;

public class FettleGeneric : MonoBehaviour
{
    [SerializeField] public HpData _hpData;
    // Start is called before the first frame update
    void Start()
    {
        OnStart();
        _hpData.NowHP =  _hpData.MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        OnUpdate();
        _hpData.NowHP = Mathf.Clamp(_hpData.NowHP, 0, _hpData.MaxHP);
        _hpData.ShowHPFloat =  _hpData.NowHP /  _hpData.MaxHP;
        _hpData.ShowPlayerHP.fillAmount = Mathf.Lerp( _hpData.ShowPlayerHP.fillAmount,  _hpData.ShowHPFloat, 0.02f);
    }

    public virtual void OnStart()
    {
        _hpData.ShowPlayerHP = GameObject.Find("PlayerHpShow").GetComponent<Image>();
    }

    public virtual void OnUpdate()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            HpHit(10);  
        }
    }

    public virtual void HpHit(float GetDamage)
    {
        if (_hpData.ArmorValue == 0)
        {
            _hpData.NowHP -= GetDamage;
        }
        else
        {
            if (GetDamage >= _hpData.ArmorValue)
            {
                _hpData.NowHP -= GetDamage - _hpData.ArmorValue;
                _hpData.ArmorValue = 0f;
            }
            else
            {
                _hpData.ArmorValue -= GetDamage;
            }
        }

        
    }
}
