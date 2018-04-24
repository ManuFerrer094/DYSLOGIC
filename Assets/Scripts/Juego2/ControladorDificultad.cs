using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorDificultad : MonoBehaviour {
    public int nivelDificultad = 0;
    public ControladorDificultad Usu;

	// Use this for initialization
	void Awake () {
        
        if (Usu == null)
        {
            Usu = this;
            DontDestroyOnLoad(gameObject);

        }
        else if (Usu != null)
        {
            Destroy(gameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
