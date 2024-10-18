using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Addition : MonoBehaviour
{
    Button buy2;
    GameObject panel;
    Text txt;
    Text panelTxt;


    // Start is called before the first frame update
    void Start()
    {
        buy2 = GameObject.Find("Buy2/Buy2Button").GetComponent<Button>();
        panel = GameObject.Find("Buy2/Panel");

        txt = GameObject.Find("Buy2/Explain").GetComponent<Text>();
        panelTxt = GameObject.Find("Buy2/Panel/Text (Legacy)").GetComponent<Text>();



        buy2.onClick.AddListener(AdditionUp);
    }

    void AdditionUp()
    {
        if (Main.increment2 < 2)
        {
            Debug.Log("���� ������ �� �����ϴ�.");
        }

        else if (Main.increment2 >= 2 && !Main.tomatoB && Main.wealth >= 30000)
        {
            Main.wealth -= 30000;
            Main.tomatoB = true;
            txt.text = ("��Ȯ���� �Ϻΰ� ������� ����ȴ�.\r\n���� : 75000");
        }

        else if (Main.increment2 == 2 && Main.tomatoB)
        {
            Debug.Log("���� ������ �� �����ϴ�.");
        }

        else if (Main.increment2 == 4 && Main.tomatoB && !Main.melonB && Main.wealth >= 75000)
        {
            Main.wealth -= 75000;
            Main.melonB = true;
            txt.text = ("�� �̻� ������ �� �����ϴ�.");
        }

        else
        {
            Debug.Log("������ �� �����ϴ�.");
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Main.increment2 == 2 && !Main.tomatoB)
        {
            panel.SetActive(false);
        }

        else if (Main.increment2 == 2 && Main.tomatoB)
        {
            panel.SetActive(true);
            panelTxt.text = ("���� Ȯ�� 3�ܰ� ���� ���� ����");
        }

        else if (Main.increment2 == 4 && !Main.melonB)
        {
            panel.SetActive(false);
        }

    }
}
