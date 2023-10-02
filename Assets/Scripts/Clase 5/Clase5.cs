using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region WHILE
        //Mientras CONDICION ejecuto código
        //Es un bucle infinito, la condición tiene que tener un tope sino no para
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
            print("Ejecución número " + contador);
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

        /*1.En un juego de pelea un personaje (Seiya) utiliza un skill (Meteoro de Pegasó),
         * el skill funciona de esta manera:
            El contrincante recibirá 10 golpes
            Cada uno de esos golpes proporciona un daño que varia entre 1000 y 2000 de manera aleatoria
            a. Muestre cual fue el daño recibido por el contrincante en cada golpe
            b. Muestre el daño total final que el enemigo recibió */

        int golpesSkill = 10;
        int dañoGolpe = 0;
        int contadorGolpes = 0;
        int dañoFinal = 0;

        while (contadorGolpes < golpesSkill)
        {
            contadorGolpes = contadorGolpes + 1;
            dañoGolpe = Random.Range(1000, 2001);
            print("El daño del golpe fue " + dañoGolpe);
            dañoFinal = dañoFinal + dañoGolpe;
        }
        
        print("El daño total fue " + dañoFinal);


        /*2. 2. Realice un programa que genere 10 oleadas de enemigos que varían entre 10 y 100.
         * Por cada oleada el Player1 eliminara un numero aleatorio de enemigos de la misma.
         * Al finalizar las oleadas indique:
            a. ¿Cuántos enemigos fueron generados?
            b. ¿Cuántos enemigos quedan vivos?
            c. En cada oleada el programa deberá indicas “Se generaron X enemigos”*/

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
            (daño cero) el daño de cada golpe varia entre 0 y 10. Indique:
            a. Cual fue el daño otorgado al enemigo
            b. Cuantos golpes consecutivos se asestaron
            c. Cada vez que se genere un golpe mostrar cual fue el daño generado*/

        int dañoGolpe3 = Random.Range(0,11);
        int contadorGolpe = 0;
        int dañoFinal3 = 0;

        while (dañoGolpe3 != 0)
        {
            print("El daño del golpe es " + dañoGolpe3);
            contadorGolpe = contadorGolpe + 1;
            print("La cantidad de golpes fueron " + contadorGolpe);
            dañoFinal3 = dañoFinal3 + dañoGolpe;
        }

        print("El daño otorgado al enemigo fue " + dañoFinal3);


        /*4. Programe un skill de un personaje que pegue golpes consecutivos hasta que el contrincante
        fallezca o se superen los 10 golpes. Cada golpe proporcionado por el skill varía entre 100 y 500
        de daño. La vida del contrincante es de 2500
        a. Indique en caso de que el enemigo no haya muerto, cual es su vida resultante, y cual fue
        el daño recibido
        b. Indique en caso de que el enemigo haya muerto cuantos golpes se necesitó para
        matarlo.
        c. En todos los casos el programa deberá mostrar el daño parcial acumulado y la vida
        actual del contrincante.*/

        /*int vidaEnemigo = 2500;
        int cantGolpes = 10;
        int dañoSkill;
        int contador4 = 0;
        int dañoTot=0;

        while (contador4 < cantGolpes || vidaEnemigo == 0)
        {
            contador4 = contador4 + 1;
            dañoSkill = Random.Range(100, 500);
            dañoTot = dañoTot + dañoSkill;
            vidaEnemigo = vidaEnemigo - dañoTot;
            if (vidaEnemigo != 0 && contador4 == 10)
            {
                vidaEnemigo = vidaEnemigo - dañoSkill;
                print("La vida del enemigo es " + vidaEnemigo);
                dañoTot = dañoTot + dañoSkill;
                print("El daño acumulado fue de " + dañoTot);
            } else if(vidaEnemigo == 0)
            {
                print("La cantidad de golpes que se necesitaron para matarlo fueron " + contador4);
                dañoTot = dañoTot + dañoSkill;
                print("El daño acumulado fue de " + dañoTot);
            }
        }*/


        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
