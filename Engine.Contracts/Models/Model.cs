using System.Collections.Generic;
using World.Model;

namespace Engine.Contracts.Models
{
    public sealed class Model
    {
        public List<ModelRenderUnit> RenderUnits { set; get; }

        public ComplexShape CollisionModel { set; get; }
    }
}
