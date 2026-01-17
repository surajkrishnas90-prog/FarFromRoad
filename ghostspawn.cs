using UnityEngine;

public class ghostspawn : MonoBehaviour
{
public GameObject NPC;
public Transform spawnpoint;
bool spawned = false;
private void OnTriggerEnter(Collider other)
{

    if(other.CompareTag("Player") && !spawned)//prethatine perrr
    {
        Instantiate(NPC,spawnpoint.position,spawnpoint.rotation);
        spawned=true;
    }
}
    
}
