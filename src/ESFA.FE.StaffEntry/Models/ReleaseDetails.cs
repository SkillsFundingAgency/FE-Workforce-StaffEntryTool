using System;
using System.Configuration;

namespace ESFA.FE.StaffEntry.Models
{
    public sealed class ReleaseDetails : ConfigurationSection
    {
        private const string ReleaseDateKey = "ReleaseDate";

        public ReleaseDetails Configuration => ConfigurationManager.GetSection("ReleaseDetails") as ReleaseDetails;

        [ConfigurationProperty(ReleaseDateKey, IsRequired = true)]
        public string ReleaseDate => FormattedDate(ReleaseDateKey);

        private string FormattedDate(string key)
        {
            if (DateTime.TryParse(this[key].ToString(), out var returnDate))
            {
                return returnDate.ToString("dd/MM/yyyy hh:mm:ss");
            }

            return string.Empty;
        }
    }
}
