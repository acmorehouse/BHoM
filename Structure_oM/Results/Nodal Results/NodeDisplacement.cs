/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2020, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using System.ComponentModel;
using BH.oM.Quantities.Attributes;

namespace BH.oM.Structure.Results
{
    [Description("Resulting displacements and rotations for a single node.")]
    public class NodeDisplacement : NodeResult
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Length]
        public double UX { get; set; } = 0.0;

        [Length]
        public double UY { get; set; } = 0.0;

        [Length]
        public double UZ { get; set; } = 0.0;

        [Angle]
        public double RX { get; set; } = 0.0;

        [Angle]
        public double RY { get; set; } = 0.0;

        [Angle]
        public double RZ { get; set; } = 0.0;

        /***************************************************/
    }
}

