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

	private LineRenderer linerenderer; 
	//Private references
	NavMeshAgent agent;
	CharacterController controller;
	void Start()
	{
		linerenderer = GetComponent<LineRenderer>();
		agent = GetComponent<NavMeshAgent>();
		controller = GetComponent<CharacterController>(); 
    }

    // Update is called once per frame
    void Update()
    {
	    linerenderer.SetPosition(0,transform.position);
	    linerenderer.SetPosition(1,ropeAnchor.position);
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
