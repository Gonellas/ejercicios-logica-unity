using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Escribir en la consola el mensaje que pasamos entre comillas
        print("hola");


        #region Datos Primitivos
        //C�mo crear una variable
        //1. Definir qu� tipo de datos vamos a usar
        //2. Elegir el nombre que le vamos a poner para invocar a este dato que tiene dentro la variable
        //3. Poner ; al final
        string textoParaConsola;

        //C�mo le pongo un dato a una variable
        //1. Identifico qu� variable quiero ponerle al dato
        //2. Uso el operador de asignaci�n para decirle a una variable qu� dato tiene: =
        //NombredeVariable = dato;
        textoParaConsola = "Hola mundo";


        //N�meros Enteros: int
        int numeroEntero = 10;
        int numeroEnteroNegativo = -1;

        //N�meros Enteros Positivos = uint
        uint numeroEnteroPositivo = 1;


        //N�meros Reales: float (acepta decimales) hay que poner la f al final siempre para indicar
        //que es un n�mero flotante
        float numeroReal = 2.5f;


        //Cadenas de texto (o cadenas de caracteres): string
        string textoParaConsola1 = "Hola mundo";


        //Estado L�gico (Verdadero o Falso): bool
        bool estadoLogico = true;
        bool estadoLogico2 = false;
        #endregion

        #region Operadores Aritm�ticos
        //Los operadores aritm�ticos son las herramientas para manipular n�meros
        // + Para hacer una suma
        // - PAra hacer una resta
        // * Para hacer una multiplicaci�n
        // / Para hacer una divisi�n
        // % Para obtener el m�dulo de una divisi�n (resto)

        numeroEntero = numeroEntero + 5;
        numeroEntero = numeroEntero - 5;

        int resultado = numeroEntero % 5;

        #endregion

        #region Operadores de Comparaci�n
        // > Mayor que
        // < Menor que
        // >= Es mayor o igual que
        // <= Es menor o igual que
        // == Es exactamente igual (mismo dato)
        // != Es distinto
        #endregion

        #region EJERCICIOS
        /*En un juego de rol nuestro personaje necesita curarse, para ellos
         * deber� utilizar una poci�n grande de vida que cura 25 de vida.
         * Sabiendo que la vida del personaje es 40 y que el personaje posee
         * una pasiva que permite recibir un 25% m�s de curaci�n. realice un programa
         * que cure al personaje y luego muestre la vida resultante.
         */

        //poci�n cura 25 de vida
        //personaje tiene 40 de vida
        //la pasiva es una mejora del 25%
        //A la vida hay que sumarle lo que cura la poci�n, m�s el 25% de
        //lo que la poci�n cura

        float vida = 40;
        float cura = 25 * 1.25f;
        vida = vida + cura;
        print("La vida resultante es " + vida);


        /* En el LOL el campe�n Leona, posee una armadura de 200,
         al mismo tiempo posee una pasiva que reduce el da�o recibido un 80%.
         Sabiendo que el da�o recibido es de 400 y que el valor de la defensa 
         se le resta de manera directa al da�o recibido, realice un programa que
         muestre en la consola cual es el da�o real que recibir�a Leona
        */

        //Vida de Leona 200
        //Pasiva reduce un 80% del da�o recibido
        //Da�o recibido 400

        float vidaLeona = 200f;
        float da�o = 400;
        float pasiva = 400 * 0.8f;
        da�o = da�o - pasiva;
        vidaLeona = vidaLeona - da�o;
        print("El da�o que recibe Leona es " + da�o + ". La vida restante es " + vidaLeona);


        /* Dado el da�o base de su personaje, realice un programa que 
          Calcule su da�o cr�tico sabiendo que la f�rmula es 
          DC = (da�o base)2(al cuadrado) + 80% del da�o base*/

        float da�oBase = 10;
        float da�oCritico = Mathf.Pow(da�oBase,2) + (da�oBase * 1.8f);
        print("El da�o cr�tico es " + da�oCritico);


        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
