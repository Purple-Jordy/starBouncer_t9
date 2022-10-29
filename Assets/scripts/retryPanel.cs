using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class retryPanel : MonoBehaviour
{
    public GameObject star;
    public RewardedAds rewardedAds;

    // Start is called before the first frame update
    void Start()
    {
        rewardedAds._rewardedAdComplete.AddListener(Revive);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Revive()
    {

        star.GetComponent<CircleMove>().PositionLoad();
        
    }

    public void OnClickReviveButton() {
        rewardedAds.ShowAd();
    }

}
