﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class changetext : MonoBehaviour
{   public TextMeshProUGUI textMesh;
    public AudioSource audioSource;
    public AudioClip audioClip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textMesh.GetComponent<TextMeshProUGUI>();
    }

    public void onButtonClicked(){
        textMesh.GetComponent<TextMeshProUGUI>();
        textMesh.SetText("hi");
        audioSource.clip = audioClip;
        audioSource.Play();
    }
}
