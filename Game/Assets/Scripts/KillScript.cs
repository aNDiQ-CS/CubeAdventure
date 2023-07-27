using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Hit!");
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject);            
        }
    }
}
