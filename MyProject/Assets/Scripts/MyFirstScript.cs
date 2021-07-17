using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text;

public class MyFirstScript : MonoBehaviour
{

    public Button button1, button2, button3;
    public string SceneName1, sceneName2, sceneName3;
    int SceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        button1.onClick.AddListener(onButtonClick);
        button2.onClick.AddListener(onButtonClick1);
        button3.onClick.AddListener(onButtonClick2);

    }

    void onButtonClick()
    {
        SceneManager.LoadScene(SceneName1);
        Debug.Log(SceneName1);
    }


    void onButtonClick1()
    {
        SceneManager.LoadScene(sceneName2);
        Debug.Log(sceneName2);
    }

    void onButtonClick2()
    {
        SceneManager.LoadScene(sceneName3);
        Debug.Log(sceneName3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
