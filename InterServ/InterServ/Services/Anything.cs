namespace InterServ.Services
{
    public class Anything : IAnything
    {
        public string DisplayMsg(string something)
        {
            return $"This is {something}.";
        }
    }
}
