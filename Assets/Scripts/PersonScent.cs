using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonScent : MonoBehaviour
{
    
    public enum SecondarySex
    {
        Alpha,
        Beta,
        Omega,
        Unpresented
    }
    [Header("Secondary Sex")]
    [SerializeField] public SecondarySex secondarySex;
    [Header("Scents")]
    [SerializeField] public string baseScent;
    [SerializeField] string moodHappy;
    [SerializeField] string moodSad;
    [SerializeField] string moodAngry;
    [SerializeField] Color scentColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
