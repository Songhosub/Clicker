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
            txt.text = ("더 많은 작물 수확가능\r\n작물 획득량 x2\r\n가격 : 250000");
        }

        else if (level == 1 && Main.wealth >= 250000)
        {
            level += 1;
            Main.wealth -= 250000;
            main.GetComponent<MeshRenderer>().material = mat[2];
            Main.increment2 *= 2;
            txt.text = ("더 이상 확장할 수 없습니다.");
        }

        else
        {
            Debug.Log("확장할 수 없습니다.");
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
