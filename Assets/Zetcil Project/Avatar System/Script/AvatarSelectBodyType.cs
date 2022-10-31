﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarSelectBodyType : MonoBehaviour
{

    [Header("Main Settings")]
    public bool Masculine;
    public bool Feminine;

    public void SetMasculine()
    {
        Masculine = true;
        Feminine = false;
        PlayerPrefs.SetString("STEP1", "MASCULINE");
    }

    public void SetFeminine()
    {
        Masculine = false;
        Feminine = true;
        PlayerPrefs.SetString("STEP1", "FEMININE");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
