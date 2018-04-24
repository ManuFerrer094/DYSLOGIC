using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elegirJuego : MonoBehaviour {

    
    public string direccion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public void IrJuego() {

        Application.LoadLevel(direccion);
    }
}
