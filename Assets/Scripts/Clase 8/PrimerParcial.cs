
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimerParcial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region Ejercicio1
        /*1) En un juego de pelea un personaje activa la habilidad “Bola de fuego” que genera un
            daño sobre el oponente.
            Para calcular el daño que va a recibir el enemigo, se toma el daño base del
            personaje y se le suma al daño un valor que varía según la vida máxima que posea
            el enemigo(8 % de la vida máxima).
            Sabiendo que la vida máxima del enemigo varía entre 100 y 200 puntos y que el
            daño base del personaje es de 25 puntos:
                a.Calcular y mostrar el daño final de su habilidad teniendo en
               cuenta que el contrincante tiene una armadura que le proporciona
               una reducción del 50 % del daño recibido.*/

        //int dañoBasePersonaje = 25;
        //int vidaMaxEnemigo = Random.Range(100, 201);
        //float dañoRealizado = dañoBasePersonaje + vidaMaxEnemigo * 0.08f;
        //float escudo = 0.5f;

        //float dañoFinal = dañoRealizado * (1 - escudo);

        //print("El daño final generado es de: " + dañoFinal + ". La vida del enemigo es de: " + vidaMaxEnemigo);
        #endregion
        #region Ejercicio2

        /*2) En un juego de pelea medieval, el brillo que tienen las armaduras varía de color e
            intensidad según el nivel que tenga el objeto.
            Sabemos que si el ítem tiene un nivel menor a 4 el brillo será de color blanco y la
            intensidad será tenue.En cambio, si el nivel es 4, 5, 6 o 7 será de color amarillo y la
            intensidad moderada. Al llegar al nivel 8 el brillo será verde y la intensidad brillante,
            en el nivel 9 será azul e intenso y al nivel 10(el máximo) será Dorada y
            encandilante.
                a.Mostrar por consola las características del objeto según su nivel.
                b.además, debe considerar que no se puedan tomar valores
                incorrectos del nivel.*/

        //int nivel = Random.Range(1, 11);

        //if (nivel < 4)
        //{
        //    print("Tu nivel es " + nivel);
        //    print("Tu armadura es blanca y de intensidad tenue");
        //}
        //else if (nivel >= 4 && nivel <= 7)
        //{
        //    print("Tu nivel es " + nivel);
        //    print("Tu armadura es amarilla y de intensidad moderada");
        //}
        //else if (nivel == 8)
        //{
        //    print("Tu nivel es " + nivel);
        //    print("Tu armadura es verde y de intensidad brillante");
        //}
        //else if (nivel == 9)
        //{
        //    print("Tu nivel es " + nivel);
        //    print("Tu armadura es azul y de intensidad intensa");
        //}
        //else if (nivel == 10)
        //{
        //    print("Tu nivel es " + nivel);
        //    print("Tu armadura es dorada y de intensidad encandilante");
        //}
        #endregion
        #region Ejercicio3

        /*3) En un juego de RPG, el jugador entrará en el mercado con la intención de comprar
            algunos elementos.
            Su objetivo es comprar los elementos necesarios para craftear 100 balas y para ello
            necesita: 3 cajas de clavos, 2 cajas de cucharas y 1 barril de pólvora.
            En el caso de que no pueda comprar todos los elementos necesarios para
            craftearlas, tendrá que intentar comprar solo el barril de pólvora para otro crafteo.
            Si tampoco puede comprarlo entonces tendrá que salir del mercado con las manos
            vacias.
            Sabiendo que el jugador tiene una cantidad de oro que varía entre 100 y 500 y que
            los precios del mercado son...
                • Barril de pólvora → 150 monedas c/ u
                • Caja de cucharas → 50 monedas c/ u
                • Caja de clavos → 20 monedas c/ u

        Indicar:
                b.Si el jugador pudo comprar el kit de elementos para craftear las
                balas.
                c.Si compro solo el barril de pólvora.
                d.Si no pudo comprar nada.
                e.En todos los casos mostrar por consola con cuanto oro ingreso al mercado y
                con cuanto salió.*/

        //int oroTotal = Random.Range(100, 501);
        //int barrilDePolvora = 150;
        //int cajaCucharas = 50;
        //int cajaClavos = 20;
        //int kitDeElementos = cajaClavos * 3 + cajaCucharas * 2 + barrilDePolvora;

        //if (oroTotal >= kitDeElementos)
        //{
        //    print("EL oro que tiene el player es de: " + oroTotal + ". Pudo comprar el kit de elementos para craftear las balas");
        //} 
        //else if(oroTotal >= 150 && oroTotal < kitDeElementos)
        //{
        //    print("EL oro que tiene el player es de: " + oroTotal + ". Pudo comprar el barril de pólvora");
        //} 
        //else 
        //{
        //    print("EL oro que tiene el player es de: " + oroTotal + ". No pudo comprar nada");
        //}
        #endregion
        #region Ejercicio4

        /*4) En un juego de cartas 1 vs 1, un jugador utiliza la carta conjuro “Muerte
            instantánea”, la cual ofrece un 30 % de chances de muerte a cada una de las
            invocaciones del rival.
            Sabiendo que el rival puede tener entre 10 y 13 criaturas invocadas indicar:
                a.Cuantas criaturas murieron y cuantas sobrevivieron.
                b.Para cada invocación que la carta conjuro aplique su efecto correctamente
                debe indicar “Murió la criatura “ +el número de criatura que murió.*/

        //int cantidadDeCriaturas = Random.Range(10, 14);
        //int contadorCriaturas = 1;
        //int criaturasVivas = 0;
        //int criaturasMuertas = 0;

        //while(contadorCriaturas <= cantidadDeCriaturas)
        //{
        //    int muerteInstantanea = Random.Range(0, 11);

        //    if(muerteInstantanea <= 3)
        //    {
        //        criaturasMuertas++;
        //        print("Murió la criatura " + contadorCriaturas);
        //    } 
        //    else
        //    {
        //        criaturasVivas++;
        //    }

        //    contadorCriaturas++;
        //}

        //print("Cantidad de criaturas invocadas: " + contadorCriaturas);
        //print("Murieron " + criaturasMuertas + " criaturas");
        //print("Sobrevivieron " + criaturasVivas + " criaturas");

        #endregion
        #region Ejercicio5

        /*5) En un juego de RPG por turnos el jugador decide lanzarle a su oponente una
            habilidad que se aplica en tres partes:
                • Parte 1: Reducción de Defensa
                Tiene una tasa de éxito del 75 % y reduce la defensa del enemigo a
                la mitad.
                • Parte 2: Multi Golpes
                Realiza 100 golpes aleatorios con un daño variante entre 50 y 110
                de daño. A cada uno de ellos se le debe restar el valor de la
                defensa, que puede o no estar reducida según el resultado de la
                Parte 1.
                En el caso de que la vida del enemigo llegue a 0 ya no debe
                impartir mas golpes.
                • Parte 3: Ejecución Certera
                Este ataque solo debe efectuarse si el enemigo sobrevivió al
                anterior.
                Si la vida actual del enemigo es menor al 30 % de su vida máxima,
                el enemigo muere instantáneamente, caso contrario su vida actual
                se reduce en un 40 %.

                Sabiendo que:
                    • La vida máxima del enemigo es de 7.500 puntos y que la vida
                    actual arranca completa.
                    • La defensa base del enemigo es de 50 puntos.

            Calcule e indique:
                   a.Si la Parte 1 tuvo éxito o no y con qué valor quedo la defensa.
                   b.Cual fue el daño total aplicado en la Parte 2 y si fue un ataque letal o
                  pudo sobrevivir.
                  c.Que sucedió con el tercer ataque. Indique si murió o si pudo sobrevivir
                  y en el segundo caso indique con cuantos puntos de vida quedo.*/

        float vidaEnemigo = 7500;
        int defensaEnemigo = 50;
        int turno;
        turno = 1;
        
        while(vidaEnemigo > 0)
        {
            switch (turno)
            {
                case 1:
                    int reduccionDefensa = Random.Range(1, 5);
                    if(reduccionDefensa <= 3)
                    {
                        defensaEnemigo = defensaEnemigo / 2;
                        print("Reducción de defensa exitosa");
                        
                    }
                    turno = 2;
                    break;
                case 2:
                    if(vidaEnemigo > 0)
                    {
                        int cantidadGolpes = 0;
                        int dañoTotal = 0;
                        while(cantidadGolpes < 100 && vidaEnemigo > 0)
                        {
                            int dañoRandom = Random.Range(50, 111);
                            dañoRandom -= defensaEnemigo;
                                                
                            if(dañoRandom < 0)
                            {
                                dañoRandom = 0;
                            }

                            dañoTotal += dañoRandom;
                            vidaEnemigo -= dañoRandom;
                            cantidadGolpes++;
                        }

                        if(vidaEnemigo > 0)
                        {
                            print("Daño total producido " + dañoTotal);
                            print("El ataque multigolpes no terminó con el enemigo");
                            turno = 3;
                        }
                        else
                        {
                            print("Daño total producido " + dañoTotal);
                            print("El ataque multigolpes fue exitoso, el enemigo murió");
                            turno = 0;
                        }                    
                    }
                    break;
                case 3:
                    if(vidaEnemigo > 0)
                    {

                        if(vidaEnemigo < 7500 * 0.3f)
                        {
                            vidaEnemigo = 0;
                            print("El enemigo sufrió una ejecución certera y murió");
                        }
                        else 
                        {
                            vidaEnemigo -= vidaEnemigo * 0.4f;
                            print("El enemigó quedo con " + vidaEnemigo + " puntos de vida");
                        }
                    }

                    turno = 0;
                    break;
            }

        }
        #endregion

    }

}
