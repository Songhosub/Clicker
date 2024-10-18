using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour
{

    Button menuButton;
    Text startTxt;
    GameObject startUi;


    // Start is called before the first frame update
    void Start()
    {
        menuButton = GameObject.Find("MenuButton").GetComponent<Button>();
        startTxt = GameObject.Find("StartUI/Start/Text (Legacy)").GetComponent<Text>();
        startUi = GameObject.Find("StartUI");



        menuButton.onClick.AddListener(MenuOn);
    }

    void MenuOn()
    {
        startUi.SetActive(true);
        startTxt.text = ("�̾");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
