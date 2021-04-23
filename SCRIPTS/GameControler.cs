using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControler : MonoBehaviour
{

    bool gameHasEnded = false;// δημιουργω μια μεταβλητη boolean τυπου για να μπορω να πω αν το παιχνιδι μου σταματαει ή οχι

    public float restartDelay = 1f; // θετω ποσα δευτερολεπτα θελω να περιμενει το παιχνιδι πριν ξεκινησει ξανα

   
  
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
        gameHasEnded = true;//αν το παιχνιδι τερματιστηκε
        Debug.Log("GAME OVER");// εμφανιζει αυτο το μηνυμα
        Invoke("Restart", restartDelay); // απο την στιγμη που θα ερθει σε επαφη ο παικτης με ενα αντικειμενο το παιχνιδι περιμενει 2 δευτερολεπτα για να κανει restart

        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene("Level1");//μας γυρναει πάλι πισω στην αρχη του παιχνιδιου
    }
}