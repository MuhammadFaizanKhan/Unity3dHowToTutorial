using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnClickSample : MonoBehaviour
{
    //take button reference
    public Button btnSample;

    private void Start()
    {
        //assigned btn click event programatically.
        btnSample.onClick.AddListener(BtnClickSampleWork);

    }

    public void BtnClickSampleWork()
    {
        Debug.Log("Congrats! Button has clicked.");
    }


}
