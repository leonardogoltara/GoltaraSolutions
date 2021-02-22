namespace GoltaraSolutions.Common.Extensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Vê se é null, depois vê se é espaço em branco e da trim.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static bool IsNullOrEmptyString(this string text)
        {
            if (text == null)
                return true;

            if (string.IsNullOrWhiteSpace(text.Trim()))
                return true;

            return false;
        }
        /// <summary>
        /// Textos válido ou null. Espaços em branco são removidos.
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string Value(this string text)
        {

            if (!IsNullOrEmptyString(text))
                return text.Trim();

            return null;
        }
        public static bool LengthValid(this string text, bool AllowNull, int MinimunChar, int MaximumChar)
        {

            if (text.IsNullOrEmptyString())
            {
                /// Se estiver nulo, depende se permite nulo.
                return AllowNull;
            }
            else
            {
                /// Se não estiver nulo, efetua os tratamentos necessários e confere caracteres.
                if (text.Value().Length < MinimunChar && text.Value().Length > MaximumChar)
                    return false;
            }

            return true;
        }
    }
}
