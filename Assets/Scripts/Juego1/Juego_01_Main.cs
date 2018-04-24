using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Juego_01_Main : MonoBehaviour {
    //Creo un canvas
    protected Canvas canvas;
    //Le paso por inspector(Aunque protegido) unas imagenes
    [SerializeField] protected Image[] imagen;
    //Me guardo una variable para saber cual es la imagen seleccionada
    protected Image currentImage;
    //Lo mismo para guardar un texto ganador
    protected string textoCorrecto;
   //Le paso por inspector una lista de Botones
    [SerializeField] protected Button[] boton;
    public Text[] textos;

    //creo una LISTA (por que el array es un pequeño cabron) para almacenar palabras
    protected List<string> palabras_1;

    //guardo memoria para una variables de control (azucar sintactico made in JV)
    int caseSwitch;
    int phase;

    //Le paso por inspector un texto que hara las funciones de contador

    public Text contador;
    //Defino el tiempo de espera
    protected float tiempo = 10f;
    //defino un color para hacer el efecto de cambio de color
    Color controllerCol = new Color(0,1,0);

    public int puntuacion = 10000;

    public usuario user;

    protected bool hecomenzado = false;

    private void Awake()
    {
        user = FindObjectOfType<usuario>();
       //Recojo todos los componentes
        canvas = FindObjectOfType<Canvas>();

        contador = GameObject.Find("Contador").GetComponent<Text>();
        //elijo un case aleatorio entre el minimo numero de elementos en la lista de imagenes y el maximo(y le sumo 1 por que el ultimo elemtno no es inclusivo)
        caseSwitch =(int) Random.Range(1,imagen.Length+1);
        //defino contador
        contador.text = " " + tiempo;
        
        //defino palabras_1
        palabras_1 = new List<string>();
        
        //apago todos los textos por defecto
        for (int i = 0; i < boton.Length; i++) {
            boton[i] = GameObject.Find("Boton" + i).GetComponent<Button>();
            
            boton[i].gameObject.SetActive(false);
            textos[i] = GameObject.Find("Btext" + i).GetComponent<Text>();

        }


    }

    void Start ()
    {
        //declaro la phase
        phase = 1;

        //esta claro no?
        elegirImagen();
       
       
       
      
    }
	

	void Update ()
    {
        switch (phase) {
            case 1:
                
                if (tiempo > 0)
                {

                    tiempo -= Time.deltaTime;
                    contador.text = " " + tiempo.ToString("f0");
                    controllerCol.g -= tiempo / 5000;

                    controllerCol.r += tiempo / 7000;
                    contador.color = controllerCol;
                    hecomenzado = true;


                }
                else {
                    if (hecomenzado) {
                        for (int i = 0; i < boton.Length; i++)
                        {
                            boton[i] = GameObject.Find("Boton" + i).GetComponent<Button>();
                            
                            boton[i].gameObject.SetActive(true);

                        }
                        contador.enabled = !contador.enabled;
                        currentImage.enabled = !currentImage.enabled;
                        hecomenzado = false;
                    }
 
                    
                }

                break;


       
        }


    }

    void elegirImagen() {
        for (int i = 0; i < imagen.Length; i++) {

            imagen[i].enabled = !imagen[i].enabled;
        }

        switch (caseSwitch)
        {
            case 1:
                
                currentImage = imagen[caseSwitch-1];
                currentImage.enabled = true;
                textos[Random.Range(0, textos.Length)].text = currentImage.name;
                Debug.Log("Curent = "+currentImage);


                break;
            case 2:
              
                currentImage = imagen[caseSwitch-1];
                currentImage.enabled = true;
                textos[Random.Range(0, textos.Length)].text = currentImage.name;
                Debug.Log("Curent = " + currentImage);
                break;
        }

    }
}
