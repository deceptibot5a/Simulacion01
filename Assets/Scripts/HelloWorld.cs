using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {
    [SerializeField] MyVector myFirst;
    [SerializeField] MyVector mySecond;
    [Range(0f, 1f)] [SerializeField] float scalar;

    void Update() {
        myFirst.Draw(Color.red);
        mySecond.Draw(Color.green);
        MyVector myResult = (mySecond - myFirst) * scalar;
        MyVector myNewResult = myFirst + myResult;
        myResult.Draw(Color.yellow);
        myResult.Draw(myFirst, Color.yellow);
        myNewResult.Draw(Color.blue);
    }
}
