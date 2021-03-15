using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Airport_DTO
    {
        private int _ID;
        private int _CountryID;
        private string _IATACode;
        private string _Name;
        public int ID { get => _ID; set => _ID = value; }
        public int CountryID { get => _CountryID; set => _CountryID = value; }

        public string IATACode { get => _IATACode; set => _IATACode = value; }
        public string Name { get => _Name; set => _Name = value; }
        public Airport_DTO()
        {

        }
        public Airport_DTO(int id, int countryId, string iataCode, string name)
        {
            this.ID = id;
            this.CountryID = countryId;
            this.IATACode = iataCode;
            this.Name = name;
        }
    }
}
    