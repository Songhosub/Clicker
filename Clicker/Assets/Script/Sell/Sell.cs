using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sell : MonoBehaviour
{
    Button sell1;

    // Start is called before the first frame update
    void Start()
    {
        sell1 = GameObject.Find("Sell1/Sell1Button").GetComponent<Button>();

        sell1.onClick.AddListener(SellAll);
    }

    void SellAll()
    {
        Main.wealth += Main.wheat * 10 + Main.tomato * 50 + Main.melon *200;
        Main.wheat = 0;
        Main.tomato = 0;
        Main.melon = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
