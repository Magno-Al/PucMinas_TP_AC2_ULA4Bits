using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace ULA_4Bits
{
    class HexConverter
    {
        string[] Mnemonico = { "nA", "AoBn", "nAeB", "Lzero", "AeBn", "nB", "AxB", "AenB", "nAoB", "AxBn",
            "Bcopia", "AeB", "Lum", "AonB", "AoB", "Acopia" };
        string[] InstructionsULA { get; set; }

        public string[] ConvetToHex(string instructionsULA)
        {
            char[] delims = new[] { ';', ':', '\r', '\n' };

            string[] assignments;
            string[] hexFile;

            char X = ' ';
            char Y = ' ';
            char S = ' ';

            int W;
            int indexHexFile = 0;

            InstructionsULA = instructionsULA.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            
            hexFile = new string[SizeOfHexFile(InstructionsULA)];

            int begin = Array.IndexOf(InstructionsULA, "inicio");

            for (int i = begin + 1; i < InstructionsULA.Length; i++)
            {
                assignments = InstructionsULA[i].Split('=');

                if (assignments.Length == 2 && assignments[0] == "X")
                {
                    X = char.Parse(assignments[1]);
                }
                else if (assignments.Length == 2 && assignments[0] == "Y")
                {
                    Y = char.Parse(assignments[1]);
                }
                else if (assignments[0] == "W")
                {
                    W = Array.IndexOf(Mnemonico, assignments[1]);
                    S = W.ToString("X")[0]; // Convet int to hex

                    hexFile[indexHexFile] = $"{X}{Y}{S}";
                    indexHexFile ++;
                }
            }

            return hexFile;
        }

        private int SizeOfHexFile(string[] InstructionsULA)
        {
            int count = 0;

            foreach(string InstructionULA in InstructionsULA)
            {
                if (InstructionULA.Contains("W"))
                    count++;
            }

            return count;
        }
    }
}
