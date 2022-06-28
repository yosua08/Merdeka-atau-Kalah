using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naikturun : MonoBehaviour
{

    [SerializeField]
    float speed = 5f;

    [SerializeField]
    float height = 0.5f;

    Vector3 pos;

    private void Start()
    {
        pos = transform.position;
    }
    void Update()
    {
        float penonton = Mathf.Sin(Time.time * speed) * height + pos.y;
        transform.position = new Vector3(transform.position.x, penonton, transform.position.z);
    }
}
