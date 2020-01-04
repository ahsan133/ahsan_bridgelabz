// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryItems.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="MD Ahsanullah"/>
// ------------------------------------------------------------------------------------------------------------------
namespace ObjectOrientedPrograms.Inventory_Management
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Items in the inventory
    /// </summary>
    public class InventoryItems
    {
        /// <summary>
        /// The rice
        /// </summary>
        private List<Rice> rice = new List<Rice>();

        /// <summary>
        /// The wheat
        /// </summary>
        private List<Wheat> wheat = new List<Wheat>();

        /// <summary>
        /// The pulse
        /// </summary>
        private List<Pulse> pulse = new List<Pulse>();

        /// <summary>
        /// Gets or sets the rice.
        /// </summary>
        /// <value>
        /// The rice.
        /// </value>
        public List<Rice> Rice { get => this.rice; set => this.rice = value; }

        /// <summary>
        /// Gets or sets the wheat.
        /// </summary>
        /// <value>
        /// The wheat.
        /// </value>
        public List<Wheat> Wheat { get => this.wheat; set => this.wheat = value; }

        /// <summary>
        /// Gets or sets the pulse.
        /// </summary>
        /// <value>
        /// The pulse.
        /// </value>
        public List<Pulse> Pulse { get => this.pulse; set => this.pulse = value; }
    }
}
