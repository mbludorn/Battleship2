using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Grid
    {
        public enum PlaceShipDirection
        {
            Horizontal,
            Vertical
        }
        //define properties
        public Point[,] Ocean {get; set;}
        public List<Ship> ListOfShips {get; set;}
        public bool AllShipsDestroyed {get {return this.}
        public int CombatRound {get; set;}

    //define constructor
    public Grid()
    {
        //itialize the ocean   
        this.Ocean = new Point [10, 10];
        //this.Ocean[x, y] = new Point(x, y, Point.Pointstatus.Empty); 
        this.ListOfShips =  new List<Ship>();
        //this.ListOfShips.Add(

    }

     public void PlaceShip(Ship shipToPlace, PlaceShipDirection direction, int startX, int startY)
     {
         for (int i = 0; i < shipToPlace.Length; i++)
         {	
           Point thePoint = Ocean[startX, startY]; 
              // Point.Pointstatus = Ship.ShipType;
             thePoint.Status = Point.Pointstatus.Ship;

             shipToPlace.OccupiedPoints.Add(thePoint);

             if(direction == PlaceShipDirection.Horizontal)
               {
                   startX ++;
               }
               else
               {
                   startY ++;
               }

			 
			}
     }

    public void DisplayOcean()
    {

    }

    public void Target(int x, int y)
    {

    }

    }
}

