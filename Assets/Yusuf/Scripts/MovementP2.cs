using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementP2 : MonoBehaviour
{
    //Atur karakter
    bool kenatanah = true;
    public Vector2 lompatan = new Vector2(0, 50);
    public Animator animator;





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //atur animasi lompat dan lompat  kali

        if (Input.GetKey(KeyCode.UpArrow))
        {
            bool saat_lompat = Input.GetKey(KeyCode.UpArrow);
            if (saat_lompat && kenatanah)
            {
                GetComponent<Rigidbody2D>().AddForce(lompatan);
                animator.SetBool("isLompat", true);
            }
            else
            {
                animator.SetBool("isLompat", false);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("tanah"))
        {
            kenatanah = true;
            Debug.Log("Nempel tanah");
        }

        if (collision.gameObject.CompareTag("kerupuk"))
        {
            Debug.Log("kena kerupuk");
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>(), false);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("tanah"))
        {
            kenatanah = false;
            Debug.Log("Tidak Nempel tanah");
        }
    }
}
