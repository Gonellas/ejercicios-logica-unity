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
         Seg�n la que haya seleccionado, el jugador es afectado de manera diferente.
        Realice un programa que seg�n la poci�n seleccionada, cumpla con el efecto correspondiente.
        - Si la poci�n seleccionada se llama "Curaci�n", muestra en consola
        que el jugador se ha curado.
        - Si la poci�n seleccionada se llama "Mana" muestre en consola
        que el jugador est� lleno de energ�a.
        - Si la poci�n seleccionada se llama "Agility" muestre en consola
        un mensaje que diga "Rapidis�mo!!"*/

        string pocionCuracion = "Curaci�n";
        string pocionMana = "Man�";
        string pocionAgility = "Agility";
        string pocionSeleccionada = "Curaci�n";

        if (pocionSeleccionada == pocionCuracion)
        {
            print("Te has curao");
        } else if (pocionSeleccionada == pocionMana)
        {
            print("Est�s sacao");
        } else if (pocionSeleccionada == pocionAgility)
        {
            print("No te alcanza ni Usain Bolt");
        }


        #endregion
        #region EJERCICIOS SWITCH

        /*En un juego de rol, el jugador tiene distintos tipos de pociones en su inventario.
        Seg�n la que haya seleccionado, el jugador es afectado de manera diferente.
       Realice un programa que seg�n la poci�n seleccionada, cumpla con el efecto correspondiente.
       - Si la poci�n seleccionada se llama "Curaci�n", muestra en consola
       que el jugador se ha curado.
       - Si la poci�n seleccionada se llama "Mana" muestre en consola
       que el jugador est� lleno de energ�a.
       - Si la poci�n seleccionada se llama "Agility" muestre en consola
       un mensaje que diga "Rapidis�mo!!"*/

        string pocionSeleccionada2 = "Curaci�n";

        switch (pocionSeleccionada2)
        {           
            case "Man�":
                print("Tas a full");
                break;
            case "Agility":
                print("Tas she r�pido");
                break;
            case "Curaci�n":
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
                Mago: puede usar b�culos y varitas.
                Asesino: puede usar dagas y garras
                Guerrero: puede usar espadas de una mano, mandobles y hachas.
                Helear: Solo puede usar varitas
                Palad�n: Puede usar espadas de una mano y Mazos*/

        string mago = "Puede usar b�culos y varitas";
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
            case "Palad�n":
                print(paladin);
                break;
            default:
                print("No elegiste personaje");
                break;
        }

        /*2.Realice un programa que dado un tipo de poci�n le sume de manera aleatoria un valor
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
            print("Sali� la poci�n de Fuerza. El nuevo valor es " + fuerza);
        } else if(stat == destreza)
        {
            destreza = 5 + sumaPocion;
            print("Sali� la poci�n de Destreza. El nuevo valor es " + destreza);
        } else if (stat == vida)
        {
            vida = 500 + sumaPocion;
            print("Sali� la poci�n de Vida. El nuevo valor es " + vida);
        } else if (stat == inteligencia)
        {
             inteligencia = 50 + sumaPocion;
            print("Sali� la poci�n de Inteligencia. El nuevo valor es " + inteligencia);
        } else if (stat == mana)
        {
            mana = 5 + sumaPocion;
            print("Sali� la poci�n de Man�. El nuevo valor es " + mana);
        } else
        {
            print("No hay pociones.");
        }


        /*3.Realizar un programa que dado el string de la tecla que presion� indique una acci�n a
            realizar.
        - si la tecla que presiono es "arriba" o "barra espaciadora", que el personaje salte.
        - si la tecla que presiono es "abajo" que el personaje se agache.
        - si la tecla que presiono es "izquierda" que el personaje se desplace a la izquierda.
        - si la tecla que presiono es "derecha" que el personaje se desplace a la derecha.
        - si la tecla que presiono es " shift" o "enter" que el personaje dispare.
        - si no es ninguna de ellas que nos avise que no puede realizar ninguna acci�n.
        - C�digos de teclas: (inventarlos)
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


        /*4. Realice un programa que dada la vida y la acci�n actual de un personaje realice:
        Las acciones son:
        - Atacar
        - Huir
        - Curar

        a.Si la acci�n es �atacar�
            i.Si la vida es menor a 30 que cambie la acci�n a huir y lo indique
            ii.Si la vida es menor a 50 y mayor a 30 que cambie la acci�n a curar y lo indique
            iii.Si la vida es mayor a 50 que no cambie de acci�n e indique que se realiz�
            un da�o aleatorio entre los valores 2000 y 3000

        b.Si la acci�n es �curar�
            i.Si la vida es menor a 30 que utilice una poci�n grande de vida(50 hp) y
            cure personaje, luego indique que curo al personaje y la vida actual del mismo.
            ii.Sino que utilice una poci�n chica de vida(25p) y cure personaje, luego
            indique que curo al personaje y la vida actual del mismo.

        c.Si la acci�n es �huir� Que el programa genere un numero aleatorio entre 0 y 100
            i.SI el n�mero es menor a 50 indique que el personaje huyo con �xito
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
                print("Realizaste un ataque de " + ataque + " de da�o");
            }
        } else if (accion == curar)
        {
            if(vida4 < 30)
            {
                vida4 = vida4 + 50;
                print("Utilizaste una poci�n grande de curaci�n. Tu vida actual es " + vida4);
            } else
            {
                vida4 = vida4 + 25;
                print("Utilizaste una poci�n chica de curaci�n. Tu vida actual es " + vida4);
            }
        } else if(accion == huir)
        {
            int numAleatorio = Random.Range(0, 101);
            if (numAleatorio < 50)
            {
                print("El personaje huy� exitosamente");
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
