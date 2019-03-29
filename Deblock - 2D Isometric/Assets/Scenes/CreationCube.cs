using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationCube : MonoBehaviour
{
    int hauteur = 10;
    int largeur = 10;

    public GameObject tuilePrefab;

    // Use this for initialization
    void Start()
    {
        maGrille();
    }

    void maGrille()
    {
        for (int i = 0; i < hauteur; i++)
        {
            for (int j = 0; j < largeur; j++)
            {

                GameObject tuile = Instantiate(tuilePrefab, new Vector3(i, j, 0), Quaternion.identity) as GameObject;

                // Nom de la tuile dans le tableau
                tuile.name = "Tuile (" + i + "," + j + ")";

            }
        }
    }
}
