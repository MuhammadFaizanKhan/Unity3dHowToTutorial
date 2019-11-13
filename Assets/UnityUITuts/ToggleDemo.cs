using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Get UI namespace ref

public class ToggleDemo : MonoBehaviour
{

    public Toggle selectedToggle;

    private void Start()
    {

        selectedToggle =  GetComponent<Toggle>();//get refrence automatically.
        //assign event to toggle.
        selectedToggle.onValueChanged.AddListener(delegate {
            ToggleValueChangedOccured(selectedToggle);
            });
    }

    void ToggleValueChangedOccured(Toggle tglValue)
    {
        Debug.Log("your current toggle state is: "+ tglValue.isOn);
    }

}
