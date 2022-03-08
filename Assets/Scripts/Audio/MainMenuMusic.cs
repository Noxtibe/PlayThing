using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuMusic : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("MainMenuMusic");
    }
}
