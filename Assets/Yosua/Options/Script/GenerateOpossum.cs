using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateOpossum : MonoBehaviour
{
    public GameObject OpossumRight;
    public GameObject OpossumLeft;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateOpossumRight", 2f, 6f);
        InvokeRepeating("CreateOpossumLeft", 2f, 10f);
    }

    void CreateOpossumRight()
    {
        Instantiate(OpossumRight);
    }

    void CreateOpossumLeft()
    {
        Instantiate(OpossumLeft);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
