using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;


public class MovementPlayer2 : MonoBehaviour
{
    //Atur karakter
    bool grounded = true;
    public Vector2 lompatan = new Vector2(10, 50);
    



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
            if(saat_lompat && grounded)
            {
                GetComponent<Rigidbody2D>().AddForce(lompatan);
            }
            else
            {
            }
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("grounded2"))
        {
            grounded = true;
            Debug.Log("Nempel tanah");
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("grounded2"))
        {
            grounded = false;
            Debug.Log("Tidak Nempel tanah");
        }
    }
}
