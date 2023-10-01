using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Ellefson
{
    public class Desk
    {
        // Constants
        public const int WIDTH_MIN = 24;
        public const int WIDTH_MAX = 96;
        public const int DEPTH_MIN = 12;
        public const int DEPTH_MAX = 48;

        int width;
        int depth;
        int drawersNum;
        DesktopMaterial deskMaterial;


        // Constructor
        public Desk(int width, int depth, int drawersNum, DesktopMaterial material) 
        {
            this.width = width;
            this.depth = depth;
            this.drawersNum = drawersNum;
            deskMaterial = material;
        }

        // Getters/Setters
        public int getWidth()
        {
            return width;
        }

        public int getDepth()
        {
            return depth;
        }

        public int getDrawersNum()
        {
            return drawersNum;
        }

        public DesktopMaterial getMaterial()
        {
            return deskMaterial;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }

        public void setDepth(int depth)
        {
            this.depth = depth;
        }

        public void setDrawersNum(int drawersNum)
        {
            this.drawersNum = drawersNum;
        }
        public void setMaterial(DesktopMaterial material)
        {
            deskMaterial = material;
        }

    }


    public enum DesktopMaterial
    {
        Oak,
        Pine,
        Veneer,
        Laminate,
        Rosewood
    }
}
