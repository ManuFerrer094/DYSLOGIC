using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour {
    
    // Use this for initialization
    void Start() {
        Light[] Objetos = FindObjectsOfType<Light>();
        for (int i = 0; i < Objetos.Length; i++) {
            if (Objetos[i].name == this.gameObject.name)
            {
                Light OBJDESTROY = Objetos[i];
                Debug.Log(OBJDESTROY);
                //DontDestroyOnLoad(this.gameObject);

            }
            
        }

        


    }

    // Update is called once per frame
    void Update () {
		
	}
}
