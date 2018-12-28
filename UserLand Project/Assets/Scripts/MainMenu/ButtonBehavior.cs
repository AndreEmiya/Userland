using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{
    bool flag = false;

    public void MouseEnter()
    {
        flag = true;
    }

    public void MouseOut()
    {
        flag = false;
    }

    private void Update()
    {
        if (flag)
        {
            this.GetComponent<Image>().color = Color.white;
            this.GetComponentInChildren<TextMeshProUGUI>().color = Color.black;
        }
        else
        {
            this.GetComponent<Image>().color = Color.black;
            this.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;
        }
    }
}
