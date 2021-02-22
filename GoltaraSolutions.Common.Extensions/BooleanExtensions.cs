namespace GoltaraSolutions.Common.Extensions
{
    public static class BooleanExtensions
    {
        public static string ToCustomString(this bool b)
        {
            if (b)
            { return "Sim"; }
            else
            { return "Não"; }

        }
    }
}
