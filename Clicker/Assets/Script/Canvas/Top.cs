using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Top : MonoBehaviour
{
    Text wheatValue;
    Text tomatoValue;
    Text melonValue;
    Text wealthValue;

    // Start is called before the first frame update
    void Start()
    {
        wheatValue = GameObject.Find("WheatValue").GetComponent<Text>();
        tomatoValue = GameObject.Find("TomatoValue").GetComponent<Text>();
        melonValue = GameObject.Find("MelonValue").GetComponent<Text>();
        wealthValue = GameObject.Find("WealthValue").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        wheatValue.text = Main.wheat.ToString();
        tomatoValue.text = Main.tomato.ToString();
        melonValue.text = Main.melon.ToString();
        wealthValue.text = Main.wealth.ToString();

        if (Main.wheat > 9999)
        {
            wheatValue.text = ("9999+");
        }

        if (Main.tomato > 9999)
        {
            tomatoValue.text = ("9999+");
        }

        if (Main.melon > 9999)
        {
            melonValue.text = ("9999+");
        }

        if (Main.wealth > 999999999)
        {
            wealthValue.text = ("999999999+");
        }
    }
}
