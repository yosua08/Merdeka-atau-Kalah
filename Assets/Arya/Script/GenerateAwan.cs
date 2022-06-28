using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateAwan : MonoBehaviour
{

    public GameObject clouds;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateAwan", 1f, 1.5f);
    }
    void CreateAwan()
    {
        Instantiate(clouds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
