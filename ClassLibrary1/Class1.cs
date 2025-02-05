namespace ClassLibrary1
{
    internal class InternalClass
    {
        public string GetMessage()
        {
            return "Hello from Internal Class!";
        }
    }
    public class PublicClass
    {
        public void GetPublicMessage()
        {
            Console.WriteLine("Hello from Public Class!");
        }
    }

}
