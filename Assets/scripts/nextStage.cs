using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextStage : MonoBehaviour
{
    [SerializeField] InterstitialAds interstitialAds;
    
    // Start is called before the first frame update
    void Start()
    {
        interstitialAds = Object.FindObjectOfType<InterstitialAds>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadNextScene()
    {
        if (interstitialAds) {
            string playedRoundsNumKey = "PlayedRoundsNum";
            int roundCnt = PlayerPrefs.GetInt(playedRoundsNumKey);
            roundCnt++;
            PlayerPrefs.SetInt(playedRoundsNumKey, roundCnt);
            if (roundCnt > 2) {
                interstitialAds.ShowAd();
            }
        }

        //���� �� ������ ������ �´�
        Scene scene = SceneManager.GetActiveScene();

        //���� ���� ���� ������ ������ �´�
        int curScene = scene.buildIndex;

        //���� �� �ٷ� ���� ���� �������� ���� +1�� ���ش�.
        int nextScene = curScene + 1;

        //���� ���� �ҷ��´�
        SceneManager.LoadScene(nextScene);
        PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex);
        PlayerPrefs.Save();

    }


}
