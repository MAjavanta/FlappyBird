using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{

    private float moveSpeed = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * Time.deltaTime * moveSpeed;
        if (transform.position.x < -11f)
        {
            Destroy(gameObject);
        }
    }
}
