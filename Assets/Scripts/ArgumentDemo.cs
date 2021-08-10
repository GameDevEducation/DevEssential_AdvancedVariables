using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArgumentData
{
    public int Demo;
}

public class ArgumentDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // out - will handle instantiating the variable
        ArgumentData data1 = new ArgumentData();
        int numberDemo1;
        PerformAction_Out(out data1, out numberDemo1);

        // ref - requires you to pass in something that already exists
        ArgumentData data2 = new ArgumentData();
        int numberDemo2 = 5;
        PerformAction_Ref(ref data2, ref numberDemo2);

        // try parse versions always use out parameters
        int parsedNumber;
        if (int.TryParse("53", out parsedNumber))
            Debug.Log("Parsed " + parsedNumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PerformAction_Out(out ArgumentData data, out int numberDemo)
    {
        // out functions must initialise the variable
        data = new ArgumentData();
        numberDemo = 5;
    }

    void PerformAction_Ref(ref ArgumentData data, ref int numberDemo)
    {

    }
}
