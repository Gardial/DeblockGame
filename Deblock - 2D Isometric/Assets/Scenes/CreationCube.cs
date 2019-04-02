using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationCube : MonoBehaviour
{
    int hauteur = 5; // axe Y
    int largeur = 5; // axe X

    int[,] Map = new int[5, 5]
    {
        {2,2,2,2,2},
        {2,1,1,1,2},
        {2,1,1,1,2},
        {2,1,1,1,2},
        {2,2,2,2,2},
    };

    public GameObject tuilePrefabRouge;
    public GameObject tuilePrefabBleu;
    public GameObject tuilePrefabVerte;
 

    // Use this for initialization
    void Start()
    {
        maGrille();
    }

    void maGrille()
    {
        for (int x = 0; x < largeur; x++)
        {
            for (int y = 0; y < hauteur; y++)
            {
                
                int isoX = y - x;
                int isoY = y + x;

                float valeurX = isoX * 0.64f/2; 
                float valeurY = isoY * 0.64f/4; //ou (0.32f/2) car Y = 2*X

                int MapSwitch = Map[x, y];
       

                switch (MapSwitch)
                {
                    case 2:
                        //Tuile Rouge
                        GameObject tuileRouge = Instantiate(tuilePrefabRouge, new Vector3(valeurX, valeurY, 0), Quaternion.identity) as GameObject;
                        tuileRouge.name = "TuileRouge (" + x + "," + y + ")"; // Nom des tuiles dans la vue hierarchie
                        break;
                    case 1:
                        // Tuile Verte
                        GameObject tuileVerte = Instantiate(tuilePrefabVerte, new Vector3(valeurX, valeurY, 0), Quaternion.identity) as GameObject;
                        tuileVerte.name = "TuileVerte (" + x + "," + y + ")"; // Nom des tuiles dans la vue hierarchie
                        break;
                    default:
                        GameObject tuileBleu = Instantiate(tuilePrefabBleu, new Vector3(valeurX, valeurY, 0), Quaternion.identity) as GameObject;
                        tuileBleu.name = "Tuile (" + x + "," + y + ")"; // Nom des tuiles dans la vue hierarchie
                        break;

                }
                  
               

            }
        }
    }
}
