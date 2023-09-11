using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscenaLogoUjat : MonoBehaviour
{
    public string scena;
    void Start()
    {
        StartCoroutine(Logos());
    }

    IEnumerator Logos() 
    {
        yield return new WaitForSeconds(8);
        SceneManager.LoadScene(scena);
    }
    

}
