using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scale : MonoBehaviour
{
    [SerializeField]
    private GameObject cubeScale;

    private Renderer cubeRendererScale;

    void Start()
    {
        cubeRendererScale = cubeScale.GetComponent<Renderer>();
        gameObject.GetComponent<Button>().onClick.AddListener(ChangeCubeScale);
    }

    private void ChangeCubeScale()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        transform.localScale = new Vector3(Random.Range(0.2f, 5.0f), 1, Random.Range(0.2f, 5.0f));
    }
}
