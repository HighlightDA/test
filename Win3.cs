using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Win3 : MonoBehaviour
{
    private UnityEngine.Object Finish;
    public GameObject Buttons;
    public bool clickone;
    public bool clicktwo;


    void Start()
    {
        clickone = Buttons.GetComponent<ClickOneWin>().ClickOne;
        clicktwo = Buttons.GetComponent<ClickTwoWin>().ClickTwo;
        
    
    }

    void Update()
    {  
     if (clickone == true && clicktwo == true)
     {
     GameObject FinishRef =(GameObject)Instantiate(Finish);
     FinishRef.transform.position = new Vector3(transform.position.x, transform.position.y,transform.position.z);
     Destroy(gameObject);
        }
    }
}
