using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private string m_charname = "default";
    public string charname //ENCAPSULATION
    {
        get { return m_charname; }
        set { m_charname = SetName(value); }
    }
    public string characterUsed;



    public static GameManager instance;
    // Set up singleton for the Game Manager
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private string SetName(string value)
    {
        if (value.Length > 10)
        {
            return "Name too long";
        }
        else
        {
            return value;
        }

    }
}
