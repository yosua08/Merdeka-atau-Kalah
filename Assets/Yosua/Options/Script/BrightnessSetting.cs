using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrightnessSetting : MonoBehaviour
{
    public Slider Slider;
    public Light SceneLight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SceneLight.intensity = Slider.value;
    }
}
