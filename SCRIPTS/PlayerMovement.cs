using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb; // θελω να εχω προσβαση στο RigitBody σε αυτον τον κωδικα

    public float forwardForce = 2000f; // η ταχυτητα που κινειται ο παικτης μου προς τα μπροστα
    public float sidewayForce = 500f; // η ταχυτητα που κινειται ο παικτης μου προς τα δεξια ή αριστερα

   
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) // αν πατησω το κουμπι d
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);// κανω τον παικτη μου με την addforce να κινειται προς τα δεξια
        }


        if (Input.GetKey("a"))// αν πατησω το κουμπι a
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange); // κανω τον παικτη μου με την addforce να κινειται προς τα αριστερα
        }


        if(rb.position.y < -1f)// αν ο παικτης μου πεσει από την πλατφορμα, δηλαδή y<-1
        {
            FindObjectOfType<GameControler>().EndGame();//τοτε σταματαει το παιχνιδι μου
        }
    }
}
