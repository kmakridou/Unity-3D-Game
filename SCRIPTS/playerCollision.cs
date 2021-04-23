
using UnityEngine;

public class playerCollision : MonoBehaviour
{


    public PlayerMovement movement;// θελω να εχω προσβαση στο playermovement script


    private void OnCollisionEnter(Collision collisionInfo)
    {

        if(collisionInfo.collider.tag == "Obstacle")// αν ο παικτης ερθει σε απαφη με ενα αντικειμενο
        {
         
            
            movement.enabled = false;// σταματαει ο παικτης να κινειται

            FindObjectOfType<GameControler>().EndGame();// τερματίζει το παιχνιδι

        }
       
    }
}
