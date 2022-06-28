using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLighting : MonoBehaviour
{
    [SerializeField]
    GameObject Light;
    
    public float xAngle, yAngle, zAngle;


    private void Awake()
    {
        Light.transform.Rotate(180.0f, 0.0f, 0.0f, Space.World);
    }
}
