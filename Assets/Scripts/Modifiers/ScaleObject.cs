using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleObject : MonoBehaviour
{
    public Transform cubeObject;

    public void ChangeCubeScale()
    {
        //transform.localScale = new Vector3(Random.Range(0.2f, 5.0f), 1, Random.Range(0.2f, 5.0f));
        FindObjectOfType<AudioManager>().Play("Click");
        cubeObject.localScale = new Vector3(Random.Range(0.2f, 5.0f), 1, Random.Range(0.2f, 5.0f));
    }
}
