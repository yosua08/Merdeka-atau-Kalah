using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpossumInActLeft : MonoBehaviour
{
    public Vector2 veloc = new Vector2(-2, 0);
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = veloc;
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
