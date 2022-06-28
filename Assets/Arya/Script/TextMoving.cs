using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextMoving : MonoBehaviour
{
    public float speed;
    Vector3 keatas;

    // Start is called before the first frame update
    void Start()
    {
        keatas = new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (keatas * speed * Time.deltaTime);
    }
}
