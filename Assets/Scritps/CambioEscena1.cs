﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena1 : MonoBehaviour
{
    // Start is called before the first frame update
    public string scena;
    void Start()
    {
        StartCoroutine(IrInterfaz());
        
    }
    IEnumerator IrInterfaz()
    {
        yield return new WaitForSeconds(9);
        SceneManager.LoadScene(scena);
        
    }
}
