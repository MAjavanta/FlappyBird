using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{

    private float jumpForce = 4f;
    private Rigidbody2D rb;
    private Controls controls;

    private void Awake()
    {
        controls = new Controls();
    }

    private void OnEnable()
    {
        controls.Player.Enable();
        controls.Player.Jump.performed += OnJump;
    }

    private void OnDisable()
    {
        controls.Player.Disable();
        controls.Player.Jump.performed -= OnJump;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnJump(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor") || collision.gameObject.CompareTag("Pipe"))
        {
            Debug.Log("Collision detected");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
            Debug.Log("Collision with: " + collision.gameObject.name);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Score"))
        {
            Debug.Log("Score Triggered");
        }
    }
}
