// See https://aka.ms/new-console-template for more information

class color
{

    //color의 생성자에서 red,greend,blue 변수에 값을 선언함.
    //int 형식의 red,green,blue 변수를 선언함.
    //GetRGB 메서드는 int형의 파라미터를 받아들이고 인자를 전달함.
    public color()
    {
        this.red = 0;
        this.green = 127;
        this.blue = 255;
    }

    protected int red;
    protected int green;
    protected int blue;

    public void GetRGB(out int red,out int green,out int blue)
    {
        red = this.red;
        green = this.green;
        blue = this.blue;
    }
}

class class1
{
    static void Main(string[] args)
    {
        //Color 라는 객체 생성
        color c = new color();
        int red;
        int green;
        int blue;
        c.GetRGB(out red,out green,out blue);
        //c.GetRGB(ref red, ref green, ref blue);

        Console.WriteLine("R={0}, G={1}, B={2}", red, green, blue);
    
    }

}


