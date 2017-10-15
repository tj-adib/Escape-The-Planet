using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScoreView : MonoBehaviour {

    public Text finalText;

	// Use this for initialization
	void Start () {

        finalText.text = PlayerPrefs.GetFloat("High", 0).ToString("0.#");
        finalText.text += "m";
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
