using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region If / Else

        /*
         * if (condicion)
        {
            print("el c�digo");
        }*/

        int numeroA = 10;
        int numeroB = 0;
        bool total = numeroA > numeroB;

        if (total)
        {
            print("Si es mayor");
        }

        #endregion

        #region Conectores L�gicos

        // CONECTORES L�GICOS
        // if (CONDICION_A CONECTOR_LOGICO CONDICION_B)
        // && (and/y)
        // || (or/o)
        // ! (not/contrario)

        #endregion

        #region Ejercicios en clase

        /*Dado un jugador que tiene 60 de vida y recibe 20 de da�o.
         * Si la vida resultante es menor o igual a 40: El jugador debe huir.
         * Si no: El jugador debe pelear.
         */

        int vidaJugador = 60;
        int da�o = 20;
        vidaJugador = vidaJugador - da�o;
        //Tambi�n se puede poner vidaJugador -= da�o;

        if (vidaJugador <= 40)
        {
            print("Huye");
        } else
        {
            print("Pelea");
        }

        /*Dado un jugador que tiene 60 de vida y recibe 20 de da�o.
         * Si la vida resultante es menor a 40: el jugador debe huir.
         * Si la vida resultante es mayor a 40: el jugador debe pelear.
         * Si la vida resultante es == a 40 el jugador debe festejar.
         */

        if(vidaJugador < 40)
        {
            print("Huye");
        } else if (vidaJugador > 40) {
            print("Pelea");
        } else if (vidaJugador == 40)
        {
            print("Ganastess");
        }


        /*Escribir un programa que le avise al jugador que se est� por morir
         * si su vida es menor a 20 y su escudo es menor a 20
         */

        int vidaEjercicio3 = 60;
        int damage = 45;
        vidaEjercicio3 = vidaEjercicio3 - damage;
        int escudo = 60;
        escudo = escudo - damage;

        if (vidaEjercicio3 < 20 && escudo < 20)
        {
            print("Te est�s por morir");
        }
        #endregion

        #region Ejercicios Tarea
        /*1. Dada las revoluciones por minuto de un auto en un juego de carreras, 
         indique si el conductor debe seguir con el mismo cambio, bajarlo o aumentarlo.
        Sabiendo que:
        - Si las RPM son menores a 1000 debe bajar
        - Si las RPM est�n entre 1000 y 3000 debe mantener
        - Si las RPM son m�s de 3000 debe subir*/

        int rpm = Random.Range(0, 4001);

        if (rpm < 1000)
        {
            print("Baja el cambio");
        } else if (rpm >= 1000 && rpm <= 3000)
        {
            print("Manten� el cambio");
        } else if (rpm > 3000)
        {
            print("Sub� el cambio");
        }


        /*2. Realice un programa que indique que acci�n debe realizar un personaje
         para un juego de RPG por turnos, a sabiendas que cada acci�n est� representada
        por un c�digo num�rico:
        - Si el c�digo de Acci�n es 0, el personaje debe indicar "Saltar"
        - Si el c�digo de Acci�n es 1 el personaje debe indicar "Atacar"
        - Si el c�digo de Acci�n es 2 el personaje debe indicar "Huir"
        - Si el c�digo de Acci�n es 3 el personaje debe indicar "Defenderse*/

        int codigo = Random.Range(-1, 4);

        if(codigo == 0)
        {
            print("Saltar");
        } else if (codigo == 1)
        {
            print("Atacar");
        } else if (codigo == 2)
        {
            print("Huir");
        } else if (codigo == 3)
        {
            print("Defender");
        }


        /*3. Realice un programa que dada la vida de un personaje, indique una acci�n:
         - Si la vida es menor a 50, que cure nuestro personaje con una poci�n
        grande de vida y nos muestre la vida actual despu�s de haberlo curado.
        - Si la vida es menor a 75, que cure a nuestro personaje con una poci�n
        chica de vida.
        - Si la vida es mayor o igual a 75 que no cure a nuestro personaje y nos 
        informe de ello.
        + La poci�n de vida chica cura 25 y la grande 50.*/

        int vidaPersonaje = Random.Range(0, 101);
        int pocionChica = 25;
        int pocionGrande = 50;

        if (vidaPersonaje < 50)
        {
            vidaPersonaje = vidaPersonaje + pocionGrande;
            print("Utilizaste una poci�n grande. Tu vida actual es " + vidaPersonaje);
        } else if (vidaPersonaje < 75)
        {
            vidaPersonaje = vidaPersonaje + pocionChica;
            print("Utilizaste una poci�n chica. Tu vida actual es " + vidaPersonaje);
        } else if (vidaPersonaje >= 75)
        {
            print("No necesitas curaci�n");
        }

        /*4. Realizar un programa que dada la vida de un personaje, realice una acci�n.
         - Si la vida est� entre 0 y 20 que el personaje huya.
        - Si la vida est� entre 21 y 50 que el personaje se ponga en modo defensivo.
        - Si la vida est� entre 51 y 80 que el personaje se ponga en modo moderado.
        - Si la vida est� entre 81 y 100 que el personaje se ponga en modo ofensivo.*/

        int personajeVida = Random.Range(0, 101);

        if(personajeVida >= 0 && personajeVida <= 20)
        {
            print("Huye");
        } else if (personajeVida >= 21 && personajeVida <= 50)
        {
            print("Defendete");
        } else if (personajeVida >= 51 && personajeVida <= 80)
        {
            print("Moderate");
        } else
        {
            print("Ofendete we");
        }


        /*5. Realice un programa que dado los stats de un personaje,
         indique si este jugador puede equipar la espada "Frostmourne",
        sabiendo los requisitos:
        - Fuerza 100
        - Destreza 50
        - Clase Palad�n
        + En caso de que el personaje no pueda equiparse el arma indique porqu�.*/

        int fuerza = Random.Range(98, 101);
        int destreza = Random.Range(48, 51);

        if (fuerza == 100)
        {
            if(destreza == 50)
            {
                print("Ganaste la espada Frostmourne");
            } else
            {
                print("No t�nes la destreza necesaria");
            }
            print("Ganaste la espada Frostmourne");
        } else
        {
            print("No ten�s la fuerza necesaria");
        }


        /*6. Realizar un programa que dado el string de la tecla que presion�,
         indique una acci�n a realizar.
        - Si la tecla que presion� es "arriba" o "barra espaciadora",
        que el personaje salte.
        - Si la tecla que presion� es "abajo" que el personaje se agache.
        - Si la tecla que presion� es "izquierda" que el personaje se desplace
        a la izquierda.
        - Si la tecla que presion� es "derecha" que el personaje se desplace
        a la derecha.
        - Si la tecla que presion� es "shift" o "enter" que el personaje dispare.
        - Si no es ninguna de ellas que nos avise que no puede realizar ninguna acci�n.
        + Inventar los c�digos de las teclas
        + Resolverlo con if  y con switch*/

        int arriba = 0;
        int barraEspaciadora = 1;
        int abajo = 2;
        int izquierda = 3;
        int derecha = 4;
        int shift = 5;
        int enter = 6;
        int teclaPresionada = Random.Range(-1, 10);

        if (teclaPresionada == arriba || teclaPresionada == barraEspaciadora)
        {
            print("Salt�");
        } else if (teclaPresionada == abajo)
        {
            print("Agachate");
        } else if(teclaPresionada == izquierda)
        {
            print("Movete a la izquierda");
        } else if (teclaPresionada == derecha)
        {
            print("Movete a la derecha");
        } else if (teclaPresionada == shift || teclaPresionada == enter)
        {
            print("Dispar�");
        } else
        {
            print("No se puede realizar ninguna acci�n");
        }

        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
