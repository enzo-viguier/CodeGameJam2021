﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialog : MonoBehaviour
{
    public Text changedText;
    public Text changingText;
    public GameObject boutonEphemere;

    public void TextDialogChange()
    {
        changedText.text = changingText.text;
        boutonEphemere.SetActive(false);
    }
}
