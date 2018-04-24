using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
   

    public int contador = 0;
    

    protected Vector3 lastPosition;
    protected GameObject Salida;
    public Juego_02 juego;
    protected Camera cam;
    public ControladorDificultad dificultad;
    // Use this for initialization
    private void Awake()
    {
       
    }

    void Start () {
        Salida = GameObject.FindGameObjectWithTag("Salida");
        juego = FindObjectOfType<Juego_02>();
        cam = GetComponentInChildren<Camera>();
        dificultad = FindObjectOfType<ControladorDificultad>();

    }
	
	// Update is called once per frame
	void Update () {
        if (dificultad.nivelDificultad == 1) {
            cam.orthographicSize = 3.5f;
        }
        if (dificultad.nivelDificultad == 2)
        {
            cam.orthographicSize = 5f;
        }
        if (dificultad.nivelDificultad == 3)
        {
            cam.orthographicSize = 7f;
        }

        if (Input.GetKeyDown(KeyCode.W)) {
            lastPosition = transform.position;

            this.gameObject.transform.position += new Vector3(0, 0, 1);
            contador++;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            this.gameObject.transform.position += new Vector3(0, 0, -1);
            contador++;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            this.gameObject.transform.position += new Vector3(-1, 0, 0);
            contador++;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.gameObject.transform.position += new Vector3(1, 0, 0);
            contador++;
        }
        RaycastHit hit;

        if (Physics.Raycast(transform.position, -Vector3.up, out hit))
            print("Found an object - name: " + hit.collider.name);

        if (this.transform.position.x == Salida.transform.position.x && this.transform.position.z == Salida.transform.position.z) {
            juego.restart = true;
        }
        

    }

    
}
