using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIPopulate : MonoBehaviour
{

    public ScriptObjData charObject;
    public TextMeshProUGUI charName;
    public TextMeshProUGUI desc;
    public TextMeshProUGUI str;
    public TextMeshProUGUI intel;
    public TextMeshProUGUI cha;
    public TextMeshProUGUI knw;
    public GameObject charImg;


    void Start()
    {
        
        if (charObject != null)
        {
            UpdateInfo();

        }

    }

    public void UpdateInfo()
    {

        charName.text = charObject.charName;
        desc.text = charObject.shortDesc;
        str.text = charObject.strength.ToString();
        intel.text = charObject.intelligence.ToString();
        cha.text = charObject.charisma.ToString();
        knw.text = charObject.knowledge.ToString();

        Image charImgComp = charImg.GetComponent<Image>();
        charImgComp.sprite = charObject.charImage;
    }


}
