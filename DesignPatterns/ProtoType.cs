using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatterns
{
    class ProtoType
    {
    }

    public class Point
    {
        public int X, Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Line
    {
        public Point Start, End;

        public Line(Point start,Point end)
        {
            Start = start;
            End = end;
        }
        public Line DeepCopy()
        {
            //var start = new Point(){X = Start.X , Y = Start.Y};

            //var end = new Point(){X = End.X,Y = End.Y};

            //return new Line(){Start = start,End = end};

            using (var mb = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(mb,this);
                mb.Seek(0, SeekOrigin.Begin);
                var copiedObj = formatter.Deserialize(mb);
                mb.Close();
                return (Line) copiedObj;
            }
        }
    }
}
