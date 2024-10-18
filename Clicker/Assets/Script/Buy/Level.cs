using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour
{

    Button buy1;
    int level = 0;
    Text txt;

    // Start is called before the first frame update
    void Start()
    {
        buy1 = GameObject.Find("Buy1/Buy1Button").GetComponent<Button>();
        txt = GameObject.Find("Buy1/Explain").GetComponent<Text>();
        buy1.onClick.AddListener(LevelUp);
    }

    void LevelUp()
    {
        if (level==0 && Main.wealth >= 500)
        {
            level++;
            Main.wealth -= 500;
            Main.increment1 = 5;
            txt.text = ("�� ���� �۹��� ȹ��\r\n�۹� ȹ�淮 +15\r\n���� : 2500");
        }

        else if (level==1 && Main.wealth >= 2500)
        {
            level++;
            Main.wealth -= 2500;
            Main.increment1 = 20;
            txt.text = ("�� ���� �۹��� ȹ��\r\n�۹� ȹ�淮 +30\r\n���� : 10000");
        }

        else if(level==2 && Main.wealth >= 10000)
        {
            level++;
            Main.wealth -= 10000;
            Main.increment1 = 50;
            txt.text = ("�� �̻� ��ȭ�� �� �����ϴ�.");
        }

        else
        {
            Debug.Log("��ȭ�� �� �����ϴ�.");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
