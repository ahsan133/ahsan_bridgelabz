using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.Inventory_Management
{
    public class InventoryItems
    {
        private List<Rice> rice = new List<Rice>();
        private List<Wheat> wheat = new List<Wheat>();
        private List<Pulse> pulse = new List<Pulse>();


        public List<Rice> Rice { get => this.rice; set => this.rice = value; }
        public List<Wheat> Wheat { get => this.wheat; set => this.wheat = value; }
        public List<Pulse> Pulse { get => this.pulse; set => this.pulse = value; }
    }
}
