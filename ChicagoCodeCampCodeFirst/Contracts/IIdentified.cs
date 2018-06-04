using System;
using System.Collections.Generic;
using System.Text;

namespace ChicagoCodeCampCodeFirst
{
    internal interface IIdentified<T>
    {
        /// <summary>
        /// Having a generic typed Id can be useful
        /// </summary>
        T Id { get; set; }
    }
}
