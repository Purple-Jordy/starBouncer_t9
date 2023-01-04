using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retryPanel : MonoBehaviour
{
    public GameObject star;

    // Start is called before the first frame update
    void Start()
    {
        
<<<<<<< Updated upstream
=======
        //rewardedAds._rewardedAdComplete.AddListener(Revive);
>>>>>>> Stashed changes
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void retry()
    {

#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Return()
    {

        star.GetComponent<CircleMove>().PositionLoad();
        
    }

<<<<<<< Updated upstream
=======
    public void OnClickReviveButton() {
        rewardedAds.ShowAd();
#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif

        Invoke("Revive", 1);
    }

>>>>>>> Stashed changes
}
