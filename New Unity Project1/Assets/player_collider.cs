using UnityEngine;

public class player_collider : MonoBehaviour {

    public playercontroller movement;
	void OnCollisionEnter(Collision ci)
    {
        if(ci.collider.name=="Obstacle")
        {
            movement.enabled = false;
        }
    }
	
}
