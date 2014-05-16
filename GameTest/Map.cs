using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameTest
{
    public class Map
    {
        private int[][] tileValues;

        private int[] firstRow =  new int[] { 0, 1, 2, 3 };
        private int[] secondRow = new int[] { 0, 1, 2, 3 };
        private int[] thirdRow =  new int[] { 0, 1, 2, 3 };
        private int[] fourthRow = new int[] { 0, 1, 2, 3 };

        public int[][] TileValues
        {
            get
            {
                if (this.tileValues == null)
                    this.tileValues = new int[][] {
                        firstRow,
                        secondRow,
                        thirdRow, 
                        fourthRow 
                    };

                return this.tileValues;
            }

            set
            {
                this.tileValues = value;
            }
        }
    }
}
