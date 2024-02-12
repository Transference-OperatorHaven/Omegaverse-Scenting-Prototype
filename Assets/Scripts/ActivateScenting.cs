using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateScenting : MonoBehaviour
{
    FirstPersonController controller;

    [Header("Scenting Mechanics")]
    public KeyCode scentKey;
    [SerializeField] RaycastHit[] scentsDetected;
    public LayerMask scentLayer;
    [SerializeField] private int hits;
    // Start is called before the first frame update
   
    void Start()
    {
        controller = GetComponent<FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(scentKey))
        {
            GetScentEntities();
        }


    }

    void GetScentEntities()
    {
        Debug.Log("Scent Attempted!");
        scentsDetected = Physics.SphereCastAll(controller.playerCamera.transform.position + controller.playerCamera.transform.forward * 20f, 20f, controller.playerCamera.transform.forward, 100000, scentLayer);
        /*if(hits > scentsDetected.Length)
        {
            hits = scentsDetected.Length;
            Debug.Log("hits shortened");
        }*/

        for (int i = 0; i < scentsDetected.Length; i++)
        {
            Debug.Log(scentsDetected[i].transform.gameObject.name);
            Debug.Log(scentsDetected[i].transform.gameObject.GetComponentInParent<PersonScent>().secondarySex);
            Debug.Log(scentsDetected[i].transform.gameObject.GetComponentInParent<PersonScent>().baseScent);
        }
    }

    private void OnDrawGizmos()
    {
        if (Application.isPlaying)
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(controller.playerCamera.transform.position + controller.playerCamera.transform.forward * 20f, 20f);
        }
    }

}
