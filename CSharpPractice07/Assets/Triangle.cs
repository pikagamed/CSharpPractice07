using UnityEngine;

//密封類別，禁止被繼承
[System.Serializable]
public sealed class Triangle : Shape
{
    /// <summary>
    /// 賦予長寬高
    /// </summary>
    /// <param name="l">長</param>
    /// <param name="w">寬</param>
    /// <param name="h">高</param>
    public Triangle(float l, float w, float h) : base(l,w,h)
    {

    }

    public override float Volume()
    {
        //return base.Volume();

        volume = length * width * height / 2;
        return volume;
    }

    public override void Print()
    {
        base.Print();
        Debug.Log("而且是個三角形。");
    }

    //new 隱蔽基底類別的成員
    public new void PrintTest()
    {
        Debug.Log("使用new的測試輸出方法。");
    }

    //sealed 密封 禁止被覆寫
    public sealed override void Function()
    {

    }
}
