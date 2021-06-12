using UnityEngine;
using UnityEngine.AI;
public class SimpleRope : MonoBehaviour
{
	//Params to be tweaked
	[SerializeField]
	float ropeSpeed;
    [SerializeField]
	Transform ropeAnchor;
	public bool isLeader;
	[SerializeField]
	public bool isCoward;
	[SerializeField]
	float ropeLength;
	//Private references
	NavMeshAgent agent;
	CharacterController controller;
	void Start()
    {
		agent = GetComponent<NavMeshAgent>();
		controller = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
		/* if(!isLeader){ */
			/* if(isCoward){ */
				/* transform.LookAt(ropeAnchor.position); */        
    			/* transform.localEulerAngles = new Vector3(0,transform.rotation.y,0); */
				/* controller.Move(new Vector3(0,0,ropeSpeed)); */
			/* }else{ */
				/* if(Vector3.Distance(ropeAnchor.position, transform.position) < ropeLength){ */
					/* transform.LookAt(ropeAnchor.position); */
					/* agent.SetDestination(ropeAnchor.position); */	
				/* } */
			/* } */
		/* } */
	}
}
