using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BuyOrSell : MonoBehaviour
{

    GameObject buy;
    GameObject sell;

    Button buyButton;
    Button sellButton;


    // Start is called before the first frame update
    void Start()
    {
        buy = GameObject.Find("Buy");
        sell = GameObject.Find("Sell");

        buyButton = GameObject.Find("BuyButton").GetComponent<Button>();
        sellButton = GameObject.Find("SellButton").GetComponent<Button>();

        buyButton.onClick.AddListener(BuyCall);
        sellButton.onClick.AddListener(SellCall);

        buyButton.Select();
    }

    void BuyCall()
    {
        buy.SetActive(true);
        sell.SetActive(false);
    }

    void SellCall()
    {
        sell.SetActive(true);
        buy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
