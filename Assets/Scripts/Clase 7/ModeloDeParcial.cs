using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeloDeParcial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region Ejercicio_1
        /*1. En un videojuego de cartas podemos encontrar una carta conjuro que tiene la siguiente
        descripci�n:
        �En el pr�ximo ataque se sumar� al da�o base un 20% de la cantidad de cartas en el cementerio,
        teniendo un 50% de da�o directo�
        Sabiendo que el da�o base es de 10, y la reducci�n por la defensa del enemigo es del 30%,
        calcule y muestre el da�o final.
        La cantidad de cartas en el cementerio es aleatoria entre 10 y 20*/

        //float da�oBase = 10f;
        //float cartas = Random.Range(10f, 21f);
        //da�oBase = da�oBase + (cartas * 0.2f);
        //float da�oTotal = (da�oBase * 0.5f) + (da�oBase * 0.5f * (1 - 0.3f));
        //print("El da�o total es: " + da�oTotal);
        #endregion
        #region Ejercicio_2

        /*2.Una torreta tiene un radio de ataque de 50 metros a 360� para unidades terrestres y 250 metros
        a 360� para unidades a�reas.
        a.Indique si el enemigo est� en rango de ataque.
        b.Resolver con conectores l�gicos*/

        //int unidadTerrestre = 50;
        //int unidadAerea = 250;
        //int distanciaEnemigo = Random.Range(0, 301);

        //if (distanciaEnemigo <= unidadTerrestre || distanciaEnemigo <= unidadAerea)
        //{
        //    print("El enemigo est� en el rango de ataque");
        //    print("Su distancia es; " + distanciaEnemigo);
        //}
        //else
        //{
        //    print("No podemos atacar al enemigo");
        //    print("Su distancia es: " + distanciaEnemigo);
        //}
        #endregion
        #region Ejercicio_3
        /*3.En un juego de puzle el usuario debe descubrir la clave num�rica para avanzar de nivel, la clave
            num�rica se compone de 4 digitos.Los dos primeros d�gitos a un n�mero alojado en la pared,
            los �ltimos dos a un numero alojado en la mesa.
            Tomando 2 variables par_inicial y par_final que generen n�meros aleatorios entre 10 y 90
            indique si la clave es correcta, sabiendo que la clave es �8457�*/

        //int par_inicial = Random.Range(80, 91);
        //int par_final = Random.Range(50, 61);

        //int clave = int.Parse(par_inicial.ToString("D2") + par_final.ToString("D2"));

        //string claveCorrecta = "8457";

        //if (clave == int.Parse(claveCorrecta))
        //{
        //    print("La clave " + clave + " es correcta!");
        //}
        //else
        //{
        //    print("La clave " + clave + " es incorrecta, intenta nuevamente");
        //}
        #endregion
        #region Ejercicio_4

        /*4. En un juego de rol un personaje realiza ataques hasta que se le consuma el Mana, cada ataque
            cuesta 10 de mana y el da�o varia entre 100 y 200, los ataques tienen una chance de critico (lo
            cual duplica el da�o) del 50%.
                a. Mostrar el da�o final total
                b. Mostrar la cantidad de ataques realizados sabiendo que el valor inicial del mana varia
                entre 100 y 200
                c. Mostrar en cada ataque individual el da�o realizado, en caso de que sea critico tambi�n
                indicarlo*/

        /*int mana = Random.Range(100, 201);
        
        int contadorMana = 0;
        float da�oTotal2 = 0;
        int cantidadDeAtaques = 0;

        while (contadorMana < mana && mana >= 10)
        {
            int critico = Random.Range(0, 11);
            float da�o = Random.Range(100, 201);        
            
                if (critico == 10)
                {
                    da�o = da�o + (da�o * 0.5f);
                    print("El da�o cr�tico realizado es: " + da�o);
                }
                else if (critico != 10)
                {
                    print("El da�o realizado es: " + da�o);
                }

            da�oTotal2 += da�o;

            contadorMana += 10;
            cantidadDeAtaques++;
        }

        print("La cantidad de ataques realizados son: " + cantidadDeAtaques);
        print("El da�o total realizado es: " + da�oTotal2);*/
        #endregion
        #region Ejercicio_5
        /*5. Programe la IA de un personaje. Sabiendo que contamos con los siguientes Datos
            Vida del enemigo, Vida del personaje,
            El enemigo presenta 4 estados:
                � Inactivo
                    o Si la distancia del enemigo es menor a 5 metros, y la vida del personaje es
                    menor a 20, cambiar el estado del personaje a Huir
                    o Si la distancia del enemigo es menor a 5 metros, y la vida del personaje es
                    mayor o igual a 20, cambiar el estado del personaje a Alerta
                    o Si la distancia no es menor a 5 metros, indicar que no hay ning�n riesgo.
                � Alerta
                    o Si la distancia del enemigo es menor a 2 metros, cambiar el estado del
                    personaje a Atacar
                    o Si la vida del personaje disminuye de 20, cambiar el estado del personaje a
                � Huir
                    o Si la distancia del enemigo es mayor a 5 metros, cambiar el estado del
                    personaje a Inactivo
                � Atacando
                    o Golpear al enemigo con un da�o aleatorio entre 100 y 200 hasta que el
                    enemigo muera, luego indicar cuantos golpes se tuvieron que asestar, y
                    cambiar al estado de Inactivo
                � Huyendo
                    o Informar si el personaje pudo huir o no, sabiendo que hay un 50% de
                    chances de hacerlo.*/

        int vidaEnemigo = 200;
        int vidaPersonaje = 200;
        string estado = "Inactivo";
        int counter = 0;

        while(vidaEnemigo > 0 && vidaPersonaje > 0)
        {
            int distanciaEnemigo = Random.Range(0, 11);
            vidaPersonaje = Random.Range(0, 31);
            switch (estado)
            {
                case "Inactivo":                    
                    if (distanciaEnemigo < 5 && vidaPersonaje < 20)
                    {
                        estado = "Huir";
                        print("El personaje debe huir");
                    }
                    else if (distanciaEnemigo < 5 && vidaPersonaje >= 20)
                    {
                        estado = "Alerta";
                        print("El personaje est� Alerta");
                    }
                    else if (distanciaEnemigo > 5)
                    {
                        print("No hay ning�n riesgo");
                    }                    
                    break;
                case "Alerta":                   
                    if (distanciaEnemigo < 2)
                    {
                        estado = "Atacar";
                        print("El personaje debe Atacar");
                    }
                    else if( vidaPersonaje < 20)
                    {
                        estado = "Huir";
                        print("El personaje debe huir");
                    }
                    break;
                case "Huir":
                    int chancesDeHuir = Random.Range(0, 2);
                    if(distanciaEnemigo > 5 && chancesDeHuir == 1)
                    {
                        estado = "Inactivo";
                        print("El personaje pudo huir");
                    } 
                    else
                    {
                        print("El personaje no pudo huir");
                    } 
                    break;
                case "Atacar":
                    while(vidaEnemigo >= 0)
                    {
                        int da�o = Random.Range(100, 201);                    
                        vidaEnemigo -= da�o;
                        counter++;
                        print("El enemigo recibi� un golpe de " + da�o);
                    }
                    print("El enemigo ha muerto");
                    break;
            }
        }
        #endregion
    }
}


