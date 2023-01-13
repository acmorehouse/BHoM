﻿/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2023, the respective contributors. All rights reserved.
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using BH.oM.Base;
using BH.oM.Quantities.Attributes;

namespace BH.oM.Physical.Reinforcement.BS8666
{
    [Description("A reinforcement bar with shape code 23 to BS 8666:2020 with the free end of the A segment at the Origin aligned with the Y axis," +
        " the C parameter aligned with the Y axis and the B parameter aligned with the X axis. When ZBar is toggled true, the bar will be rotated" +
        "90 degrees to form a Z bar.")]
    public class ShapeCode23 : BHoMObject, IShapeCode, IImmutable
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Length]
        public virtual double A { get;  }

        [Length]
        public virtual double B { get;  }

        [Length]
        public virtual double C { get;  }

        [Description("When toggled true, the bar will be rotated 90 degrees to form a Z bar.")]
        public virtual bool ZBar { get;  } = false;

        [Length]
        [Description("The diameter of the reinforcement bar.")]
        public virtual double Diameter { get; }

        [Length]
        [Description("Bend radius used for any discontinuities in the CentreCurve.")]
        public virtual double BendRadius { get; }

        /***************************************************/
        /**** Constructors                              ****/
        /***************************************************/

        public ShapeCode23(double a, double b, double c, bool zBar, double diameter, double bendRadius)
        {
            A = a;
            B = b;
            C = c;
            ZBar = zBar;
            Diameter = diameter;
            BendRadius = bendRadius;
        }

        /***************************************************/

    }
}

