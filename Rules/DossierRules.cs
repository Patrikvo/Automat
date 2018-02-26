namespace Automat.Rules
{
    public class DossierRules
    {
        private const string FileLocationMGAC = @"\\app.p.3p.local\3p.3p$\Monitor\Dossiers\GAC\";
        private const string Filelocation3P = @"\\app.p.3p.local\3p.3p$\02_01_07_3P\Server\Documents\Contracts\";

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
