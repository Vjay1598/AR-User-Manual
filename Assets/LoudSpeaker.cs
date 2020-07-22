using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoudSpeaker : MonoBehaviour
{
    public Text loudSpeakerInfo;
    public void OnMouseDown()
    {
        loudSpeakerInfo.enabled = true;
    }
    public void OnMouseUp()
    {
        loudSpeakerInfo.enabled = false;
    }
}

