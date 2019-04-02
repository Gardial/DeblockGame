using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationCube : MonoBehaviour
{
    int hauteur = 5; // axe Y
    int largeur = 5; // axe X


    public GameObject tuilePrefabRouge;
    public GameObject tuilePrefabBleuDroite;
    public GameObject tuilePrefabVertGauche;
 

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

                float valeurX = isoX * 0.64f/2; float valeurXdroite = isoX * 0.32f;
                float valeurY = isoY * 0.64f/4; float valeurYdroite = isoY * 0.16f;

                //Tuile Rouge
                GameObject tuileRouge = Instantiate(tuilePrefabRouge, new Vector3(valeurX, valeurY, 0), Quaternion.identity) as GameObject;
                tuileRouge.name = "TuileRouge (" + x + "," + y + ")"; // Nom des tuiles dans la vue hierarchie

            }
        }
    }
}
