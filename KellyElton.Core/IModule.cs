using System;
using System.Collections.Generic;

namespace KellyElton
{
    public interface IModule : IComponent
    {
        IEnumerable<IComponent> Components { get; }
    }
}
