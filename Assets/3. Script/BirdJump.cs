using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject position;
    public bool move;

    public float jumpPower;
    public float moveSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        move = false;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        move = true;
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpPower;
        }

        if (move)
        {
            Debug.Log("d");
            Vector3 targetPosition = new Vector3(position.transform.position.x, transform.position.y, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
        else
        {

        }

    }
}
