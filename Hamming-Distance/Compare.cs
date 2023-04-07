using System.Text.RegularExpressions;

namespace Hamming_Distance;

/*Usage :
 
 using Hamming_Distance;
 
 Compare.HammingDistance("11011001", "10011101"); => 2
 
 Compare.HammingDistance(new byte[] { 0x00, 0x00 }, new byte[] { 0x00, 0x0F }); => 4
*/

public class Compare
{
    private static readonly Dictionary<char, string> Lookup = new()
    {
        { '0', "0000" },
        { '1', "0001" },
        { '2', "0010" },
        { '3', "0011" },
        { '4', "0100" },
        { '5', "0101" },
        { '6', "0110" },
        { '7', "0111" },
        { '8', "1000" },
        { '9', "1001" },
        { 'a', "1010" },
        { 'b', "1011" },
        { 'c', "1100" },
        { 'd', "1101" },
        { 'e', "1110" },
        { 'f', "1111" },
        { 'A', "1010" },
        { 'B', "1011" },
        { 'C', "1100" },
        { 'D', "1101" },
        { 'E', "1110" },
        { 'F', "1111" }
    };

    public static int HammingDistance(byte[] parameterA, byte[] parameterB)
    {
        return HammingDistance(HexToBinary(parameterA), HexToBinary(parameterB));
    }

    public static int HammingDistance(string parameterA, string parameterB)
    {
        if (parameterA != null && parameterB != null && parameterA.Length != parameterB.Length)
            throw new ArgumentException("Argument must have equal lengths.");

        return parameterA.Zip(parameterB, (x, y) => x != y ? 1 : 0).Sum();
    }

    private static string HexToBinary(byte[] byteParameter)
    {
        var stringParameter = BitConverter.ToString(byteParameter)?.Replace("-", "");

        stringParameter = Regex.Replace(stringParameter, "^0x", "");

        if (!Regex.IsMatch(stringParameter, "^[0-9a-fA-F]+$"))
            throw new ArgumentException("Argument is not a valid hexadecimal string.");

        return new string(stringParameter.SelectMany(c => Lookup[c]).ToArray());
    }
}