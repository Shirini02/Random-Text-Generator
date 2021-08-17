using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClickCounter : MonoBehaviour
{
    private int clickCount;
    [SerializeField]
    private Text clickCountText;
    private RandomTextGenerator random = new RandomTextGenerator();


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Increment();
        }
    }
    public void Increment()
    {
        clickCount++;

        clickCountText.text = clickCount.ToString();
        clickCountText.text = random.Genrator(clickCount);
    }
}

