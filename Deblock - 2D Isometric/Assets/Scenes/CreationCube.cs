using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreationCube : MonoBehaviour
{
    int hauteur = 3; // axe Y
    int largeur = 3; // axe X


    public GameObject tuilePrefabRouge;
    public GameObject tuilePrefabBleu;
 

    // Use this for initialization
    void Start()
    {
        maGrille();
    }

    void maGrille()
    {
        for (int y = 0; y < hauteur; y++)
        {
            for (int x = 0; x < largeur; x++)
            {
                float valeurX = x * 0.64f;
                float valeurY = y * 0.32f;
                float valeurX2 = valeurX + 0.32f;//la moitié de la distance sur l'axe X correspondant à une tuile (donc la moitié de 0.64 
                float valeurY2 = valeurY + 0.16f;// 
                //Tuile Rouge
                GameObject tuileRouge = Instantiate(tuilePrefabRouge, new Vector3(valeurX, valeurY, 0), Quaternion.identity) as GameObject;
                tuileRouge.name = "TuileRouge (" + x + "," + y + ")"; // Nom des tuiles dans la vue hierarchie
                //Tuile bleu
                GameObject tuileBleu = Instantiate(tuilePrefabBleu, new Vector3(valeurX2, valeurY2, 0), Quaternion.identity) as GameObject;
                tuileBleu.name = "TuileBleu (" + x + "," + y + ")"; // Nom des tuiles dans la vue hierarchie
            }
        }
    }
}
