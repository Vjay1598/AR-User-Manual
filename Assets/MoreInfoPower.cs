using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MoreInfoPower : MonoBehaviour
{
    public Text homeButtonInfo;
    public void OnMouseDown()
    {
        homeButtonInfo.enabled = true;
    }
    public void OnMouseUp()
    {
        homeButtonInfo.enabled = false;
    }
}
