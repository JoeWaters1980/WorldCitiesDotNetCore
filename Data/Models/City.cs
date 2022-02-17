using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorldCities.Data.Models
{
    public class City
    {
        #region Constructor
        public City()
        {

        }
        #endregion

        #region Properties
        // <Summary>
        // The unique id and primary Key foir this City
        // </Summary>
        [Key]
        [Required]
        public int Id { get; set; }
        // <Summary>
        // City name (in UTF8 format)
        // </Summary>
        public string Name { get; set; }
        // <Summary>
        // City name (in Name_ASCII format)
        // </Summary>
        public string Name_ASCII { get; set; }
        // <Summary>
        // City latitude 
        // </Summary>
        public decimal Lat { get; set; }
        // <Summary>
        // City Longitude 
        // </Summary>
        public string Lon { get; set; }
        #endregion
        // <Summary>
        // Country Id (Foreign Key)
        // </Summary>
        [ForeignKey ("Country")]
        public int CountryId { get; set; }

        #region Navigation Properties
        // <Summary>
        // Country related to this city
        // </Summary>
        public virtual Country Country { get; set; }
        #endregion
    }
}
