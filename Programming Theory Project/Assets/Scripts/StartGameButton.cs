using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartGameButton : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI nameInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        gameManager.charname = nameInput.text;
    }
}
