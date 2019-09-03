using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed = 15f;
    public float mapWidth = 5f;

    private Rigidbody2D rb;
    private GameManager gm;

    void Start() {
        rb = GetComponent<Rigidbody2D>();
        gm = FindObjectOfType<GameManager>();
    }

    void FixedUpdate ()
    {
        float x = Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime;
        Vector2 newPos = rb.position + Vector2.right * x;
        newPos.x = Mathf.Clamp(newPos.x, -mapWidth, mapWidth);

        rb.MovePosition(newPos);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        gm.EndGame();
    }
}