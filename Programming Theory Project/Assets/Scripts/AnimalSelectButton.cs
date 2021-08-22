using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalSelectButton : MonoBehaviour
{
    [SerializeField]
    private bool m_isSelected;
    public bool isSelected
    {
        get { return m_isSelected; }
        set { m_isSelected = value; }
    }
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
