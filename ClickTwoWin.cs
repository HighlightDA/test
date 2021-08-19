using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickTwoWin : MonoBehaviour
{
    public Button ButtonSix;
    public bool ClickTwo;
  
    void Start()
    {
        Button BtnSix = ButtonSix.GetComponent<Button>();
        BtnSix.onClick.AddListener(TaskOnClick);
    }

      public void TaskOnClick()
    {
        bool ClickTwo = true;	
	}
}
