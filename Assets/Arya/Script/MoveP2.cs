using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveP2 : MonoBehaviour
{
    //Atur karakter
    bool kenatanah = true;
    public Vector2 lompatan = new Vector2(10, 50);
    public Animator animator;




    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        //atur animasi lompat maju kedepan


        if (Input.GetKey(KeyCode.I))
        {
            bool saat_lompat = Input.GetKey(KeyCode.I);
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
        if (collision.gameObject.CompareTag("grounded2"))
        {
            kenatanah = true;
            Debug.Log("Nempel tanah");
        }
        if (collision.gameObject.CompareTag("grounded"))
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);
        }
        if (collision.gameObject.tag == "finishp2")
        {
            Debug.Log("Anda Menang");
            SceneManager.LoadScene("P2Win");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("grounded2"))
        {
            kenatanah = false;
            Debug.Log("Tidak Nempel tanah");
        }
    }
}
