using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Backbutton : MonoBehaviour
{

    public Button backButton;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        backButton.onClick.AddListener(backButtonClick);
    }


    void backButtonClick()
    {
        SceneManager.LoadScene(sceneName);
    }    

    // Update is called once per frame
    void Update()
    {
        
    }
}
