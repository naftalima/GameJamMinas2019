using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class loadScene : MonoBehaviour
{
    public Button next;

    // start is called before the first frame update
    void Start()
    {
        next.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //output this to console when button1 or button3 is clicked
        //Debug.Log("you have clicked the button!");
        SceneManager.LoadScene("Scene1", LoadSceneMode.Additive);
        //print("You clicked the button!");
    }
    
    // update is called once per frame
    //void update()
    //{

    //}
}