using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Updater : MonoBehaviour
{

    public GameObject[] others;    
    Button button;

    public GameObject activeChar;
    private ScriptObjData scriptObjRef;
    private UIPopulate refToUIcomp;

    void Start()
    {
        button = GetComponent<Button>();
        refToUIcomp = GetComponent<UIPopulate>();
        scriptObjRef = refToUIcomp.charObject;
    }


    public void ClickedOn()
    {
        activeChar.GetComponent<UIPopulate>().charObject = scriptObjRef;
        activeChar.GetComponent<UIPopulate>().UpdateInfo();

        foreach (GameObject obj in others)
        {
            obj.GetComponent<Button>().interactable = true;
        }

        button.interactable = false;
    }


}
