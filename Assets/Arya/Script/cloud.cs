using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloud : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector2 veloc = new Vector2(-4, 0);
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = veloc;
      
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
