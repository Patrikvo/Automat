using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automat.Rules
{
    public class DossierRules
    {
        const string fileLocationMGAC = @"\\app.p.3p.local\3p.3p$\Monitor\Dossiers\GAC\";
        const string filelocation3P = @"\\app.p.3p.local\3p.3p$\02_01_07_3P\Server\Documents\Contracts\";


        public static string getFileLocation(string dossierNummer)
        {
            string result = string.Empty;
            if (dossierNummer.Contains(@"_"))
            {
                result = composeFileLocation(dossierNummer, '_', fileLocationMGAC);

            }
            else if (dossierNummer.Contains(@"/"))
            {
                result = composeFileLocation(dossierNummer, '/', filelocation3P);
            }
            else if (dossierNummer.Contains(@"\"))
            {
                result = composeFileLocation(dossierNummer, '\\', filelocation3P);
            }
            return result;
        }


        private static string composeFileLocation(string input, char splitter, string prefix)
        {
            string result = string.Empty;

            string[] parts = input.Split(new char[] { splitter });
            if (parts.Length >= 3)
            {
                string year = parts[parts.Length - 2];
                string number = parts[parts.Length - 1];
                result = prefix + year + @"\" + number;
            }
            return result;

        }



    }
}
