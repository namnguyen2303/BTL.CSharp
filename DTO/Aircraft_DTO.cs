using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class Aircraft_DTO
    {
        private int _ID;
        private string _Name;
        private string _MakeModel;
        private int _TotalSeats;
        private int _EconomySeats;
        private int _BusinessSeats;
        public int ID { get => _ID; set => _ID = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string MakeModel { get => _MakeModel; set => _MakeModel = value; }
        public int TotalSeats { get => _TotalSeats; set => _TotalSeats = value; }
        public int EconomySeats { get => _EconomySeats; set => _EconomySeats = value; }
        public int BusinessSeats { get => _BusinessSeats; set => _BusinessSeats = value; }

        public Aircraft_DTO()
        {

        }
        public Aircraft_DTO(int id, string name, string makeModel, int totalSeats, int economySeats, int businessSeats)
        {
            this.ID = id;
            this.Name = name;
            this.MakeModel = makeModel;
            this.TotalSeats = totalSeats;
            this.EconomySeats = economySeats;
            this.BusinessSeats = businessSeats;
        }

    }
}
