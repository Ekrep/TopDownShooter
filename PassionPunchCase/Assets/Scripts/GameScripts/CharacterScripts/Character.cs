using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character : MonoBehaviour
{
    public static Character Instance;
    [SerializeField] private CharacterStatsScriptable _characterStats;
    private Rigidbody _rb;

    private void Awake()
    {
        if (Instance==null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        if (gameObject.GetComponent<Rigidbody>()!=null)
        {
            _rb = GetComponent<Rigidbody>();
            _rb.constraints = RigidbodyConstraints.FreezeRotation;
        }
        else
        {
            _rb=gameObject.AddComponent<Rigidbody>();
            _rb.constraints=RigidbodyConstraints.FreezeRotation;
        }
        
    }
    private void Update()
    {
        PullTrigger();
        Debug.Log(transform.forward.normalized);
    }

    void FixedUpdate()
    {
        MoveCharacter();
        
        
    }


    private void MoveCharacter()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        _rb.MovePosition(transform.position + move *_characterStats.movementSpeed* Time.deltaTime);

        


    }

   

    private void PullTrigger()
    {
        if (Input.GetMouseButton(0))
        {
            GameManager.Instance.TriggerPulled();
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            GameManager.Instance.TriggerBreak();
        }
    }
  
    
}
