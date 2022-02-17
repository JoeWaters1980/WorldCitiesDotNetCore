using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WorldCities.Data.Models
{
    public class Country
    {
        #region Constructor
        public Country()
        {

        }
        #endregion
        #region Properties
        // <Summary>
        // The unique id and primary Key for this Country
        // </Summary>
        [Key]
        [Required]
        public int Id { get; set; }
        // <Summary>
        // Country Name (in UTF8 format)
        // </Summary>
        public string Name { get; set; }
        // <Summary>
        // Country code (in ISO 3166-1 ALPHA-2 format)
        // </Summary>
        public string ISO2 { get; set; }
        // <Summary>
        // Country code (in ISO 3166-1 ALPHA-3 format)
        // </Summary>
        public string ISO3 { get; set; }
        #endregion
        #region Navigation Properties
        // <Summary>
        // A list containing all the cities related to this country
        // </Summary>
        public virtual List<City> Cities { get; set; }
        #endregion
    }
}
