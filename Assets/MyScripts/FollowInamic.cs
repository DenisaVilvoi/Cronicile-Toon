using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowInamic : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    public GameObject area;
    public Inamic inamic;

    void Start()
   {
     inamic=new Inamic("Enemy",100);
   }
    void Update()
    {
        if (area.GetComponent<AreaColider>().isFollowing)
        {          
            agent.SetDestination(player.position);
        }
       
       
    }
       private void OnMouseDown()
   {
       inamic.DamageEnemy(10);
       Debug.Log(inamic.gethp());
       if(inamic.gethp()==0)
       {
          Destroy(gameObject);
       }
   }


}
