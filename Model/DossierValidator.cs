namespace Automat.Model
{
    using FluentValidation;

    public class DossierValidator : AbstractValidator<Dossier>
    {
        /*
         public string DossierNummer { get; set; }

        public string DossierTitel { get; set; }

        public string DossierStandvanzaken { get; set; }

        public string DossierLinkToFiles { get; set; }

        public bool IsGearchiveerd { get; set; }

        public int DossierProcedure { get; set; }

        public int DossierType { get; set; }
         * */

        public DossierValidator()
        {
            this.RuleFor(dossier => dossier.DossierNummer).NotNull().MinimumLength(1);
        }

        public static void DisplayErrorMessage(FluentValidation.Results.ValidationResult validationResult)
        {
            string errorMessage = string.Empty;
            foreach (var failure in validationResult.Errors)
            {
                errorMessage += failure.PropertyName + " is ongeldig: " + failure.ErrorMessage + System.Environment.NewLine;
            }

            System.Windows.Forms.MessageBox.Show(errorMessage, "Dossier validatie mislukt", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }
    }
}
