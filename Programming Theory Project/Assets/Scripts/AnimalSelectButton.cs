using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalSelectButton : MonoBehaviour
{
    public bool isSelected;
    public List<AnimalSelectButton> sameListButtons;
    
    // Start is called before the first frame update
    void Start()
    {
        isSelected = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonClicked()
    {
        foreach (AnimalSelectButton button in sameListButtons)
        {
            button.isSelected = false;
            button.GetComponent<Outline>().enabled = false;
        }

        isSelected = true;
        GetComponent<Outline>().enabled = true;
    }
}
