namespace Automat.Rules
{
    using System.Collections.Generic;

    public class DossierRules
    {
        private const string FileLocationMGAC = @"\\app.p.3p.local\3p.3p$\Monitor\Dossiers\GAC\";
        private const string Filelocation3P = @"\\app.p.3p.local\3p.3p$\02_01_07_3P\Server\Documents\Contracts\";

        private static string[] procedureNames =
        {
            "Onbekend",
            "onderhandelingsprocedure zonder voorafgaande bekendmaking",
            "vereenvoudigde onderhandelingsprocedure met voorafgaande bekendmaking",
            "mededingingsprocedure met onderhandelingen",
            "openbare procedure",
            "niet-openbare procedure ",
            "sui generis procedure met voorafgaande bekendmaking",
            "concurrentiegerichte dialoog",
            "innovatiepartnerschap"
        };

        private static string[] procedureType = { "Onbekend", "Werken", "Leveringen", "Diensten" };

        public static string GetFileLocation(string dossierNummer)
        {
            string result = string.Empty;
            if (dossierNummer.Contains(@"_"))
            {
                result = ComposeFileLocation(dossierNummer, '_', FileLocationMGAC);
            }
            else if (dossierNummer.Contains(@"/"))
            {
                result = ComposeFileLocation(dossierNummer, '/', Filelocation3P);
            }
            else if (dossierNummer.Contains(@"\"))
            {
                result = ComposeFileLocation(dossierNummer, '\\', Filelocation3P);
            }

            return result;
        }

        public static int GetProcedureID(string procedureName)
        {
            for (int i = 0; i < procedureNames.Length; i++)
            {
                if (string.Equals(procedureNames[i], procedureName))
                {
                    return i;
                }
            }

            throw new System.IndexOutOfRangeException();
        }

        public static string GetProcedureName(int id)
        {
            if (id >= 0 && id < DossierRules.procedureNames.Length)
            {
                return DossierRules.procedureNames[id];
            }
            else
            {
                throw new System.IndexOutOfRangeException();
            }
        }

        public static List<string> GetProcedureNames()
        {
            return new List<string>(DossierRules.procedureNames);
        }

        public static int GetProcedureTypeID(string procedureTypeName)
        {
            for (int i = 0; i < procedureType.Length; i++)
            {
                if (string.Equals(procedureType[i], b: procedureTypeName))
                {
                    return i;
                }
            }

            throw new System.IndexOutOfRangeException();
        }

        public static string GetProcedureTypeName(int id)
        {
            if (id >= 0 && id < DossierRules.procedureType.Length)
            {
                return DossierRules.procedureType[id];
            }
            else
            {
                throw new System.IndexOutOfRangeException();
            }
        }

        public static List<string> GetProcedureTypeNames()
        {
            return new List<string>(DossierRules.procedureType);
        }

        private static string ComposeFileLocation(string input, char splitter, string prefix)
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
