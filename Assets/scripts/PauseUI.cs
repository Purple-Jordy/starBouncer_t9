using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Pauseui;

    public void Resume()
    {

#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif


        Time.timeScale = 1;
        Pauseui.SetActive(false);
    }

    public void retry()
    {

#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }



    public void ExitGame()
    {

#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif

        Application.Quit();
    }

}
