using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    Vector3 offset;
    void Start()
    {
        offset = gameObject.transform.position;
    }

    void Update()
    {
        Vector3 currentPosition = gameObject.transform.position;
        gameObject.transform.position = Vector3.Lerp(currentPosition, target.transform.position + offset, Time.deltaTime);
        //gameObject.transform.position = target.transform.position + offset;
    }
}
