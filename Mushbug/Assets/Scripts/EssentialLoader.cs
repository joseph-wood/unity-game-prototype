using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EssentialLoader : MonoBehaviour {

    public GameObject character;
    
    // Use this for initialization
	void Start () {
        if (PlayerController.instance == null)
        {
            Instantiate(character);
        }
    }
}
