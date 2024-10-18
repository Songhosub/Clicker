using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Expansion : MonoBehaviour
{
    GameObject main;
    Button buy3;
    Text txt;
    int level = 0;
    public Material[] mat;

    // Start is called before the first frame update
    void Start()
    {
        main = GameObject.Find("Main");
        buy3 = GameObject.Find("Buy3/Buy3Button").GetComponent<Button>();
        txt = GameObject.Find("Buy3/Explain").GetComponent<Text>();

        main.GetComponent<MeshRenderer>().material = mat[0];

        buy3.onClick.AddListener(ExpansionUP);
    }

    void ExpansionUP()
    {
        if(level == 0 && Main.wealth >= 50000)
        {
            level += 1;
            Main.wealth -= 50000;
            main.GetComponent<MeshRenderer>().material = mat[1];
            Main.increment2 *= 2;
            txt.text = ("�� ���� �۹� ��Ȯ����\r\n�۹� ȹ�淮 x2\r\n���� : 250000");
        }

        else if (level == 1 && Main.wealth >= 250000)
        {
            level += 1;
            Main.wealth -= 250000;
            main.GetComponent<MeshRenderer>().material = mat[2];
            Main.increment2 *= 2;
            txt.text = ("�� �̻� Ȯ���� �� �����ϴ�.");
        }

        else
        {
            Debug.Log("Ȯ���� �� �����ϴ�.");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
