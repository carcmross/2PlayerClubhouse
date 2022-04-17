using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBoundaries : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -17f, -1f),
        Mathf.Clamp(transform.position.y, -9.5f, 11f), transform.position.z);
    }
}
