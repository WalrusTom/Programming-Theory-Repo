using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameplayManager : MonoBehaviour
{
    public TextMeshProUGUI nameDisplay;
    // Start is called before the first frame update
    void Start()
    {
        //this should work once we load this scene from the main menu scene
        //nameDisplay.text = GameManager.instance.charname;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
