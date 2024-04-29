using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Interactor : MonoBehaviour
{

    [SerializeField] private Vector3 detectionBoxSize = new Vector3(1, 2, 1);
    [SerializeField] private LayerMask InteractableLayer;
    [SerializeField] private Vector3 overlapboxOFFset;
    private Collider[] _interactableColliders;
    private Collider[] _cachedinteractableColliders;

    private List<GameObject> _objectsToInteract; 
    private void OnDrawGizmos()
    {
        DebugSphere();
    }
    void DebugSphere()
    {

        Gizmos.color = Color.red;
        //Gizmos.DrawWireSphere(transform.position, detectionRadius);
        Gizmos.DrawWireCube(transform.position + overlapboxOFFset, detectionBoxSize);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

        CheckForPlayer();
    }

    void CheckForPlayer()
    {

        //Collider[] colliders = Physics.OverlapSphere(transform.position, detectionRadius, playerLayer);
       _interactableColliders = Physics.OverlapBox(transform.position + overlapboxOFFset, detectionBoxSize * 0.5f, Quaternion.identity, InteractableLayer);
        if(_cachedinteractableColliders!=null)
        foreach(var cachedInteractable in _cachedinteractableColliders)
        {
            if (_interactableColliders.Contains(cachedInteractable) == false)
            {
                GameObject InteractableGO = cachedInteractable.gameObject;
                    if (InteractableGO.GetComponent<IPO_mono>())
                    {
                        IPO_mono _iPO_Mono = InteractableGO.GetComponent<IPO_mono>();
                        _iPO_Mono.IPO_PackageManager.DeactivateBehaviours();
                    }
                    if (InteractableGO.GetComponent<IQR_mono>())
                    {
                        IQR_mono _iQr_Mono = InteractableGO.GetComponent<IQR_mono>();
                        _iQr_Mono.IPO_PackageManager.DeactivateBehaviours();

                    }
                //IPO_PackageManager InteractablePackageManager = _iPO_Mono.IPO_PackageManager;
                
            }
        }


        foreach (Collider collider in _interactableColliders)
        {
            GameObject InteractableGO = collider.gameObject;
            if (InteractableGO.GetComponent<IPO_mono>())
            {
                IPO_mono _iPO_Mono = InteractableGO.GetComponent<IPO_mono>();
                _iPO_Mono.IPO_PackageManager.ActivateBehaviours();
            }
            if (InteractableGO.GetComponent<IQR_mono>())
            {
                IQR_mono _iQr_Mono = InteractableGO.GetComponent<IQR_mono>();
                _iQr_Mono.IPO_PackageManager.ActivateBehaviours();

            }


        }
        _cachedinteractableColliders = _interactableColliders;
    }

    public void OnInteract()
    {
        foreach (Collider collider in _interactableColliders)
        {
            GameObject InteractableGO = collider.gameObject;
            if (InteractableGO.GetComponent<IPO_mono>())
            {
                IPO_mono _iPO_Mono = InteractableGO.GetComponent<IPO_mono>();
                _iPO_Mono.IPO_PackageManager.InteractBehaviours();
            }
            if (InteractableGO.GetComponent<IQR_mono>())
            {
                IQR_mono _iQr_Mono = InteractableGO.GetComponent<IQR_mono>();
                _iQr_Mono.IPO_PackageManager.InteractBehaviours();

            }


        }
        //Debug.Log("Interact");
    }
}
