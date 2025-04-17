using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "Char", menuName = "ScriptableObjects/Characters")]
public class ScriptObjData : ScriptableObject
{
    public string charName;
    public int strength;
    public int charisma;
    public int intelligence;
    public int knowledge;
    public Sprite charImage;

    [TextArea(2, 4)]
    public string shortDesc;

}
