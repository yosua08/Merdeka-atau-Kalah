using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateCloud : MonoBehaviour
{
    public GameObject Cloud;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateCloud", 2f, 6f);
    }

    void CreateCloud()
    {
        Instantiate(Cloud);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
