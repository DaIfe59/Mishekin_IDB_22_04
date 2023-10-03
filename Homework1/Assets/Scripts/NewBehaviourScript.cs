using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    
    public GameObject Testobj;

    public void Deactive()
    {
        Testobj.SetActive(false);
    }
}
