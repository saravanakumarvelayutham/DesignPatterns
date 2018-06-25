namespace DesignPatterns
{
    public class Bridger
    {
        
    }

    public interface IRenderer
    {
        string WhatToRenderAs { get; }
    }

    public abstract class Shape
    {
        private readonly IRenderer _rendering;

        protected Shape(IRenderer rendering)
        {
            this._rendering = rendering;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"Drawing {Name} as {_rendering.WhatToRenderAs}";
        }
    }

    public class Triangle : Shape
    {
        public Triangle(IRenderer strategy) : base(strategy)
        {
            Name = "Triangle";
        }
    }

    public class BridgeSquare : Shape
    {
        public BridgeSquare(IRenderer rendering) : base(rendering)
        {
            Name = "BridgeSquare";
        }
    }

    public class RasterRenderer : IRenderer
    {
        public string WhatToRenderAs => "pixels";
    }

    public class VectorRenderer : IRenderer
    {
        public string WhatToRenderAs => "lines";
    }
}