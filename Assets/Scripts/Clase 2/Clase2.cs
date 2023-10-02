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
        //Cómo crear una variable
        //1. Definir qué tipo de datos vamos a usar
        //2. Elegir el nombre que le vamos a poner para invocar a este dato que tiene dentro la variable
        //3. Poner ; al final
        string textoParaConsola;

        //Cómo le pongo un dato a una variable
        //1. Identifico qué variable quiero ponerle al dato
        //2. Uso el operador de asignación para decirle a una variable qué dato tiene: =
        //NombredeVariable = dato;
        textoParaConsola = "Hola mundo";


        //Números Enteros: int
        int numeroEntero = 10;
        int numeroEnteroNegativo = -1;

        //Números Enteros Positivos = uint
        uint numeroEnteroPositivo = 1;


        //Números Reales: float (acepta decimales) hay que poner la f al final siempre para indicar
        //que es un número flotante
        float numeroReal = 2.5f;


        //Cadenas de texto (o cadenas de caracteres): string
        string textoParaConsola1 = "Hola mundo";


        //Estado Lógico (Verdadero o Falso): bool
        bool estadoLogico = true;
        bool estadoLogico2 = false;
        #endregion

        #region Operadores Aritméticos
        //Los operadores aritméticos son las herramientas para manipular números
        // + Para hacer una suma
        // - PAra hacer una resta
        // * Para hacer una multiplicación
        // / Para hacer una división
        // % Para obtener el módulo de una división (resto)

        numeroEntero = numeroEntero + 5;
        numeroEntero = numeroEntero - 5;

        int resultado = numeroEntero % 5;

        #endregion

        #region Operadores de Comparación
        // > Mayor que
        // < Menor que
        // >= Es mayor o igual que
        // <= Es menor o igual que
        // == Es exactamente igual (mismo dato)
        // != Es distinto
        #endregion

        #region EJERCICIOS
        /*En un juego de rol nuestro personaje necesita curarse, para ellos
         * deberá utilizar una poción grande de vida que cura 25 de vida.
         * Sabiendo que la vida del personaje es 40 y que el personaje posee
         * una pasiva que permite recibir un 25% más de curación. realice un programa
         * que cure al personaje y luego muestre la vida resultante.
         */

        //poción cura 25 de vida
        //personaje tiene 40 de vida
        //la pasiva es una mejora del 25%
        //A la vida hay que sumarle lo que cura la poción, más el 25% de
        //lo que la poción cura

        float vida = 40;
        float cura = 25 * 1.25f;
        vida = vida + cura;
        print("La vida resultante es " + vida);


        /* En el LOL el campeón Leona, posee una armadura de 200,
         al mismo tiempo posee una pasiva que reduce el daño recibido un 80%.
         Sabiendo que el daño recibido es de 400 y que el valor de la defensa 
         se le resta de manera directa al daño recibido, realice un programa que
         muestre en la consola cual es el daño real que recibiría Leona
        */

        //Vida de Leona 200
        //Pasiva reduce un 80% del daño recibido
        //Daño recibido 400

        float vidaLeona = 200f;
        float daño = 400;
        float pasiva = 400 * 0.8f;
        daño = daño - pasiva;
        vidaLeona = vidaLeona - daño;
        print("El daño que recibe Leona es " + daño + ". La vida restante es " + vidaLeona);


        /* Dado el daño base de su personaje, realice un programa que 
          Calcule su daño crítico sabiendo que la fórmula es 
          DC = (daño base)2(al cuadrado) + 80% del daño base*/

        float dañoBase = 10;
        float dañoCritico = Mathf.Pow(dañoBase,2) + (dañoBase * 1.8f);
        print("El daño crítico es " + dañoCritico);


        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
