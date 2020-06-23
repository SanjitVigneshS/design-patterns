using System;
using System.Collections.Generic;
using System.Text;

namespace creational_patterns
{
    public abstract class Tool
    {
        public int Length { get; set; }
        public char Shape { get; set; }
        public abstract void Draw();
    }

    public class Brush : Tool
    {
        public override void Draw()
        {
            Console.Write("-");
            for(int index = 2; index <= Length - 1; index++)
            {
                Console.Write(Shape);
            }
            Console.WriteLine("-");
        }
    }

    public class Pencil : Tool
    {
        public override void Draw()
        {
            for (int index = 1; index <= Length; index++)
            {
                Console.Write(Shape);
            }
            Console.WriteLine();
        }
    }

    public abstract class ToolFactory
    {
        public abstract Tool GetTool();
    }

    public class BrushFactory : ToolFactory
    {
        public override Tool GetTool()
        {
            Tool brush = new Brush();
            brush.Length = 12;
            brush.Shape = '=';
            return brush;
        }
    }

    public class PencilFactory : ToolFactory
    {
        public override Tool GetTool()
        {
            Tool pencil = new Pencil();
            pencil.Length = 12;
            pencil.Shape = '=';
            return pencil;
        }
    }
}
