using System;
using System.Text;
using System.IO;
using System.Linq;

namespace DataProcessor
{
    class FileRead
    {
        public string FileReading(string filePath, string dataType)
        {
            string textFileValue = File.ReadAllText(filePath);
            switch (dataType)
            {
                case "binary":
                    string val = ToBinary(ConvertToByteArray(textFileValue.Substring(0, 5), Encoding.ASCII));
                    return Convert.ToBase64String(Encoding.UTF8.GetBytes(val));
                case "text":
                    return Encoding.UTF8.GetString(Encoding.Default.GetBytes(textFileValue.Substring(0, 7)));
                case "textReverse":
                    return Encoding.UTF8.GetString(Encoding.Default.GetBytes(new string(textFileValue.Reverse().ToArray()).Substring(0, 6)));
                default:
                    break;
            }
            return textFileValue;
        }
        public static byte[] ConvertToByteArray(string str, Encoding encoding)
        {
            return encoding.GetBytes(str);
        }
        public static String ToBinary(Byte[] data)
        {
            return string.Join(" ", data.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0')));
        }
    }
}
