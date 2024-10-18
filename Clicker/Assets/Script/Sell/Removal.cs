using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Removal : MonoBehaviour
{
    Button sell2;

    GameObject panel;
    GameObject buttonImg;

    Text buttonTxt;
    Text txt;
    Text panelTxt;

    public Sprite spr;

    // Start is called before the first frame update
    void Start()
    {
        sell2 = GameObject.Find("Sell2/Sell2Button").GetComponent<Button>();
        panel = GameObject.Find("Sell2/Panel");

        buttonTxt = GameObject.Find("Sell2/Sell2Button/Text (Legacy)").GetComponent<Text>();
        buttonImg = GameObject.Find("Sell2/Sell2Button/Image");
        txt = GameObject.Find("Sell2/Explain").GetComponent<Text>();
        panelTxt = GameObject.Find("Sell2/Panel/Text (Legacy)").GetComponent<Text>();

        sell2.onClick.AddListener(RemovalUp);
    }

    void RemovalUp()
    {
        if (Main.wheatB && Main.tomato >= 300)
        {
            Main.wheatB = false;
            txt.text = ("토마토 대신 다른 작물을 획득 한다.\r\n멜론 갯수 750이상 일때 가능");
            buttonImg.GetComponent<Image>().sprite = spr;
        }

        else if (!Main.wheatB && Main.tomatoB && Main.melon >= 750)
        {
            Main.tomatoB = false;
            txt.text = ("더 이상 중단 할 수 없습니다.");
            buttonImg.SetActive(false);
            buttonTxt.text = ("재배중단");
        }

        else
        {
            Debug.Log("중단 할 수 없습니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Main.wheatB && Main.tomatoB)
        {
            panel.SetActive(false);
        }

        else if (!Main.wheatB && Main.tomatoB && !Main.melonB)
        {
            panel.SetActive(true);
            panelTxt.text = ("멜론 구매 후 중단 가능");
        }

        else if (Main.melonB)
        {
            panel.SetActive(false);
        }
    }
}
