using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;
public class Shake : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            CameraShaker.Instance.ShakeOnce(10f, 10f, 0.5f, 0.5f);
        }
    }
}
