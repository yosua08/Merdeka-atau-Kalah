using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlay()
    {
        SceneManager.LoadScene("Pilihan_Game");
    }

    public void OnPanjatPinang()
    {
        SceneManager.LoadScene("PanjatPinang");
    }

    public void OnBalapKarung()
    {
        SceneManager.LoadScene("Balapkarung");
    }

    public void OnMakanKerupuk()
    {
        SceneManager.LoadScene("MakanKerupuk");
    }

    public void OnCredit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void OnOptions()
    {
        SceneManager.LoadScene("Options");
    }

    public void OnMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void doExitGame()
    {
        Application.Quit();
    }
}
