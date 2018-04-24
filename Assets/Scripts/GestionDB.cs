using System.Collections;

using UnityEngine.UI;
using UnityEngine;

public class GestionDB : MonoBehaviour {
    public InputField txtUsuario;
    public InputField txtContraseña;
    public string nombreUsuario;
    public int puntuacionEjercicio1;

    public void iniciarSesion() {
        StartCoroutine(login());
    }

    public  IEnumerator login() {

        WWW conection = new WWW("http://localhost/DyslogicDb/login.php?uss="+txtUsuario.text+"&pss="+txtContraseña.text+"");
        yield return (conection);
        print(conection.text);
        
        if (conection.text == "200")
        {
            print("El usuario es correcto");
            StartCoroutine(datos());
        }
        else if (conection.text == "401")
        {
            print("El usuario o contraseña incorrecta");
        }
        else {
            print("Fallo de conexion con la base de datos");
        }


    }

    public IEnumerator datos()
    {

        WWW conection = new WWW("http://localhost/DyslogicDb/datos.php?uss=" + txtUsuario.text);
        yield return (conection);
        if (conection.text == "401") { print("el usuario es incorrecto"); }
        else {
            string[] nDatos = conection.text.Split('|');
            if (nDatos.Length != 2)
            {
                print("algo no va bien");
            }
            else {
                nombreUsuario = nDatos[0];
                puntuacionEjercicio1 = int.Parse(nDatos[1]);
                print("El usuario" + nombreUsuario + "tiene una puntuacion en el ejercicio 1 de " + puntuacionEjercicio1 + "puntos");

            }
        }
    }
}
