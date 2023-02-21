using UnityEngine;
using UnityEngine.UI;
namespace Project.PlayerHpData
{
    [CreateAssetMenu(fileName = "FILENAME", menuName = "Playerdata_HP", order = 0)]
    
    [System.Serializable]
    public class HpData : ScriptableObject
    {
        [SerializeField] public Image ShowPlayerHP;
        [SerializeField] public float ShowHPFloat;
        [SerializeField] public float MaxHP;
        [SerializeField] public float NowHP;
        [SerializeField] public float ArmorValue;
    }
}

