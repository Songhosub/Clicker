using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartUI : MonoBehaviour
{

    Button startButtpn;
    Button exitButtpn;

    // Start is called before the first frame update
    void Start()
    {
        startButtpn = GameObject.Find("Start").GetComponent<Button>();
        exitButtpn = GameObject.Find("Exit").GetComponent<Button>();

        startButtpn.onClick.AddListener(GameStart);
        exitButtpn.onClick.AddListener(GameExit);
    }

    void GameStart()
    {
        this.gameObject.SetActive(false);
    }

    void GameExit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
