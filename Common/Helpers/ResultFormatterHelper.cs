using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Common.Helpers
{
    public class ResultFormatterHelper
    {
        private string headerFormat;
        private string headerNames;
        private int headerLength;
        private string titlePadding;

        private readonly int[] _sizes;
        private readonly string[] _fields;

        private readonly IList<string> toPrint;

        public ResultFormatterHelper(IEnumerable<int> sizes, IEnumerable<string> fields)
        {
            _sizes = sizes.ToArray();
            _fields = fields.ToArray();

            toPrint = new List<string>();
        }

        public void AddContentData(string contentData)
        {
            toPrint.Add(contentData);
        }

        public void AddContentData(object[] contentData, Alignment alignment)
        {
            FillParameters(alignment);
            toPrint.Add(String.Format(headerFormat, contentData));
        }

        public void ClearContentData()
        {
            toPrint.Clear();
        }

        public void AddDashLine()
        {
            toPrint.Add("".PadLeft(headerLength, '-'));
        }

        public string GetFormattedHeader(Alignment alignment)
        {
            FillParameters(alignment);
            return GetFormattedHeader("", alignment, false);
        }

        public string GetFormattedHeader(string titleMsg, Alignment alignment, bool printTitle = true)
        {
            FillParameters(alignment);

            StringBuilder sb = new StringBuilder();

            if (printTitle)
            {
                sb.AppendLine("".PadLeft(headerLength, '-'));
                sb.AppendLine(String.Format(titlePadding, titleMsg));
            }
            sb.AppendLine("".PadLeft(headerLength, '-'));
            sb.AppendLine(headerNames);
            sb.Append("".PadLeft(headerLength, '-'));

            return sb.ToString();
        }

        public string GetFormattedContent()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string content in toPrint)
            {
                sb.AppendLine(content);
            }
            sb.AppendLine("".PadLeft(headerLength, '-'));
            return sb.ToString();
        }

        private void FillParameters(Alignment alignment)
        {
            headerFormat = "";
            for (int index = 0; index < _sizes.Length; index++)
            {
                headerFormat += "| {" + index + "," + alignment.GetDescription() + _sizes[index] + "} ";
                if (index == _sizes.Length - 1)
                {
                    headerFormat += "|";
                }
            }

            headerNames = String.Format(headerFormat, _fields);
            headerLength = headerNames.Length;
            titlePadding = "| {0,-" + (headerLength - 4) + "} |";
        }
    }

    public enum Alignment
    {
        [Description("-")]
        Left,
        [Description("")]
        Right
    }
}
