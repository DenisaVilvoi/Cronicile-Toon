using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinamicLoad : MonoBehaviour
{

   public GameObject obiect;
public Vector3 pozitie; // pozitia a zonei
public Vector3 zonaIncarcare;
System.Random r = new System.Random();
// Start is called before the first frame update
void Start()
{
for(int i =0;i<5;i++){
InstantiereObiect();
}

}
public void InstantiereObiect()
{
pozitie += new Vector3(Random.Range(-zonaIncarcare.x, zonaIncarcare.x), 0,
Random.Range(-zonaIncarcare.z, zonaIncarcare.z));
Instantiate(obiect, pozitie, Quaternion.identity);
}
void OnDrawGizmosSelected()
{
Gizmos.DrawCube(pozitie, zonaIncarcare);
}
}

