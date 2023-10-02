using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tarea : MonoBehaviour
{

    void Start()
    {
        #region Ejercicio 1
        /*1. Realice un programa que golpee a un enemigo 10 veces.
             Sabemos que la chance de critico es del 30 % y el daño base varia entre 100 y 200
                a.Indicar cual fue el golpe más fuerte
                b.Indicar cuantos golpes críticos dio
                c.Indicar el promedio de daño
                d.Indicar el daño final.
                e.Cada vez que se da un golpe imprimir el daño realizado.
        */

        int counter = 0;
        int criticalHits = 0;
        float maxDamageDealt = 0;
        int numberOfHits = 10;
        int totalDamage = 0;

        do
        {
            int damage = Random.Range(100, 201);
            float criticalDamage = Random.Range(0, 11);

            if (criticalDamage == 3)
                criticalHits = criticalHits + 1;

            if (damage > maxDamageDealt)
                maxDamageDealt = damage;

            totalDamage += damage;

            print("Golpe" + (counter + 1) + " - Daño recibido :" + damage);

            counter++;

        }
        while (counter < numberOfHits);

        int promedioDaño = totalDamage / counter;

        print("Golpes críticos: " + criticalHits);
        print("Mayor daño recibido: " + maxDamageDealt);
        print("Daño total: " + totalDamage);
        print("Promedio de daño en golpes: " + promedioDaño);

        #endregion

        #region Ejercicio 2

        /*2. Realice un programa donde un personaje abra 10 cofres, los cofres pueden contener:
             10 de oro, 2 pociones de vida, nada
                a. Indique el oro final recolectado
                b. Indique cuantas pociones de Vida Obtuvo
                c. Indique cuantos cofres vacíos hubo
                d. Cada vez que abre un cofre indique que saco.*/

        int cofres = 10;
        int contador = 0;
        int oro = 1;
        int oroObtenido = 0;
        int potis = 2;
        int potisObtenidas = 0;
        int cofreVacio = 3;
        int cofreVacioObtenido = 0;

        while (contador < cofres)
        {
            int cofreAbierto = Random.Range(1, 3 + 1);

            switch (cofreAbierto)
            {
                case 1:
                    print("Obtuviste 10 de oro");
                    break;
                case 2:
                    print("Obtuviste 2 pociones de vida");
                    break;
                case 3:
                    print("Obtuviste un cofre vacío");
                    break;
            }

            if (cofreAbierto == oro)
            {
                oroObtenido = oroObtenido + 10;
            }
            else if (cofreAbierto == potis)
            {
                potisObtenidas = potisObtenidas + 2;
            }
            else if (cofreAbierto == cofreVacio)
            {
                cofreVacioObtenido = cofreVacioObtenido + 1;
            }

            contador++;
        }

        print("Obtuviste un total de " + oroObtenido + " monedas de oro");
        print("Obtuviste un total de " + potisObtenidas + " pociones de vida");
        print("Obtuviste un total de " + cofreVacioObtenido + " cofres vacíos");

        #endregion

        #region Ejercicio 3

        /*3.Programe el comportamiento de un personaje, tomando como referencia las diferentes
            acciones que este puede realizar. Las acciones a realizar son: “Atacar”, “Curar”, “huir”
                a.Si la acción es atacar el personaje debe golpear 10 veces un daño entre(20 y 50)
                    a.Indique el daño Final
                    b.Indique el Promedio de Golpes
                    c.Imprimir en cada golpe el daño hecho y el daño acumulado

                b.Si la acción es curar el personaje debe curarse la vida con valores aleatorios(entre 10 y
                20) hasta que esta llegue a su vida máxima(validar que no supere ese valor).
                    Vida Inicial: 20
                    Vida Máxima: 150
                        a.Indicar la cantidad de veces que se curo
                        b.Indicar el promedio de vida que se curó por poción
                        c.Imprimir en cada curación cuanto se curo y la curación acumulada

                c.Si la acción es Huir indicar si el personaje puede hacerlo, sabiendo que para hacerlo
                tiene un 50 % de chances de huir
                    a.Indicar si pudo Huir.*/

        int atacar = 1;
        int curar = 2;
        int huir = 3;
        int accionARealizar = Random.Range(1, 3 + 1);

        if(accionARealizar == atacar)
        {
            int golpes = 10;
            int contadorGolpes = 0;
            int dañoTotal = 0;

            do
            {
                int daño = Random.Range(20, 51);

                print("Daño realizodo: " + daño);

                dañoTotal = daño + dañoTotal;

                print("Daño acumulado: " + dañoTotal);

                contadorGolpes++;
            }
            while (contadorGolpes < golpes);


            int promedioDaño2 = dañoTotal / golpes;

            print("Daño total: " + dañoTotal);
            print("Promedio de daño: " + promedioDaño2);
        } 
        else if(accionARealizar == curar)
        {
            int vidaInicial = 20;
            int vidaMax = 150;
            int contadorCuracion = 0;
            int curacionAcumulada = 0;

            do
            {
                int curacion = Random.Range(10, 21);                

                print("Se curó: " + curacion);

                curacionAcumulada = curacionAcumulada + curacion;
                vidaInicial = vidaInicial + curacion;

                print("La vida ahora es de: " + vidaInicial);
                print("La curación acumulada es: " + curacionAcumulada);

                contadorCuracion++;
            }
            while (vidaInicial <= vidaMax);

            print("Se curó " + contadorCuracion + " veces.");
        }
        else if(accionARealizar == huir)
        {
            int porcentajeParaHuir = Random.Range(0, 11);

            if(porcentajeParaHuir <= 5)
            {
                print("No pudiste huir");
            } else if(porcentajeParaHuir >= 6)
            {
            print("El jugador pudo huir");

            }
        }

        #endregion
    }

}
