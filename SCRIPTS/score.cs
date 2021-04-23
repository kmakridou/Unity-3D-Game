using UnityEngine.UI;
using UnityEngine;

public class score : MonoBehaviour
{


    public Transform player; // θελω να έχω πρόσβαση στις λεπτομέρεις- μορφη του παίκτη μου

    public Text scoreText; // θέλω να έχω πρόσβαση στο σκορ
   


    void Update()
    {
        scoreText.text = player.position.z.ToString("0");// μετράω το σκορ με βάση την απόσταση. θέτω το σκορ ίσο με την θέση-απόσταση που έχει ο παίκτης μου από την αρχή του παιχνιδιου
    }
}
