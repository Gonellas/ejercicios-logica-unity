using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region WHILE
        //Mientras CONDICION ejecuto c�digo
        //Es un bucle infinito, la condici�n tiene que tener un tope sino no para
        /*while (true)
        {
            print("Problema");
        }*/

        /*Realicemos un programa donde el jugador realice 6 disparos*/
        int contador = 0;
        int maxDisparos = 6;
        while (contador < maxDisparos)
        {
            contador = contador + 1;
            print("Ejecuci�n n�mero " + contador);
        }


        //Ejercicio 2
        int maxNotas = 7;
        int contador1 = 0;
        int nota;
        int sumTotal = 0;

        while (contador1 < maxNotas)
        {
            contador1 = contador1 + 1;
            nota = Random.Range(0, 11);
            sumTotal = sumTotal + nota;
            print("la suma total de las notas es " + sumTotal);
        }

        int promedio = sumTotal / maxNotas;
        print("El promedio random de este alumno es: " + promedio);

        #endregion
        #region TAREA

        /*1.En un juego de pelea un personaje (Seiya) utiliza un skill (Meteoro de Pegas�),
         * el skill funciona de esta manera:
            El contrincante recibir� 10 golpes
            Cada uno de esos golpes proporciona un da�o que varia entre 1000 y 2000 de manera aleatoria
            a. Muestre cual fue el da�o recibido por el contrincante en cada golpe
            b. Muestre el da�o total final que el enemigo recibi� */

        int golpesSkill = 10;
        int da�oGolpe = 0;
        int contadorGolpes = 0;
        int da�oFinal = 0;

        while (contadorGolpes < golpesSkill)
        {
            contadorGolpes = contadorGolpes + 1;
            da�oGolpe = Random.Range(1000, 2001);
            print("El da�o del golpe fue " + da�oGolpe);
            da�oFinal = da�oFinal + da�oGolpe;
        }
        
        print("El da�o total fue " + da�oFinal);


        /*2. 2. Realice un programa que genere 10 oleadas de enemigos que var�an entre 10 y 100.
         * Por cada oleada el Player1 eliminara un numero aleatorio de enemigos de la misma.
         * Al finalizar las oleadas indique:
            a. �Cu�ntos enemigos fueron generados?
            b. �Cu�ntos enemigos quedan vivos?
            c. En cada oleada el programa deber� indicas �Se generaron X enemigos�*/

        int oleadasEnemigos = 10;
        int cantidadDeEnemigos;
        int cantidadDeEnemigosTotal = 0;
        int player1;
        int contador2 = 0;

        while(contador2 < oleadasEnemigos)
        {
            contador2 = contador2 + 1;
            cantidadDeEnemigos = Random.Range(10, 100 + 1);
            print("La cantidad de enemigos generados fueron " + cantidadDeEnemigos);
            cantidadDeEnemigosTotal = cantidadDeEnemigosTotal + cantidadDeEnemigos;
        }

        print("Se generaron un total de " + cantidadDeEnemigosTotal + " enemigos en total.");
        player1 = Random.Range(0, cantidadDeEnemigosTotal);
        player1 = cantidadDeEnemigosTotal - player1;
        print("La cantidad de enemigos eliminados es " + player1);


        /*3. Programe un skill de un personaje que pegue golpes consecutivos hasta que el golpe sea errado
            (da�o cero) el da�o de cada golpe varia entre 0 y 10. Indique:
            a. Cual fue el da�o otorgado al enemigo
            b. Cuantos golpes consecutivos se asestaron
            c. Cada vez que se genere un golpe mostrar cual fue el da�o generado*/

        int da�oGolpe3 = Random.Range(0,11);
        int contadorGolpe = 0;
        int da�oFinal3 = 0;

        while (da�oGolpe3 != 0)
        {
            print("El da�o del golpe es " + da�oGolpe3);
            contadorGolpe = contadorGolpe + 1;
            print("La cantidad de golpes fueron " + contadorGolpe);
            da�oFinal3 = da�oFinal3 + da�oGolpe;
        }

        print("El da�o otorgado al enemigo fue " + da�oFinal3);


        /*4. Programe un skill de un personaje que pegue golpes consecutivos hasta que el contrincante
        fallezca o se superen los 10 golpes. Cada golpe proporcionado por el skill var�a entre 100 y 500
        de da�o. La vida del contrincante es de 2500
        a. Indique en caso de que el enemigo no haya muerto, cual es su vida resultante, y cual fue
        el da�o recibido
        b. Indique en caso de que el enemigo haya muerto cuantos golpes se necesit� para
        matarlo.
        c. En todos los casos el programa deber� mostrar el da�o parcial acumulado y la vida
        actual del contrincante.*/

        /*int vidaEnemigo = 2500;
        int cantGolpes = 10;
        int da�oSkill;
        int contador4 = 0;
        int da�oTot=0;

        while (contador4 < cantGolpes || vidaEnemigo == 0)
        {
            contador4 = contador4 + 1;
            da�oSkill = Random.Range(100, 500);
            da�oTot = da�oTot + da�oSkill;
            vidaEnemigo = vidaEnemigo - da�oTot;
            if (vidaEnemigo != 0 && contador4 == 10)
            {
                vidaEnemigo = vidaEnemigo - da�oSkill;
                print("La vida del enemigo es " + vidaEnemigo);
                da�oTot = da�oTot + da�oSkill;
                print("El da�o acumulado fue de " + da�oTot);
            } else if(vidaEnemigo == 0)
            {
                print("La cantidad de golpes que se necesitaron para matarlo fueron " + contador4);
                da�oTot = da�oTot + da�oSkill;
                print("El da�o acumulado fue de " + da�oTot);
            }
        }*/


        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
