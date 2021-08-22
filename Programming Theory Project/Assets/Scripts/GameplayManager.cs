using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameplayManager : MonoBehaviour
{
    public TextMeshProUGUI nameDisplay;
    [SerializeField] private GameObject squirrelObject;
    [SerializeField] private GameObject grasshopperObject;

    // Start is called before the first frame update
    void Start()
    {
        //this should work once we load this scene from the main menu scene
        nameDisplay.text = GameManager.instance.charname;
        if (GameManager.instance.characterUsed =="Squirrel")
        {
            squirrelObject.SetActive(true);
        }
        else
        {
            grasshopperObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
