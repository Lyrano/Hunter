using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpotLightController : MonoBehaviour
{
    public Transform target;

    public Vector3 offset;
    public float maxZoom = 15;
    public float pitch = 2f;
    private float currentZoom = 10f;

    void LateUpdate()
    {
        transform.position = target.position - offset * currentZoom;
        transform.LookAt(target.position + Vector3.up * pitch);
    }
}
