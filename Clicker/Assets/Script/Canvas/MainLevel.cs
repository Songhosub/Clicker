using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainLevel : MonoBehaviour
{
    Text levelTxt;


    // Start is called before the first frame update
    void Start()
    {
        levelTxt = GameObject.Find("MainLevel/Text (Legacy)").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Main.increment2 == 2)
        {
            levelTxt.text = ("���� Ȯ�� �ܰ� : 2�ܰ�");
        }

        else if (Main.increment2 == 4)
        {
            levelTxt.text = ("���� Ȯ�� �ܰ� : 3�ܰ�");
        }
    }
}
