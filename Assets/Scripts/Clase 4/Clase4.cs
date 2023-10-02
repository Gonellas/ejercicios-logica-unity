using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clase4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region EJERCICIOS IF/ElSE

        /*En un juego de rol, el jugador tiene distintos tipos de pociones en su inventario.
         Según la que haya seleccionado, el jugador es afectado de manera diferente.
        Realice un programa que según la poción seleccionada, cumpla con el efecto correspondiente.
        - Si la poción seleccionada se llama "Curación", muestra en consola
        que el jugador se ha curado.
        - Si la poción seleccionada se llama "Mana" muestre en consola
        que el jugador está lleno de energía.
        - Si la poción seleccionada se llama "Agility" muestre en consola
        un mensaje que diga "Rapidisímo!!"*/

        string pocionCuracion = "Curación";
        string pocionMana = "Maná";
        string pocionAgility = "Agility";
        string pocionSeleccionada = "Curación";

        if (pocionSeleccionada == pocionCuracion)
        {
            print("Te has curao");
        } else if (pocionSeleccionada == pocionMana)
        {
            print("Estás sacao");
        } else if (pocionSeleccionada == pocionAgility)
        {
            print("No te alcanza ni Usain Bolt");
        }


        #endregion
        #region EJERCICIOS SWITCH

        /*En un juego de rol, el jugador tiene distintos tipos de pociones en su inventario.
        Según la que haya seleccionado, el jugador es afectado de manera diferente.
       Realice un programa que según la poción seleccionada, cumpla con el efecto correspondiente.
       - Si la poción seleccionada se llama "Curación", muestra en consola
       que el jugador se ha curado.
       - Si la poción seleccionada se llama "Mana" muestre en consola
       que el jugador está lleno de energía.
       - Si la poción seleccionada se llama "Agility" muestre en consola
       un mensaje que diga "Rapidisímo!!"*/

        string pocionSeleccionada2 = "Curación";

        switch (pocionSeleccionada2)
        {           
            case "Maná":
                print("Tas a full");
                break;
            case "Agility":
                print("Tas she rápido");
                break;
            case "Curación":
                print("Te curaste");
                break;
            default:
                print("Default");
                break;
        }


        #endregion

        #region EJERCICIOS TAREA

        /*1. Realice un programa que dada la clase de un personaje indique que armas puede usar.
            Sabiendo que:
                Mago: puede usar báculos y varitas.
                Asesino: puede usar dagas y garras
                Guerrero: puede usar espadas de una mano, mandobles y hachas.
                Helear: Solo puede usar varitas
                Paladín: Puede usar espadas de una mano y Mazos*/

        string mago = "Puede usar báculos y varitas";
        string asesino = "Puede usar dagas y garras";
        string guerrero = "Puede usar espadas de una mano, mandobles y hachas";
        string helear = "Puede usar solo varitas";
        string paladin = "Puede usar espadas de una mano y mazos";
        string claseElegida = "Mago"; 

        switch (claseElegida)
        {
            case "Mago":
                print(mago);
                break;
            case "Asesino":
                print(asesino);
                break;
            case "Guerrero":
                print(guerrero);
                break;
            case "Helear":
                print(helear);
                break;
            case "Paladín":
                print(paladin);
                break;
            default:
                print("No elegiste personaje");
                break;
        }

        /*2.Realice un programa que dado un tipo de poción le sume de manera aleatoria un valor
            entre 1 y 10 a un stats. Luego indique en cuanto quedo el nuevo stat.
            Los stats son:
            Fuerza:10
            Destreza:5
            Vida:500
            Inteligencia:50
            Mana:1500*/

        int fuerza = 1;
        int destreza = 2;
        int vida = 3;
        int inteligencia = 4;
        int mana = 5;
        int sumaPocion = Random.Range(1, 11);
        int stat = Random.Range(0, 6);

        if(stat == fuerza)
        {
            fuerza = 10 + sumaPocion;
            print("Salió la poción de Fuerza. El nuevo valor es " + fuerza);
        } else if(stat == destreza)
        {
            destreza = 5 + sumaPocion;
            print("Salió la poción de Destreza. El nuevo valor es " + destreza);
        } else if (stat == vida)
        {
            vida = 500 + sumaPocion;
            print("Salió la poción de Vida. El nuevo valor es " + vida);
        } else if (stat == inteligencia)
        {
             inteligencia = 50 + sumaPocion;
            print("Salió la poción de Inteligencia. El nuevo valor es " + inteligencia);
        } else if (stat == mana)
        {
            mana = 5 + sumaPocion;
            print("Salió la poción de Maná. El nuevo valor es " + mana);
        } else
        {
            print("No hay pociones.");
        }


        /*3.Realizar un programa que dado el string de la tecla que presionó indique una acción a
            realizar.
        - si la tecla que presiono es "arriba" o "barra espaciadora", que el personaje salte.
        - si la tecla que presiono es "abajo" que el personaje se agache.
        - si la tecla que presiono es "izquierda" que el personaje se desplace a la izquierda.
        - si la tecla que presiono es "derecha" que el personaje se desplace a la derecha.
        - si la tecla que presiono es " shift" o "enter" que el personaje dispare.
        - si no es ninguna de ellas que nos avise que no puede realizar ninguna acción.
        - Códigos de teclas: (inventarlos)
        a) Resolverlo con switch*/

        int teclaPresionada = Random.Range(0, 9);

        switch (teclaPresionada)
        {
            case 0:
                print("Presionaste Arriba. Salta");
                break;
            case 1:
                print("Presionaste Barra Espaciadora. Salta");
                break;
            case 2:
                print("Presionaste Izquierda. Muevete a la izquierda");
                break;
            case 3:
                print("Presionaste Derecha. Muevete a la derecha");
                break;
            case 4:
                print("Presionaste Shift. Dispara");
                break;
            case 5:
                print("Presionaste Enter. Dispara");
                break;
            default:
                print("Tecla equivocada");
                break;
        }


        /*4. Realice un programa que dada la vida y la acción actual de un personaje realice:
        Las acciones son:
        - Atacar
        - Huir
        - Curar

        a.Si la acción es “atacar”
            i.Si la vida es menor a 30 que cambie la acción a huir y lo indique
            ii.Si la vida es menor a 50 y mayor a 30 que cambie la acción a curar y lo indique
            iii.Si la vida es mayor a 50 que no cambie de acción e indique que se realizó
            un daño aleatorio entre los valores 2000 y 3000

        b.Si la acción es “curar”
            i.Si la vida es menor a 30 que utilice una poción grande de vida(50 hp) y
            cure personaje, luego indique que curo al personaje y la vida actual del mismo.
            ii.Sino que utilice una poción chica de vida(25p) y cure personaje, luego
            indique que curo al personaje y la vida actual del mismo.

        c.Si la acción es “huir” Que el programa genere un numero aleatorio entre 0 y 100
            i.SI el número es menor a 50 indique que el personaje huyo con éxito
            ii.En cambio si no lo es indique que el personaje no pudo huir*/

        int accion = Random.Range(0, 3);
        int atacar = 0;
        int huir = 1;
        int curar = 2;
        int vida4 = Random.Range(0, 101);

        if(accion == atacar)
        {
            if(vida4 < 30)
            {
                print("No ataques, huye.");
            } else if(vida4 <50 && vida > 30)
            {
                print("Primero curate.");
            }else if (vida4 > 50)
            {
                int ataque = Random.Range(2000, 3001);
                print("Realizaste un ataque de " + ataque + " de daño");
            }
        } else if (accion == curar)
        {
            if(vida4 < 30)
            {
                vida4 = vida4 + 50;
                print("Utilizaste una poción grande de curación. Tu vida actual es " + vida4);
            } else
            {
                vida4 = vida4 + 25;
                print("Utilizaste una poción chica de curación. Tu vida actual es " + vida4);
            }
        } else if(accion == huir)
        {
            int numAleatorio = Random.Range(0, 101);
            if (numAleatorio < 50)
            {
                print("El personaje huyó exitosamente");
            }
            else
            {
                print("El personaje no pudo huir");
            }
        }
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
