﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Config : MonoBehaviour {

	public GameObject toggle;
	public static bool ctrlCfg;

    public GameObject textfield;
    public GameObject toggleObj;
    public void animationend()
    {
        textfield.SetActive(false);
        toggleObj.SetActive(false);
    }
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		ctrlCfg = toggle.GetComponent<Toggle> ().isOn;
	}
}
