using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class MainSceneSet : MonoBehaviour
{
    public int GamePlay_scenes_ID;
    /* [Tooltip("載入畫面編號")]
     [Header("載入畫面編號")]
     [SerializeField] private List<int> SceneIdex = new List<int>();*/

    /* [Header("按鈕當前位置")]
     [Range(0, 2)][SerializeField] public int MainSceneNum;
     [Header("提示提示位置")]
     [SerializeField] public List<Vector3> TipRectTransform = new List<Vector3>();
     [Header("提示物件")]
     [SerializeField] public RectTransform TipGameObject;*/
    private void Start()
    {

    }
    private void Update()
    {
        // Chang_TipTransform(TipGameObject.localPosition, 5);
        //keyset();
    }
    public async void LoadScene_Scene(int SceneID)
    {
        await Task.Delay(200);
        SceneManager.LoadScene(SceneID);
        if (SceneID == GamePlay_scenes_ID)
        {
            //Cursor.visible = false;
            SetAudio.audioNum = 1;
        }

    }
    public void ExitGame()
    {
        Application.Quit();
    }

    /*  void Chang_TipTransform(Vector3 now_vect3, float speed)
      {
          now_vect3 = TipGameObject.localPosition;

          TipGameObject.localPosition = Vector3.Lerp(now_vect3, TipRectTransform[MainSceneNum], speed * Time.deltaTime);


          if (MainSceneNum > TipRectTransform.Count)
          {
              MainSceneNum = 0;
          }
          if (MainSceneNum < 0)
          {
              MainSceneNum = 0;
          }
      }
      /* void keyset()
       {

           if (Input.GetKeyDown(KeyCode.DownArrow))
           {
               if (MainSceneNum == TipRectTransform.Count - 1)
               {
                   MainSceneNum = 0;
               }
               else
               {
                   MainSceneNum = MainSceneNum + 1;
               }

           }
           if (Input.GetKeyDown(KeyCode.UpArrow))
           {
               if (MainSceneNum == 0)
               {
                   MainSceneNum = TipRectTransform.Count - 1;
               }
               else
               {
                   MainSceneNum = MainSceneNum - 1;
               }
           }
           if (Input.GetKeyDown(KeyCode.KeypadEnter))
           {
               SceneManager.LoadScene(SceneIdex[SceneIdex[MainSceneNum]]);
           }
       }*/
}
