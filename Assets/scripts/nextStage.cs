using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextStage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadNextScene()
    {
        //현재 씬 정보를 가지고 온다
        Scene scene = SceneManager.GetActiveScene();

        //현재 씬의 빌드 순서를 가지고 온다
        int curScene = scene.buildIndex;

        //현재 씬 바로 다음 씬을 가져오기 위해 +1을 해준다.
        int nextScene = curScene + 1;

        //다음 씬을 불러온다
        SceneManager.LoadScene(nextScene);

#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif


        // 다음 씬을 저장한다 
        PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.Save();

    }


}
