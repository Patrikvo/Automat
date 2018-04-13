namespace Automat.Model
{
    using FluentValidation;

    public class PersoonValidator : AbstractValidator<Persoon>
    {
        /*
         [Key]
        public int Id { get; set; }

        [Required]
        public string Naam { get; set; }

        public string Email { get; set; }

        public string Organisatie { get; set; }

        public string Departement { get; set; }

       // [Timestamp]
        public byte[] RowVersion { get; set; }

        public virtual ICollection<Persoon> Personen { get; set; }
        */

        public PersoonValidator()
        {
            this.RuleFor(persoon => persoon.Naam).NotNull().MinimumLength(1);
        }

        public static void DisplayErrorMessage(FluentValidation.Results.ValidationResult validationResult)
        {
            string errorMessage = string.Empty;
            foreach (var failure in validationResult.Errors)
            {
                errorMessage += failure.PropertyName + " is ongeldig: " + failure.ErrorMessage + System.Environment.NewLine;
            }

            System.Windows.Forms.MessageBox.Show(errorMessage, "Persoon validatie mislukt", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }
    }
}
