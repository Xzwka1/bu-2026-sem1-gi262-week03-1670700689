using UnityEngine;


namespace Assignment.StudentSolution.LCT01
{
    public class Car
    {
        public string name;
        public float speed;
        public string color;

        public void Move()
        {
            Debug.Log("Car is moving");
        }

        public void Turn()
        {
            Debug.Log("Car is turning");
        }
    }

    public class LCT01SyntaxClass
    {
        public void Start()
        {
            Car  car1 = new Car();
            car1.name = "Lambogini";
            Debug.Log(car1.name);
            car1.Move();
            car1.Turn();

            Car car2 = new Car();
            car2.name = "Toyota";
            Debug.Log(car2.name); 
        }
    }
}
