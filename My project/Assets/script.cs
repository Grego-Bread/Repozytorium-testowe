using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{


    public PlayerMovement playerMovement;
    public TextMeshProUGUI text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = playerMovement.zebranePunkty.ToString();

        if (playerMovement.zebranePunkty == 4)
        {
            text.color = Color.green;
        }
    }
}
