using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    /*public Camera cam;

    public NavMeshAgent agent;

    Interactable interactable;
    */


    //void FaceTarget();
    /*{
        Vector3 direction = (hit.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0f, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }*/

  /*  // Update is called once per frame
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();
                agent.SetDestination(hit.point);
            }
        }
    }

*/}
