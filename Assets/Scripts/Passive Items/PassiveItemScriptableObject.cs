using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="PassiveItemScriptableObject", menuName ="ScriptableObjects/Passive Item")]
public class PassiveItemScriptableObject : ScriptableObject
{
    [SerializeField]
    float multiplier;
    public float Multiplier {get => multiplier; private set => multiplier = value; }

    [SerializeField]
    int level;
    public int Level {get => level; private set => level = value;}

    [SerializeField]
    GameObject nextLevelPrefab;
    public GameObject NextLevelPrefab {get => nextLevelPrefab; private set => nextLevelPrefab = value;}

        [SerializeField]
    string passiveItemName;
    public string PassiveItemName {get => passiveItemName; private set => passiveItemName = value;}

    [SerializeField]
    string passiveItemDescription;
    public string PassiveItemDescription {get => passiveItemDescription; private set => passiveItemDescription = value;}

    [SerializeField]
    Sprite icon;
    public Sprite Icon {get => icon; private set => icon = value;}
}
