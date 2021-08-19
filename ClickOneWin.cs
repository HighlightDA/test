using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickOneWin : MonoBehaviour
{
    public Button ButtonThree;
        public  bool ClickOne;
    void Start()
    {
        Button BtnTree = ButtonThree.GetComponent<Button>();
		BtnTree.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
        bool ClickOne = true;
	}
}
