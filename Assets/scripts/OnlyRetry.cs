using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnlyRetry : MonoBehaviour
{
    public void retry()
    {

#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
