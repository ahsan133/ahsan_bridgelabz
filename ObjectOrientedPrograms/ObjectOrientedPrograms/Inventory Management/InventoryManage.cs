using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms
{
    public class InventoryManage
    {
        private string name;
        private int weight;
        private int price;

        public string Name { get => this.name; set => this.name = value; }
        public int Weight { get => this.weight; set => this.weight = value; }
        public int Price { get => this.price; set => this.price = value; }
    }
}
