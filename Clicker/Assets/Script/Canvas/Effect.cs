using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Effect : MonoBehaviour
{
    public GameObject wheat;
    public GameObject tomato;
    public GameObject melon;
    public Text wheatText;
    public Text tomatoText;
    public Text melonText;

    // Start is called before the first frame update
    void Start()
    {
        wheat.SetActive(false);
        tomato.SetActive(false);
        melon.SetActive(false);

        if (Main.wheatB && !Main.tomatoB && !Main.melonB) //∫≠∏∏
        {
            wheat.SetActive(true);
            wheatText.text = (Main.increment1 * Main.increment2).ToString();
        }

        else if (!Main.wheatB && Main.tomatoB && !Main.melonB) //≈‰∏∂≈‰∏∏
        {
            tomato.SetActive(true);
            tomatoText.text = (Main.increment1 * Main.increment2).ToString();
        }

        else if (!Main.wheatB && !Main.tomatoB && Main.melonB) //∏·∑–∏∏
        {
            melon.SetActive(true);
            melonText.text = (Main.increment1 * Main.increment2).ToString();
        }

        else if (Main.wheatB && Main.tomatoB && !Main.melonB) //∫≠øÕ ≈‰∏∂≈‰
        {
            wheat.SetActive(true);
            tomato.SetActive(true);
            wheatText.text = ((int)(Main.increment1 * Main.increment2 / 2)).ToString();
            tomatoText.text = ((int)(Main.increment1 * Main.increment2 / 2)).ToString();
        }

        else if (!Main.wheatB && Main.tomatoB && Main.melonB) //≈‰∏∂≈‰øÕ ∏·∑–
        {
            tomato.SetActive(true);
            melon.SetActive(true);
            tomatoText.text = ((int)(Main.increment1 * Main.increment2 / 2)).ToString();
            melonText.text = ((int)(Main.increment1 * Main.increment2 / 2)).ToString();
        }

        else //∫≠øÕ ≈‰∏∂≈‰øÕ ∏·∑–
        {
            wheat.SetActive(true);
            tomato.SetActive(true);
            melon.SetActive(true);
            wheatText.text = ((int)(Main.increment1 * Main.increment2 / 3)).ToString();
            tomatoText.text = ((int)(Main.increment1 * Main.increment2 / 3)).ToString();
            melonText.text = ((int)(Main.increment1 * Main.increment2 / 3)).ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * 100 * Time.deltaTime);
        Destroy(this.gameObject, 1.5f);
    }
}
