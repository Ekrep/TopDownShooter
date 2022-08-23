using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private Rigidbody _rb;
    [SerializeField] private float _bulletSpeed;
    public Material mat;

   


    private void Start()
    {
        mat.color = Color.grey;
        _rb = GetComponent<Rigidbody>();
        StartCoroutine(BulletLifeTime());
        Vector3 charfrwd = Character.Instance.transform.forward;
        float angle = Random.Range(0, 45f)*50f;
        float z = Mathf.Cos(angle * Mathf.PI / 180);
        charfrwd.z += z;
        _rb.AddRelativeForce(charfrwd.normalized*_bulletSpeed*Time.deltaTime);
        if (BulletManager.Instance.BulletFireFunction!=null)
        {
            BulletManager.Instance.BulletFireFunction(this.gameObject);
        }
        

    }


    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
        }
    }
  
    


    
    

    public IEnumerator BulletLifeTime()
    {
        if (gameObject.GetComponent<MeshRenderer>().enabled || gameObject.GetComponent<Collider>().enabled)
        {
            
            yield return new WaitForSecondsRealtime(1f);
            Destroy(this.gameObject);
        }
        
    }
}
