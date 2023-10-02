using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region DO WHILE
        /*1.En un juego de pelea un personaje(Seiya) utiliza un skill(Meteoro de Pegas�),
         *el skill funciona de esta manera:
        El contrincante recibir� 10 golpes
        Cada uno de esos golpes proporciona un da�o que varia entre 1000 y 2000 de manera aleatoria
            a.Muestre cual fue el da�o recibido por el contrincante en cada golpe
            b.Muestre el da�o total final que el enemigo recibi� 

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

        print("El da�o total fue " + da�oFinal);*/


        int golpesSkill = 10;
        int da�oGolpe;
        int contadorGolpes = 0;
        int da�oFinal = 0;

        do
        {
            contadorGolpes = contadorGolpes + 1;
            da�oGolpe = Random.Range(1000, 2001);
            print("El da�o del golpe fue " + da�oGolpe);
            da�oFinal = da�oFinal + da�oGolpe;
        } while (contadorGolpes < golpesSkill);

        print("El da�o total fue " + da�oFinal);


        /*Programe un skill de un personaje que pegue golpes consecutivos hasta que el golpe sea errado
            (da�o cero) el da�o de cada golpe varia entre 0 y 10. Indique:
            a. Cual fue el da�o otorgado al enemigo
            b. Cuantos golpes consecutivos se asestaron
            c. Cada vez que se genere un golpe mostrar cual fue el da�o generado*/

        int totalDamage = 0;
        int contadorGolpes2 = 0;
        int damage;

        do
        {
            damage = Random.Range(0, 11);
            print("El da�o en este golpe fue: " + damage);
            contadorGolpes2 = contadorGolpes2 + 1;
            totalDamage = totalDamage + damage;
        } while (damage != 0);

        print("Los golpes consecutivos fueron " + contadorGolpes2);
        print("Da�o total es " + totalDamage);
        //damage !=0 porque dice que ejecute eso mientras damage sea dif a 0, sino para.


        /*Programe un skill de un personaje que pegue golpes consecutivos hasta que el contrincante
        fallezca o se superen los 10 golpes.Cada golpe proporcionado por el skill var�a entre 100 y 500
        de da�o. La vida del contrincante es de 2500
        a.Indique en caso de que el enemigo no haya muerto, cual es su vida resultante, y cual fue
        el da�o recibido
        b.Indique en caso de que el enemigo haya muerto cuantos golpes se necesit� para
        matarlo.
        c.En todos los casos el programa deber� mostrar el da�o parcial acumulado y la vida
        actual del contrincante.*/

        /*int cantidadGolpes = 10;
        int contador = 0;
        int da�oGolpes = 0;
        int vidaEnemigo = 2500;
        int da�oTotal = 0;

        do
        {
            contador = contador + 1;
            da�oGolpes = Random.Range(100, 501);                 
            da�oTotal = da�oTotal + da�oGolpes;
            vidaEnemigo = vidaEnemigo - da�oTotal;
            if(vidaEnemigo != 0)
            {
                print("La vida del enemigo es " + vidaEnemigo);
                print("El da�o causado es " + da�oTotal);
            } else if(vidaEnemigo == 0)
            {
                print("Se necesitaron " + contador + " para que el enemigo muera");
                print("La vida del enemigo es " + vidaEnemigo);
                print("El da�o causado es " + da�oTotal);
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
            print("Da�o parcial acumulado: " + partialDamage);

            if (vidaContrincante > 0)
            {
                print("Vida resultante " + vidaContrincante);
                print("Da�o recibido: " + damage);
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
