using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    
    public GameObject Testobj;

    public void Deactive()
    {
        if (Testobj.active == true)
            Testobj.SetActive(false);

        else if (Testobj.active == false)
            Testobj.SetActive(true);
    }
}
