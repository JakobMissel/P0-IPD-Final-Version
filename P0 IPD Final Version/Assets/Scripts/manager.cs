using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    //G�r s� man altid kan finde ting i det her script
    public static manager instance;
    //Listen som holder styr p� hvad man har svaret ved at gemme et tal, som de nogle af de andre scripts bruger (ting som skal skrive noget eller vise billeder bruger den her til at v�lge hvilket element de skal tage fra)
    public List<int> questionAnswerList = new List<int>();
    /// <summary>
    /// Det f�rste der k�re n�r den bliver lavet, den k�re ogs� f�r "start" (Forstil jer et "Battlecry" kort fra hearthstone, da den bliver lavet/kommer ud p� banen g�r den noget med det samme) 
    /// </summary>
    private void Awake()
    {

        //Jeg har like 0 ide hvad fuck det her er.
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    
    }


}
