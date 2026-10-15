using UnityEngine;

public class functionDemo : MonoBehaviour
{
    public int numberUno = 13;
    public int numberDos = 7;
    public float speed = 0.5f;

    public void move(){
        transform.position = new Vector2(transform.position.x+speed, transform.position.y);


    }

public void scale(){
        transform.localScale = new Vector3(transform.localScale.x+speed, transform.localScale.y,transform.localScale.z );


    }



    public int add (int addendOne, int addendTwo) { 
            int sum = addendOne + addendTwo;
            return sum;
        }
        
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        numberUno = add(numberDos,numberUno);
        print(add(numberDos,numberUno));
        move();
        scale();
    }
}
