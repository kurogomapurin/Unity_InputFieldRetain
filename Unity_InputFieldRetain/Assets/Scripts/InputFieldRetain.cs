using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;

public class InputFieldRetain : MonoBehaviour{
    public Text text;
    public Text placeholder;
    public TouchScreenKeyboard keyboard;
    public string name;
    public TouchScreenKeyboardType keyboardtype = TouchScreenKeyboardType.Default;
    // Use this for initialization
    void Start () {
	
    }	
    // Update is called once per frame
    void Update () {
	if(keyboard != null){
	    if(keyboard.done){
		//Save
		if(name != "")PlayerPrefs.SetString(name,text.text);
	    }
	    if(keyboard.text.Length > 0 && keyboard.active){
		text.text = keyboard.text;
	    }
	}
	if(text.text.Length <= 0){
	    text.enabled = false;
	    placeholder.enabled = true;
	}else{
	    text.enabled = true;
	    placeholder.enabled = false;
	}
    }
    public void openKeyboard(){
	keyboard = TouchScreenKeyboard.Open(text.text,keyboardtype);
    }
}
