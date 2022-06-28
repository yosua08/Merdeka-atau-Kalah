﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveKerupuk1 : MonoBehaviour
{
    // Atur gerak kerupuk
    private Rigidbody2D rb;
    public float speed = Random.Range(1f,3f);
    public bool naik;

    //point Kerupuk
    public int point;
    GUIStyle guiStyle = new GUIStyle();
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        naik = true;
        point = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (naik)
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
        }
        else
        {
            rb.velocity = new Vector2(rb.velocity.x, -speed);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("balik"))
        {
            naik = !naik;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            point++;
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>(), false);
            if (point == 10)
            {
                Debug.Log("Player 1 Win");
                SceneManager.LoadScene("WinP1");
            }
        }
    }

    private void OnGUI()
    {
        guiStyle.fontSize = 20;
        GUI.Label(new Rect(0, 0, 300, 50), "Point P1 : " + point.ToString(), guiStyle);
    }
}
