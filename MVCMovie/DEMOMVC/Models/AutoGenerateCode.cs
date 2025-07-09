namespace DemoMvc.Models
{
    public class AutoGenerateCode
    {
        public static string GenerateNewEmployeeId(string lastEmployeeId)
        {
            const string prefix = "PS";
            const int idLength = 3;

            if (string.IsNullOrWhiteSpace(lastEmployeeId))
                return $"{prefix}{"1".PadLeft(idLength, '0')}";

            if (!lastEmployeeId.StartsWith(prefix) || lastEmployeeId.Length <= prefix.Length)
                return $"{prefix}{"1".PadLeft(idLength, '0')}";

            string numericPartStr = lastEmployeeId.Substring(prefix.Length);
            bool isValidNumber = int.TryParse(numericPartStr, out int numericPart);

            int nextNumber = isValidNumber ? numericPart + 1 : 1;

            return $"{prefix}{nextNumber.ToString().PadLeft(idLength, '0')}";
        }
    }
}
