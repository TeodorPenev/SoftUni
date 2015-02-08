﻿using System;

namespace _01.Point3D
{
    class Point3D
    {
        private static readonly Point3D startingPoint= new Point3D(0,0,0);
        public double X;
        public double Y;
        public double Z;

        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D StartingPoint
        {
            get
            {
                return startingPoint;
            }
        }

        public override string ToString()
        {
            String result= String.Format("Point Coordinates:\nX: {0}\nY: {1}\nZ: {2}\n", 
                this.X, this.Y, this.Z);
            return result;
        }
    }
}
