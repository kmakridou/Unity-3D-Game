using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // θελω να εχω προσβαση στις λεπτομερειες του παικτη μου
    public Vector3 offset;

    
    void Update()
    {
        transform.position = player.position + offset; // η θεση που θα είναι η κάμερα είναι η θεση του παικτη μου + το offset

    }
}
