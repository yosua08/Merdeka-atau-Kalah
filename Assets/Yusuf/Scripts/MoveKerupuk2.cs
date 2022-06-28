using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveKerupuk2 : MonoBehaviour
{
    // Atur gerak kerupuk
    private Rigidbody2D rb;
    public float speed = 1f;
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
                Debug.Log("Player 2 Win");
                SceneManager.LoadScene("WinP2");
            }
        }
    }

    private void OnGUI()
    {
        guiStyle.fontSize = 20;
        GUI.Label(new Rect(600, 0, 300, 50), "Point P2 : " + point.ToString(), guiStyle);
    }
}
