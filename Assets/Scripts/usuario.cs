using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System;
using UnityEngine.UI;
using UnityEngine;

public class usuario : MonoBehaviour {

    public string[] nombre = {"Andrea","Adrian","Fran","Manu","Sheldon" };
    public string currentName;
    
    public string caseSwicht;
    public InputField texto;
    public int _puntuacionMaxima;

    public static usuario Usu;
    private string ruta;



    private void Awake()
    {
        
        if (Usu == null)
        {
            Usu = this;
            DontDestroyOnLoad(gameObject);

        }
        else if (Usu != null) {
            Destroy(gameObject);
        }
       
        
    }

    public void Start()
    {
        texto = FindObjectOfType<InputField>();
        ruta = Application.persistentDataPath+"/datos.dat";
        Debug.Log(ruta);
        

    }

    public void Update()
    {
        
        

    }

    public void IntroducirUsuario() {
        switch (caseSwicht)
        {
            case "Andrea":
                Debug.Log("Nombre : " + caseSwicht);
                currentName = caseSwicht;
                

                if (File.Exists(ruta))
                {
                    Cargar(caseSwicht);
                }
                else {
                    _puntuacionMaxima = 0;
                }
                


                Application.LoadLevel("elegirJuego");
                break;

            case "Adrian":
                Debug.Log("Nombre : " + caseSwicht);
                Application.LoadLevel("elegirJuego");
                break;


        }
    }

    public void cambiarUsuario() {
        caseSwicht = texto.text;
    }

    public void Guardar(string Nombre) {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(ruta);

        datosGuardar datos = new datosGuardar();
        switch (Nombre)
        {
            case "Andrea":
                datos.puntuacionMaxAndrea = _puntuacionMaxima;
                bf.Serialize(file, datos);
                file.Close();
                break;

        }

        
        



    }

    public void Cargar(string Nombre) {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Open(ruta, FileMode.Open);

        datosGuardar datos = (datosGuardar)bf.Deserialize(file);
        switch (Nombre)
        {
            case "Andrea":
                //_puntuacionMaxima = datos.puntuacionMaxAndrea;
                Debug.Log("Los datos cargados son :"+datos.puntuacionMaxAndrea);
                break;

        }

        file.Close();

    }

    [Serializable]
    class datosGuardar {
        //variable de control, es el current puntuacion.
        public int puntuacionMaxima;
        //variable por cada usuario.
        public int puntuacionMaxAndrea;
        //otros datos a guardar.



    }

}
