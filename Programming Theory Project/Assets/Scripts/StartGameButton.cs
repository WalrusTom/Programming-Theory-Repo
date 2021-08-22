using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    public GameManager gameManager;
    public TextMeshProUGUI nameInput;
    public AnimalSelectButton squirrelButton;
    public AnimalSelectButton grasshopperButton;

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
        if (squirrelButton.isSelected)
        {
            GameManager.instance.characterUsed = "Squirrel";
        }
        else
        {
            GameManager.instance.characterUsed = "Grasshopper";
        }
        SceneManager.LoadScene(1);
    }
}
