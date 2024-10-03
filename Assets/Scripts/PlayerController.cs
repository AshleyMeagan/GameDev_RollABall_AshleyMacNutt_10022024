using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
public TMP_Text countText;

public float speed = 0;
    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
        rb = GetComponent <Rigidbody>();
    }
void OnMove (InputValue movementValue)
{
Vector2 movementVector = movementValue.Get<Vector2>();

movementX = movementVector.x;
movementY = movementVector.y;
}
void FixedUpdate()
{
    Vector3 movement = new Vector3(movementX, 0.0f, movementY);
    rb.AddForce(movement * speed);
}
void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("PickUp")) 
{
    other.gameObject.SetActive(false);
    count++;
    SetCountText();
}
}
void SetCountText(){
    countText.text = "Count" + count.ToString();
}

}

