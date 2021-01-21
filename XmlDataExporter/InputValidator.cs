using System;
using System.Collections.Generic;
using System.IO;

namespace XmlDataExporter
{
    public static class InputValidator
    {
        public static bool CheckInputForValidity(string input)
        {
            if (String.IsNullOrEmpty(input) || String.IsNullOrWhiteSpace(input) || (!Directory.Exists(input)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
