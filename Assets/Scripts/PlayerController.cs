using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    public TMP_Text countText;     // Text for first collectable (Bottles)
    public TMP_Text coinCountText; // Text for second collectable (Coins)
    public TMP_Text winText;

    public float speed = 0;
    private Rigidbody rb;
    private int count;       // Counter for first collectable (Bottles)
    private int coinCount;   // Counter for second collectable (Coins)
    private float movementX;
    private float movementY;

    void Start()
    {
        count = 0;
        coinCount = 0;  // Initialize the second counter
        SetCountText();
        SetCoinCountText();  // Initialize the second counter text

        rb = GetComponent<Rigidbody>();
        winText.gameObject.SetActive(false);
    }

    void OnMove(InputValue movementValue)
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
        Debug.Log("Trigger Entered: " + other.gameObject.name);

        if (other.gameObject.CompareTag("PickUp"))  // For Bottles
        {
            Debug.Log("Picked up a bottle!");
            other.gameObject.SetActive(false);
            count++;
            SetCountText();
        }
        else if (other.gameObject.CompareTag("CoinPickUp"))  // For Coins
        {
            Debug.Log("Picked up a coin! Attempting to deactivate...");
            other.transform.parent.gameObject.SetActive(false);

            Debug.Log("Coin deactivated: " + other.gameObject.activeSelf);

            coinCount++;
            SetCoinCountText();
        }
    }

    // Update UI for bottle collectables
    void SetCountText()
    {
        countText.text = "Bottles collected: " + count.ToString();
        if (count >= 9)
        {
            winText.gameObject.SetActive(true);
        }
    }

    // Update UI for coin collectables
    void SetCoinCountText()
    {
        coinCountText.text = "Snacks collected: " + coinCount.ToString();
        Debug.Log("Coin count updated: " + coinCount);
    }
}
