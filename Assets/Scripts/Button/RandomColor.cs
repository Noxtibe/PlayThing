using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomColor : MonoBehaviour
{
    public Image buttonBackground;

    public void ButtonClicked()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        buttonBackground.color = Random.ColorHSV();
    }
}
