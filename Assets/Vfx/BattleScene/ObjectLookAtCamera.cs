using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectLookAtCamera : MonoBehaviour
{
    void Update()
    {
        transform.rotation = Camera.main.transform.rotation;
    }
}