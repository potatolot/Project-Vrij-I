﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextEx : MonoBehaviour
{
    [SerializeField]
    private string responseText = "";

    public string GetText()
    {
        return responseText;
    }
}
