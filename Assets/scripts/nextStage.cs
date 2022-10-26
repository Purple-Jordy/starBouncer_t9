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
        //���� �� ������ ������ �´�
        Scene scene = SceneManager.GetActiveScene();

        //���� ���� ���� ������ ������ �´�
        int curScene = scene.buildIndex;

        //���� �� �ٷ� ���� ���� �������� ���� +1�� ���ش�.
        int nextScene = curScene + 1;

        //���� ���� �ҷ��´�
        SceneManager.LoadScene(nextScene);

#if !UNITY_EDITOR
     Vibrate.vibrate((long)100);
#endif


        // ���� ���� �����Ѵ� 
        PlayerPrefs.SetInt("SavedScene", SceneManager.GetActiveScene().buildIndex + 1);
        PlayerPrefs.Save();

    }


}
