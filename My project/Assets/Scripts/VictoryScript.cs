using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryScript : MonoBehaviour
{

    public PlayerMovement playerMovement;
    public int iloscPunktowDoZebrania;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            if (playerMovement.zebranePunkty == iloscPunktowDoZebrania)
            {
                Debug.Log("Wygrana");
            }
        }

    }
}
