using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlerButtonB : MonoBehaviour
{
    
    public Button ButtonFour;
    public Button ButtonFive;
    public Button ButtonSix;
    
    void Start () 
    {

        Button BtnFour = ButtonFour.GetComponent<Button>();
		BtnFour.onClick.AddListener(TaskOnClickTwo);
	     
        Button BtnFive = ButtonFive.GetComponent<Button>();
		BtnFive.onClick.AddListener(TaskOnClickTwo);

        Button BtnSix = ButtonSix.GetComponent<Button>();
	}

    void TaskOnClickTwo()
    {
        ButtonSix.gameObject.SetActive(true);
       
	}
}
