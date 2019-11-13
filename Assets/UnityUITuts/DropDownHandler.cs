using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//add ui namespance
using UnityEngine.UI;

public class DropDownHandler : MonoBehaviour
{
    /// <summary>
    /// Dropdown reference to get its value
    /// </summary>
    public Dropdown ddFruites;

    private void Start()
    {
        //assigned on value changed event 
        ddFruites.onValueChanged.AddListener(delegate
        {
            ddFruitesValueChangedHappened(ddFruites);
        });

    }

    public void ddFruitesValueChangedHappened(Dropdown sender)
    {

        //getting dropdown selected value
        Debug.Log("You have selected the value :" + sender.value);

        //now we will get selected value text
        Debug.Log("You have selected the text :" + ddFruites.options[ddFruites.value].text);

    }

}
