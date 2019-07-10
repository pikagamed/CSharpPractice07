using UnityEngine;

[System.Serializable]
public class Cube : Shape
{
    public Cube()
    {

    }

    //Override建構式
    /// <summary>
    /// 賦予長寬高
    /// </summary>
    /// <param name="getL">長</param>
    /// <param name="getW">寬</param>
    /// <param name="getH">高</param>
    public Cube(float getL, float getW, float getH):base(getL,getW,getH)
    {
        length = getL;
        width = getW;
        height = getH;
    }

    public void Test()
    {
        intPublic = 10;   
        //intPrivate = 10; //僅限於宣告類別可使用的欄位
        intProtected = 10; 
        intInternal = 10; 
    }
}
