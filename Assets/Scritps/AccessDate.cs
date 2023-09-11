using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AccessDate : MonoBehaviour
{
    private string screenshotTime = System.DateTime.Now.ToString("MM/dd/yy");
    public Text accessDate;
    void Update()
    {
        GetData();
    }

    void GetData(){
        accessDate.text = "Fecha de acceso: " + screenshotTime;
    }
}
