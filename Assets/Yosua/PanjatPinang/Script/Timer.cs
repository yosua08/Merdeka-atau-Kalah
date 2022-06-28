using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float timerValue = 20;
    public Text timeLeftText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IeTimeLeft());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Time Left: " + timerValue);
        timeLeftText.text = "" + timerValue;
    }

    //IEnumerator = untuk menjeda atau menghentikan proses tertentu
    IEnumerator IeTimeLeft()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            timerValue--;

            if (timerValue == 0)
            {
                SceneManager.LoadScene("Pilihan_Game");
            }
        }
    }
}
