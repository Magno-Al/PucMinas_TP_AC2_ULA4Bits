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
        
        string[] InstructionsInHex { get; set; }

        public string[] ConvetToHex(string instructionsULA)
        {
            char[] delims = new[] { ';', ':', '\r', '\n' };

            string[] assignments;
            string[] auxInstructionsInHex;

            char X = ' ';
            char Y = ' ';
            char S = ' ';

            int W;
            int indexHexFile = 0;

            auxInstructionsInHex = instructionsULA.Split(delims, StringSplitOptions.RemoveEmptyEntries); //Corta o arquivo pelos delimitadores em um vetor.

            InstructionsInHex = new string[CountOf_W_InstructionsInVector(auxInstructionsInHex)];

            int begin = Array.IndexOf(auxInstructionsInHex, "inicio");

            for (int i = begin + 1; i < auxInstructionsInHex.Length; i++)
            {
                assignments = auxInstructionsInHex[i].Split('=');

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
                    S = W.ToString("X")[0]; // Convet int to hex.

                    InstructionsInHex[indexHexFile] = $"{X}{Y}{S}";
                    indexHexFile ++;
                }
            }

            return InstructionsInHex;
        }

        private int CountOf_W_InstructionsInVector(string[] InstructionsULA)
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
