using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeMovement : MonoBehaviour
{
    Vector3 movementVector;
    public float speedX = 10f;
    public float speedY = 10f;
    public Rigidbody rb;
    public float jumpForce = 50f;

    bool isGrounded = true;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        movementVector = new Vector3(x * speedX, 0, speedY) * Time.deltaTime;
        gameObject.transform.position += movementVector;
        
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded))
        {
            rb.AddForce(0, jumpForce, 0);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }

    public Button button;
    public Text text;

    private void OnDestroy()
    {
        text.color = new Color(0.8f, 0.2f, 0.2f);
        text.text = "Поражение(";
        button.gameObject.SetActive(true);
    }
}
