using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameOfLife
{
    static class Attributes
    {
		//Saving path
		public static string SettingsDirectory { get { return System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Conway's Game Of Life"); } }

        //General Settings
        private static bool[,] _cells;
        public delegate void EmptyEventHandler();
        public static event EmptyEventHandler CellListChanged;
        public static bool[,] Cells {
            get { return _cells; }
            set 
            {
                _cells = value;
                CellListChanged();
            }
        }

        private static int _amount;
        public static int AmountOfCellsPerLine
        {
            get { return _amount; }
            set 
            {
                _amount = value;
                UpdateCellList();
            }
        }

        private static Random rand = new Random();


        //Map information
        public static bool TorusActivated;
        public static int Generation;

        public static int AmountOfLivingCells
        {
            get
            {
                int liv = 0;
                foreach (bool cell in Cells)
                {
                    if (cell) 
                        liv++;
                }
                return liv;
            }
        }

        public static int AmountOfTotalCells
        {
            get { return (int)Math.Pow(AmountOfCellsPerLine, 2); }
        }

        public static double Density
        {
            get { return ((double)AmountOfLivingCells / (double)AmountOfTotalCells); }
        }


        //Animation settings
        public static string RuleToBeBorn;
        public static string RuleToSurvive;

        public static int Refreshrate;
        public static Stack<bool[,]> CurrentCellStack = new Stack<bool[,]>();



        //Change Cell
        public static void SetCellLife(int x, int y, bool alive, bool ShallRaiseEvent = true) {
            Cells[x,y] = alive;
            if (ShallRaiseEvent)
                CellListChanged();
        }

        public static bool IsCellAlive(int x, int y) {
			return Cells[x,y];
        }

        public static void UpdateCellList() {
            if (Cells != null) {
                bool[,] oldcells = Cells;
                Cells = EmptyCells;

				int asdlas = oldcells.GetLength(0);

                for(int x = 0; x <= Math.Min(oldcells.GetLength(0), Cells.GetLength(0)) - 1; x++) {
                   for(int y = 0; y <= Math.Min(oldcells.GetLength(1), Cells.GetLength(1)) - 1; y++) {
                      SetCellLife(x, y, oldcells[x,y], false);
                   }
                }

				if (CellListChanged != null)
					CellListChanged();
            }
        }

        
        public static bool[,] EmptyCells {
            get 
			{
                return new bool[AmountOfCellsPerLine, AmountOfCellsPerLine];
            }
        }

        public static bool[,] RandomCells(double per) {
                bool[,] carray = EmptyCells;

                for(int y = 0; y <= AmountOfCellsPerLine -1; y++) {
                    for(int x = 0; x <= AmountOfCellsPerLine -1; x++) {
                        carray[x,y] = (rand.Next(10001) < (per * 100));
                    }
                }

                return carray;
        }



        //Compare two 2-dim-boolarrays
        private static bool AreEqual(bool[,] arr1, bool[,] arr2) {
            //Check whether they are instanced
            if (arr1 == null || arr2 == null)
                return false;
          
            //Check lengths
            if (arr1.GetLength(0) != arr2.GetLength(0) || arr1.GetLength(1) != arr2.GetLength(1)) 
                return false;

            //Check content
            for(int i = 0; i<=arr1.GetLength(0) - 1; i++) {
                for(int j = 0; j <= arr1.GetLength(1) - 1; j++) {
                    if (arr1[i,j] != arr2[i,j])
                        return false;
                }
            }

            //Is equal
            return true;
        }




        /* *******************************
         *********    ANIMATE    *********
         ****************************** */

        private static System.Timers.Timer t = new System.Timers.Timer();

        public static bool IsActive {get; set;}
        public delegate void NewGenCalculatedEventHandler(bool[,] cells, bool IsNext);
        public static NewGenCalculatedEventHandler NewGenCalculated;

        public static void StartAnimation() {
            if (IsActive)
                throw new InvalidOperationException("Animation is already aborted");

            t = null;
            t = new System.Timers.Timer(Refreshrate);
            t.Start();

            IsActive = true;

			t.Elapsed += new System.Timers.ElapsedEventHandler(t_Elapsed);
        }

        public static void AbortAnimation() {
            if (!IsActive)
                throw new InvalidOperationException("Animation is already aborted");

            if (t.Enabled)
            {
                t.Stop();
                t = null;
            }

            IsActive = false;
        }


        public static void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e) 
        {
            CalculateNextGen();
        }

        public static void CalculateNextGen()
        {

            if (CurrentCellStack.Count == 0)
                CurrentCellStack.Push(Cells);

            //Get the new celllist
            bool[,] tempcells = EmptyCells;

            //Calculate the next generation
            for (int y = 0; y <= tempcells.GetLength(1) - 1; y++)
            {
                for (int x = 0; x <= tempcells.GetLength(0) - 1; x++)
                {

                    int neighbors = CountNeighbors(x, y);
                    bool newcell = false;

                    if (IsCellAlive(x, y))
                    {
                        newcell = RuleToSurvive.Contains(neighbors.ToString());
                    }
                    else
                    {
                        newcell = RuleToBeBorn.Contains(neighbors.ToString());
                    }

                    tempcells[x, y] = newcell;
                }
            }

            //Raise the event to make this handlable
            NewGenCalculated(tempcells, true);

        }

        public static void CalculatePreviousGen()
        {
            if (CurrentCellStack.Count > 1)
            {
                //Get the last celllist
                CurrentCellStack.Pop(); //Delete the current cells
                bool[,] tempcells = CurrentCellStack.Pop();

                //Raise the event to make this handlable
                NewGenCalculated(tempcells, false);
            }
        }


        private static int CountNeighbors(int x, int y)
        {
            int lastindex = AmountOfCellsPerLine - 1;
            bool leftbound = (x == 0);
            bool rightbound = (x == lastindex);
            bool topbound = (y == 0);
            bool bottombound = (y == lastindex);
            int count = 0;

            //Left
            if (!leftbound)
            {
                count += Convert.ToInt32(IsCellAlive(x - 1, y));
            }
            else
            {
                if (TorusActivated)
                    count += Convert.ToInt32(IsCellAlive(lastindex, y));
            }

            //Right
            if (!rightbound)
            {
                count += Convert.ToInt32(IsCellAlive(x + 1, y));
            }
            else
            {
                if (TorusActivated)
                    count += Convert.ToInt32(IsCellAlive(0, y));
            }

            //Top
            if (!topbound)
            {
                count += Convert.ToInt32(IsCellAlive(x, y - 1));
            }
            else
            {
                if (TorusActivated)
                    count += Convert.ToInt32(IsCellAlive(x, lastindex));
            }

            //Bottom
            if (!bottombound)
            {
                count += Convert.ToInt32(IsCellAlive(x, y + 1));
            }
            else
            {
                if (TorusActivated)
                    count += Convert.ToInt32(IsCellAlive(x, 0));
            }

            //Topleft
            if (!leftbound && !topbound)
            {
                count += Convert.ToInt32(IsCellAlive(x - 1, y - 1));
            }
            else if (!leftbound)
            {
                if (TorusActivated)
                    count += Convert.ToInt32(IsCellAlive(x - 1, lastindex));
            }
            else if (!topbound)
            {
                if (TorusActivated)
                    count += Convert.ToInt32(IsCellAlive(lastindex, y - 1));
            }
            else
            {
                if (TorusActivated)
                    count += Convert.ToInt32(IsCellAlive(lastindex, lastindex));
            }


            //Bottomleft
            if (!leftbound && !bottombound)
            {
                count += Convert.ToInt32(IsCellAlive(x - 1, y + 1));
            }
            else if (!leftbound)
            {
                if (TorusActivated)
                    count += Convert.ToInt32(IsCellAlive(x - 1, 0));
            }
            else if (!bottombound)
            {
                if (TorusActivated)
                    count += Convert.ToInt32(IsCellAlive(lastindex, y + 1));
            }
            else
            {
                if (TorusActivated)
                    count += Convert.ToInt32(IsCellAlive(lastindex, 0));
            }


            //Topright
            if (!rightbound && !topbound)
            {
                count += Convert.ToInt32(IsCellAlive(x + 1, y - 1));
            }
            else if (!rightbound)
            {
                if (TorusActivated)
                    count += Convert.ToInt32(IsCellAlive(x + 1, lastindex));
            }
            else if (!topbound)
            {
                if (TorusActivated)
                    count += Convert.ToInt32(IsCellAlive(0, y - 1));
            }
            else
            {
                if (TorusActivated)
                    count += Convert.ToInt32(IsCellAlive(0, lastindex));
            }


            //Bottomright
            if (!rightbound && !bottombound)
            {
                count += Convert.ToInt32(IsCellAlive(x + 1, y + 1));
            }
            else if (!rightbound)
            {
                if (TorusActivated)
                    count += Convert.ToInt32(IsCellAlive(x + 1, 0));
            }
            else if (!bottombound)
            {
                if (TorusActivated)
                    count += Convert.ToInt32(IsCellAlive(0, y + 1));
            }
            else
            {
                if (TorusActivated)
                    count += Convert.ToInt32(IsCellAlive(0, 0));
            }

            return count;

        }

    }
}
