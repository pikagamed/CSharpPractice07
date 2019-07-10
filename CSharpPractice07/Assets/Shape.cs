using UnityEngine;

[System.Serializable]
public class Shape
{
    public float length;
    public float width;
    public float height;

    public float volume;

    //繼承的四種修飾繼承類別
    public int intPublic;   //所有類別、類別外的方法皆可存取
    private int intPrivate; //當前類別可存取此資料
    protected int intProtected; //當前類別及子類別可存取
    internal int intInternal; //相同組件Assembly內可存取

    /// <summary>
    /// 賦予長寬高
    /// </summary>
    /// <param name="l">長</param>
    /// <param name="w">寬</param>
    /// <param name="h">高</param>
    public Shape(float l, float w, float h)
    {
        length = l;
        width = w;
        height = h;
    }

    public Shape()
    {

    }

    //virtual 允許子類別override方法
    /// <summary>
    /// 計算體積
    /// </summary>
    /// <returns></returns>
    public virtual float Volume()
    {
        volume = length * width * height;
        return volume;
    }

    public virtual void Print()
    {
        Debug.Log("這是一個形狀。");
    }

    public virtual void PrintTest()
    {
        Debug.Log("測試輸出方法。");
    }

    public virtual void Function()
    {

    }
}
