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
            txt.text = ("�丶�� ��� �ٸ� �۹��� ȹ�� �Ѵ�.\r\n��� ���� 750�̻� �϶� ����");
            buttonImg.GetComponent<Image>().sprite = spr;
        }

        else if (!Main.wheatB && Main.tomatoB && Main.melon >= 750)
        {
            Main.tomatoB = false;
            txt.text = ("�� �̻� �ߴ� �� �� �����ϴ�.");
            buttonImg.SetActive(false);
            buttonTxt.text = ("����ߴ�");
        }

        else
        {
            Debug.Log("�ߴ� �� �� �����ϴ�.");
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
            panelTxt.text = ("��� ���� �� �ߴ� ����");
        }

        else if (Main.melonB)
        {
            panel.SetActive(false);
        }
    }
}
