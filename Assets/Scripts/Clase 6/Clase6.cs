using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region DO WHILE
        /*1.En un juego de pelea un personaje(Seiya) utiliza un skill(Meteoro de Pegasó),
         *el skill funciona de esta manera:
        El contrincante recibirá 10 golpes
        Cada uno de esos golpes proporciona un daño que varia entre 1000 y 2000 de manera aleatoria
            a.Muestre cual fue el daño recibido por el contrincante en cada golpe
            b.Muestre el daño total final que el enemigo recibió 

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

        print("El daño total fue " + dañoFinal);*/


        int golpesSkill = 10;
        int dañoGolpe;
        int contadorGolpes = 0;
        int dañoFinal = 0;

        do
        {
            contadorGolpes = contadorGolpes + 1;
            dañoGolpe = Random.Range(1000, 2001);
            print("El daño del golpe fue " + dañoGolpe);
            dañoFinal = dañoFinal + dañoGolpe;
        } while (contadorGolpes < golpesSkill);

        print("El daño total fue " + dañoFinal);


        /*Programe un skill de un personaje que pegue golpes consecutivos hasta que el golpe sea errado
            (daño cero) el daño de cada golpe varia entre 0 y 10. Indique:
            a. Cual fue el daño otorgado al enemigo
            b. Cuantos golpes consecutivos se asestaron
            c. Cada vez que se genere un golpe mostrar cual fue el daño generado*/

        int totalDamage = 0;
        int contadorGolpes2 = 0;
        int damage;

        do
        {
            damage = Random.Range(0, 11);
            print("El daño en este golpe fue: " + damage);
            contadorGolpes2 = contadorGolpes2 + 1;
            totalDamage = totalDamage + damage;
        } while (damage != 0);

        print("Los golpes consecutivos fueron " + contadorGolpes2);
        print("Daño total es " + totalDamage);
        //damage !=0 porque dice que ejecute eso mientras damage sea dif a 0, sino para.


        /*Programe un skill de un personaje que pegue golpes consecutivos hasta que el contrincante
        fallezca o se superen los 10 golpes.Cada golpe proporcionado por el skill varía entre 100 y 500
        de daño. La vida del contrincante es de 2500
        a.Indique en caso de que el enemigo no haya muerto, cual es su vida resultante, y cual fue
        el daño recibido
        b.Indique en caso de que el enemigo haya muerto cuantos golpes se necesitó para
        matarlo.
        c.En todos los casos el programa deberá mostrar el daño parcial acumulado y la vida
        actual del contrincante.*/

        /*int cantidadGolpes = 10;
        int contador = 0;
        int dañoGolpes = 0;
        int vidaEnemigo = 2500;
        int dañoTotal = 0;

        do
        {
            contador = contador + 1;
            dañoGolpes = Random.Range(100, 501);                 
            dañoTotal = dañoTotal + dañoGolpes;
            vidaEnemigo = vidaEnemigo - dañoTotal;
            if(vidaEnemigo != 0)
            {
                print("La vida del enemigo es " + vidaEnemigo);
                print("El daño causado es " + dañoTotal);
            } else if(vidaEnemigo == 0)
            {
                print("Se necesitaron " + contador + " para que el enemigo muera");
                print("La vida del enemigo es " + vidaEnemigo);
                print("El daño causado es " + dañoTotal);
            }

        } while (vidaEnemigo != 0 || contador < cantidadGolpes);*/

        int vidaContrincante = 2500;
        int contadorGolpes3 = 0;
        int maxGolpes = 10;
        int damage2;
        int partialDamage = 0;

        do
        {
            damage2 = Random.Range(100, 501);
            vidaContrincante = vidaContrincante - damage2;
            partialDamage = partialDamage + damage2;
            contadorGolpes3 = contadorGolpes3 + 1;
            print("Vida resultante " + vidaContrincante);
            print("Daño parcial acumulado: " + partialDamage);

            if (vidaContrincante > 0)
            {
                print("Vida resultante " + vidaContrincante);
                print("Daño recibido: " + damage);
            } else
            {
                print("Golpes necesarios: " + contadorGolpes3);
            }
        } while (contadorGolpes3 < maxGolpes && vidaContrincante > 0) ;

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
