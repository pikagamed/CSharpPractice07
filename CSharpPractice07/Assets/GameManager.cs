using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Cube c1 = new Cube(10,10,10);
    //public Cube c2 = new Shape(); //子參考不得使用父物件建構式
    public Shape x = new Cube();      //父參考可使用子物件建構式

    public Triangle t1 = new Triangle(10, 10, 10);

    public Shape Test1 = new Shape(3, 3, 3);
    public Triangle Test2 = new Triangle(4, 4, 4);
    public Shape Test3 = new Triangle(5, 5, 5);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("立方體體積：" + c1.Volume());

        c1.intPublic = 10;
        //c1.intPrivate = 10; //僅限於宣告類別可使用的欄位
        //c1.intProtected = 10;   //宣告類別及其後續衍生類別可使用的欄位
        c1.intInternal = 10;

        Debug.Log("三角形的體積：" +t1.Volume());
        c1.Print();
        t1.Print();

        Test1.PrintTest();
        Test2.PrintTest();
        Test3.PrintTest();  //宣告為繼承類別的物件，但仍然輸出基底類別的方法
    }

    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
