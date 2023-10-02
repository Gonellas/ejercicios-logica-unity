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
        descripción:
        “En el próximo ataque se sumará al daño base un 20% de la cantidad de cartas en el cementerio,
        teniendo un 50% de daño directo”
        Sabiendo que el daño base es de 10, y la reducción por la defensa del enemigo es del 30%,
        calcule y muestre el daño final.
        La cantidad de cartas en el cementerio es aleatoria entre 10 y 20*/

        //float dañoBase = 10f;
        //float cartas = Random.Range(10f, 21f);
        //dañoBase = dañoBase + (cartas * 0.2f);
        //float dañoTotal = (dañoBase * 0.5f) + (dañoBase * 0.5f * (1 - 0.3f));
        //print("El daño total es: " + dañoTotal);
        #endregion
        #region Ejercicio_2

        /*2.Una torreta tiene un radio de ataque de 50 metros a 360° para unidades terrestres y 250 metros
        a 360° para unidades aéreas.
        a.Indique si el enemigo está en rango de ataque.
        b.Resolver con conectores lógicos*/

        //int unidadTerrestre = 50;
        //int unidadAerea = 250;
        //int distanciaEnemigo = Random.Range(0, 301);

        //if (distanciaEnemigo <= unidadTerrestre || distanciaEnemigo <= unidadAerea)
        //{
        //    print("El enemigo está en el rango de ataque");
        //    print("Su distancia es; " + distanciaEnemigo);
        //}
        //else
        //{
        //    print("No podemos atacar al enemigo");
        //    print("Su distancia es: " + distanciaEnemigo);
        //}
        #endregion
        #region Ejercicio_3
        /*3.En un juego de puzle el usuario debe descubrir la clave numérica para avanzar de nivel, la clave
            numérica se compone de 4 digitos.Los dos primeros dígitos a un número alojado en la pared,
            los últimos dos a un numero alojado en la mesa.
            Tomando 2 variables par_inicial y par_final que generen números aleatorios entre 10 y 90
            indique si la clave es correcta, sabiendo que la clave es “8457”*/

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
            cuesta 10 de mana y el daño varia entre 100 y 200, los ataques tienen una chance de critico (lo
            cual duplica el daño) del 50%.
                a. Mostrar el daño final total
                b. Mostrar la cantidad de ataques realizados sabiendo que el valor inicial del mana varia
                entre 100 y 200
                c. Mostrar en cada ataque individual el daño realizado, en caso de que sea critico también
                indicarlo*/

        /*int mana = Random.Range(100, 201);
        
        int contadorMana = 0;
        float dañoTotal2 = 0;
        int cantidadDeAtaques = 0;

        while (contadorMana < mana && mana >= 10)
        {
            int critico = Random.Range(0, 11);
            float daño = Random.Range(100, 201);        
            
                if (critico == 10)
                {
                    daño = daño + (daño * 0.5f);
                    print("El daño crítico realizado es: " + daño);
                }
                else if (critico != 10)
                {
                    print("El daño realizado es: " + daño);
                }

            dañoTotal2 += daño;

            contadorMana += 10;
            cantidadDeAtaques++;
        }

        print("La cantidad de ataques realizados son: " + cantidadDeAtaques);
        print("El daño total realizado es: " + dañoTotal2);*/
        #endregion
        #region Ejercicio_5
        /*5. Programe la IA de un personaje. Sabiendo que contamos con los siguientes Datos
            Vida del enemigo, Vida del personaje,
            El enemigo presenta 4 estados:
                • Inactivo
                    o Si la distancia del enemigo es menor a 5 metros, y la vida del personaje es
                    menor a 20, cambiar el estado del personaje a Huir
                    o Si la distancia del enemigo es menor a 5 metros, y la vida del personaje es
                    mayor o igual a 20, cambiar el estado del personaje a Alerta
                    o Si la distancia no es menor a 5 metros, indicar que no hay ningún riesgo.
                • Alerta
                    o Si la distancia del enemigo es menor a 2 metros, cambiar el estado del
                    personaje a Atacar
                    o Si la vida del personaje disminuye de 20, cambiar el estado del personaje a
                • Huir
                    o Si la distancia del enemigo es mayor a 5 metros, cambiar el estado del
                    personaje a Inactivo
                • Atacando
                    o Golpear al enemigo con un daño aleatorio entre 100 y 200 hasta que el
                    enemigo muera, luego indicar cuantos golpes se tuvieron que asestar, y
                    cambiar al estado de Inactivo
                • Huyendo
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
                        print("El personaje está Alerta");
                    }
                    else if (distanciaEnemigo > 5)
                    {
                        print("No hay ningún riesgo");
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
                        int daño = Random.Range(100, 201);                    
                        vidaEnemigo -= daño;
                        counter++;
                        print("El enemigo recibió un golpe de " + daño);
                    }
                    print("El enemigo ha muerto");
                    break;
            }
        }
        #endregion
    }
}


