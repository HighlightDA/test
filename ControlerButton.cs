using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controler : MonoBehaviour
{
    public Button ButtonOne;
    public Button ButtonTwo;
    public Button ButtonThree;
    public Button ButtonFour;
    public Button ButtonFive;
    public Button ButtonSix;
    
  
    public GameObject[] Figure;
    void Start () 
    {
        Button BtnOne = ButtonOne.GetComponent<Button>();
		BtnOne.onClick.AddListener(TaskOnClick);
	     
        Button BtnTwo = ButtonOne.GetComponent<Button>();
		BtnTwo.onClick.AddListener(TaskOnClick);

        Button BtnThree = ButtonThree.GetComponent<Button>();
        

        Button BtnFour = ButtonFour.GetComponent<Button>();
		BtnFour.onClick.AddListener(TaskOnClickTwo);
	     
        Button BtnFive = ButtonFive.GetComponent<Button>();
		BtnFive.onClick.AddListener(TaskOnClickTwo);

        Button BtnSix = ButtonSix.GetComponent<Button>();
	}
    void TaskOnClick()
    {
        ButtonThree.gameObject.SetActive(true);
       
	}
    void TaskOnClickTwo()
    {
        ButtonSix.gameObject.SetActive(true);
       
	}
}
