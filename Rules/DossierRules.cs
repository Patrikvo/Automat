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
        private static string[] procedureTypeShort = { "?", "W", "L", "D" };

        private static string[] procuringEnities =
            {
            "Onbekend", "Stad", "OCMW", "VZW Antwerpen Kunstenstad", "VZW Antwerpen Sportstad", "VZW Stadsmarketing en Toerisme",
            "Brandweerzone Antwerpen", "AG Kinderopvang", "AG Mobiliteit en Parkeren Antwerpen", "IVA Sodi+",
            "District Antwerpen", "District Berchem", "District Berendrecht Zandvliet Lillo", "District Borgerhout", "District Deurne", "District Ekeren", "District Hoboken", "District Merksem", "District Wilrijk"
            };

        private static string[] contractType = { "Onbekend", "Eenmalige opdracht", "meerjarenopdracht", "Raamcontract", "RC met meerdere ondernemers" };

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
            return GetID(procedureNames, procedureName);
        }

        public static string GetProcedureName(int id)
        {
            return GetName(procedureNames, id);
        }

        public static int GetProcuringEntityID(string entittName)
        {
            return GetID(procuringEnities, entittName);
        }

        public static string GetProcuringEntityName(int id)
        {
            return GetName(procuringEnities, id);
        }

        public static List<string> GetProcuringEntityNames()
        {
            return new List<string>(DossierRules.procuringEnities);
        }

        public static List<string> GetProcedureNames()
        {
            return new List<string>(DossierRules.procedureNames);
        }

        public static int GetProcedureTypeID(string procedureTypeName, bool abbreviated)
        {
            if (abbreviated)
            {
                return GetID(procedureTypeShort, procedureTypeName);
            }
            else
            {
                return GetID(procedureType, procedureTypeName);
            }
        }

        public static string GetProcedureTypeName(int id, bool abbreviated)
        {
            if (abbreviated)
            {
                return GetName(procedureTypeShort, id);
            }
            else
            {
                return GetName(procedureType, id);
            }
        }

        public static List<string> GetProcedureTypeNames(bool abbreviated)
        {
            if (abbreviated)
            {
                return new List<string>(DossierRules.procedureTypeShort);
            }
            else
            {
                return new List<string>(DossierRules.procedureType);
            }
        }

        // contractType
        public static List<string> GetContractTypes()
        {
            return new List<string>(DossierRules.contractType);
        }

        public static int GetContractTypeID(string contractTypeName)
        {
            return GetID(contractType, contractTypeName);
        }

        public static string GetContractTypeName(int id)
        {
            return GetName(contractType, id);
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

        private static int GetID(string[] fromList, string name)
        {
            for (int i = 0; i < fromList.Length; i++)
            {
                if (string.Equals(fromList[i], b: name))
                {
                    return i;
                }
            }

            throw new System.IndexOutOfRangeException();
        }

        private static string GetName(string[] fromList, int id)
        {
            if (id >= 0 && id < fromList.Length)
            {
                return fromList[id];
            }
            else
            {
                throw new System.IndexOutOfRangeException();
            }
        }
    }
}
