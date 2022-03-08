using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class SpawnerIso : MonoBehaviour
{
    public Transform spawnpoint;
    public GameObject IsoSphere;
    public GameObject spawnIsoEffect;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(IsoSphere, spawnpoint.position, spawnpoint.rotation);
            CameraShaker.Instance.ShakeOnce(2f, 1f, 0.1f, 1f);
            FindObjectOfType<AudioManager>().Play("SpawnSphere");
            Instantiate(spawnIsoEffect, transform.position, transform.rotation);
        }
    }
}
