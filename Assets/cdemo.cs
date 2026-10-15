using UnityEngine;

public class cdemo : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll){
        print("collision2d" + coll.gameObject.name);
        
        if(coll.gameObject.CompareTag("evil")){
            
            Destroy(coll.gameObject);
        }

            if(coll.gameObject.CompareTag("evil")){
            coll.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
            }

    }

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
