using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class Break : MonoBehaviour
{
    public GameObject fractured;
    public float breakForce;
    public GameObject breakEffect;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            BreakTheThing();
            CameraShaker.Instance.ShakeOnce(4f, 4f, 0.1f, 1f);
            FindObjectOfType<AudioManager>().Play("BreakSound");
            Instantiate(breakEffect, transform.position, transform.rotation);
        }
    }

    public void BreakTheThing()
    {
        GameObject frac = Instantiate(fractured, transform.position, transform.rotation);

        foreach(Rigidbody rb in frac.GetComponentsInChildren<Rigidbody>())
        {
            Vector3 force = (rb.transform.position - transform.position).normalized * breakForce;
            rb.AddForce(force);
        }
        Destroy(gameObject);
    }
}
