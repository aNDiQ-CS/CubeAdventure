using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWall : MonoBehaviour
{
    public Transform wall;
    public Transform firstPosition;
    public Transform secondPosition;
    public float wallSpeed;
    Vector3 moveDirection = Vector3.right;

    private void Start()
    {
        wall.position = firstPosition.position;
    }

    private void Update()
    {
        wall.position += moveDirection * wallSpeed * Time.deltaTime;
        if (wall.position.x > secondPosition.position.x || wall.position.x < firstPosition.position.x)
        {
            moveDirection *= -1;
        }
    }
}
