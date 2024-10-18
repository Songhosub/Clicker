using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public static int wheat = 0;
    public static int tomato = 0;
    public static int melon = 0;
    public static int wealth = 0;

    public static int increment1 = 1;
    public static int increment2 = 1;

    public static bool wheatB = true;
    public static bool tomatoB = false;
    public static bool melonB = false;

    Button mainButton;
    GameObject ui;
    public GameObject effect;


    // Start is called before the first frame update
    void Start()
    {
        ui = GameObject.Find("Canvas");

        mainButton = GameObject.Find("MainButton").GetComponent<Button>();

        mainButton.onClick.AddListener(MainEvent);
    }


    // Update is called once per frame
    void Update()
    {

    }

    private void MainEvent()
    {
        Instantiate(effect, ui.transform);

        if (wheatB && !tomatoB && !melonB) //���� / ��100%
        {
            wheat += (increment1 * increment2);
        }

        else if (wheatB && tomatoB && !melonB) //�丶��� �� / ��50% �丶��50%
        {
            wheat += (int)(increment1 * increment2 / 2);
            tomato += (int)(increment1 * increment2 / 2);
        }

        else if (wheatB && tomatoB && melonB) //��а� �丶��� �� / ��33% �丶��33% ���33%
        {
            wheat += (int)(increment1 * increment2 / 3);
            tomato += (int)(increment1 * increment2 / 3);
            melon += (int)(increment1 * increment2 / 3);

        }

        else if (!wheatB && tomatoB && !melonB) //�丶�丸 / �丶��100%
        {
            tomato += (increment1 * increment2);
        }

        else if (!wheatB && !tomatoB && melonB) //��и� / ���100%
        {
            melon += (increment1 * increment2);
        }

        else //��а� �丶�� / ���50% �丶��50%
        {
            tomato += (int)(increment1 * increment2 / 2);
            melon += (int)(increment1 * increment2 / 2);
        }
    }
}
