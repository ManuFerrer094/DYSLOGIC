using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juego_02 : MonoBehaviour {

    [SerializeField] protected GameObject[] suelo;
    [SerializeField] protected GameObject Entrada;
    protected bool hayentrada;
    [SerializeField] protected GameObject Salida;
    protected bool haysalida;

    [SerializeField] protected GameObject Jugador;
    protected bool jugadorActivo = false;
  
    public ControladorDificultad dificultad;

    public bool restart =false;
    
	// Use this for initialization
	void Start () {
        dificultad = FindObjectOfType<ControladorDificultad>();
      
        Debug.Log(dificultad);
       
        if (dificultad) {
            EmpezarJuego();
        }
        
        

    }
	
	// Update is called once per frame
	void Update () {
        if (restart == true) {
            Reiniciar();
        }

        
    }

    void EmpezarJuego() {
        
        
        switch (dificultad.nivelDificultad)
        {

            case 1:
                

                for (int u = 0; u < dificultad.nivelDificultad * 3; u++)
                {
                    for (int i = 0; i < dificultad.nivelDificultad * 3; i++)
                    {
                        

                        if (i == 1 && hayentrada == false)
                        {
                            GameObject currentEntrada = Instantiate(Entrada);
                            currentEntrada.transform.position = new Vector3(0 + i, 0, 0 + u);
                            hayentrada = true;

                            GameObject Player = Instantiate(Jugador);
                            Player.transform.position = new Vector3(0 + i, 1, 0 + u);

                        }
                        else if (i == (int)Random.Range(0, 2) && haysalida == false && u == (int)Random.Range(2, 2))
                        {
                            GameObject currentEntrada = Instantiate(Salida);
                            currentEntrada.transform.position = new Vector3(0 + i, 0, 0 + u);
                            haysalida = true;
                        }

                        else
                        {
                            GameObject currentSuelo = Instantiate(suelo[Random.Range(0, suelo.Length)]);
                            currentSuelo.transform.position = new Vector3(0 + i, 0, 0 + u);
                        }


                    }
                }

                if (haysalida == false)
                {
                    GameObject currentEntrada = Instantiate(Salida);
                    currentEntrada.transform.position = new Vector3(2, 0, 3);
                    haysalida = true;
                }

                break;
            case 2:
               

                for (int u = 0; u < dificultad.nivelDificultad * 2; u++)
                {
                    for (int i = 0; i < dificultad.nivelDificultad * 2; i++)
                    {

                        if (i == 3 && hayentrada == false)
                        {
                            GameObject currentEntrada = Instantiate(Entrada);
                            currentEntrada.transform.position = new Vector3(0 + i, 0, 0 + u);
                            hayentrada = true;

                            GameObject Player2 = Instantiate(Jugador);
                            Player2.transform.position = new Vector3(0 + i, 1, 0 + u);
                            

                        }
                        else if (i == (int)Random.Range(2, 4) && haysalida == false && u == (int)Random.Range(2, 4))
                        {
                            GameObject currentEntrada = Instantiate(Salida);
                            currentEntrada.transform.position = new Vector3(0 + i, 0, 0 + u);
                            haysalida = true;
                           
                        }

                        else
                        {
                            GameObject currentSuelo = Instantiate(suelo[Random.Range(0, suelo.Length)]);

                            currentSuelo.transform.position = new Vector3(0 + i, 0, 0 + u);
                         
                        }

                        if (haysalida == false)
                        {
                            GameObject currentEntrada = Instantiate(Salida);
                            currentEntrada.transform.position = new Vector3(Random.Range(2,5), 0, Random.Range(2, 5));
                            haysalida = true;
                        }


                    }
                }
                if (haysalida == false)
                {
                    GameObject currentEntrada = Instantiate(Salida);
                    currentEntrada.transform.position = new Vector3(4, 0, 4);
                    haysalida = true;
                }

                break;
            case 3:
              

                for (int u = 0; u < dificultad.nivelDificultad * 2; u++)
                {
                    for (int i = 0; i < dificultad.nivelDificultad * 2; i++)
                    {
                        GameObject currentSuelo = Instantiate(suelo[Random.Range(0, suelo.Length)]);
                        currentSuelo.transform.position = new Vector3(0 + i, 0, 0 + u);

                        if (i == 3 && hayentrada == false)
                        {
                            GameObject currentEntrada = Instantiate(Entrada);
                            currentEntrada.transform.position = new Vector3(0 + i, 0, 0 + u);
                            hayentrada = true;

                            GameObject Player = Instantiate(Jugador);
                            Player.transform.position = new Vector3(0 + i, 1, 0 + u);
                            
                        }
                        if (i == (int)Random.Range(1, 3) && haysalida == false && u == (int)Random.Range(1, 3))
                        {
                            GameObject currentEntrada = Instantiate(Salida);
                            currentEntrada.transform.position = new Vector3(0 + i, 0, 0 + u);
                            haysalida = true;
                        }
                        if (haysalida == false)
                        {
                            GameObject currentEntrada = Instantiate(Salida);
                            currentEntrada.transform.position = new Vector3(Random.Range(2, 5), 0, Random.Range(2, 5));
                            haysalida = true;
                        }



                    }
                }

                break;
            case 4:


                for (int u = 0; u < dificultad.nivelDificultad * 3; u++)
                {
                    for (int i = 0; i < dificultad.nivelDificultad * 3; i++)
                    {
                        GameObject currentSuelo = Instantiate(suelo[Random.Range(0, suelo.Length)]);
                        currentSuelo.transform.position = new Vector3(0 + i, 0, 0 + u);

                        if (i == 3 && hayentrada == false)
                        {
                            GameObject currentEntrada = Instantiate(Entrada);
                            currentEntrada.transform.position = new Vector3(0 + i, 0, 0 + u);
                            hayentrada = true;

                            GameObject Player = Instantiate(Jugador);
                            Player.transform.position = new Vector3(0 + i, 1, 0 + u);
                            
                        }
                        if (i == (int)Random.Range(1, 3) && haysalida == false && u == (int)Random.Range(1, 3))
                        {
                            GameObject currentEntrada = Instantiate(Salida);
                            currentEntrada.transform.position = new Vector3(0 + i, 0, 0 + u);
                            haysalida = true;
                        }




                    }
                }

                break;
            case 5:


                for (int u = 0; u < dificultad.nivelDificultad * 3; u++)
                {
                    for (int i = 0; i < dificultad.nivelDificultad * 3; i++)
                    {
                        GameObject currentSuelo = Instantiate(suelo[Random.Range(0, suelo.Length)]);
                        currentSuelo.transform.position = new Vector3(0 + i, 0, 0 + u);

                        if (i == 3 && hayentrada == false)
                        {
                            GameObject currentEntrada = Instantiate(Entrada);
                            currentEntrada.transform.position = new Vector3(0 + i, 0, 0 + u);
                            hayentrada = true;

                            GameObject Player = Instantiate(Jugador);
                            Player.transform.position = new Vector3(0 + i, 1, 0 + u);
                         
                        }
                        if (i == (int)Random.Range(1, 3) && haysalida == false && u == (int)Random.Range(1, 3))
                        {
                            GameObject currentEntrada = Instantiate(Salida);
                            currentEntrada.transform.position = new Vector3(0 + i, 0, 0 + u);
                            haysalida = true;
                        }




                    }
                }

                break;
        }
    }
    void Reiniciar() {
        dificultad.nivelDificultad++;
        if (dificultad.nivelDificultad <= 3)
        {
            Application.LoadLevel("Juego2");
        }
        else {
            dificultad.nivelDificultad = 1;
            Application.LoadLevel("elegirJuego");
        }
       
        

    }
}
