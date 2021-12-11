using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13
{
    class Building
    {
        static int ID = 1;
        public int id { get; private set; }
        public double height { get; private set; }
        public short floors { get; private set; }
        public short apartaments { get; private set; }
        public short entrances { get; private set; }
        public double floorHeight { get; private set; } 
        public double apartamentsInEntrance { get; private set; }
        public double apartamentsInFloor { get; private set; }
        internal Building()
        {
            id = ID;
            ID++;
            height = 10;
            floors = 5;
            apartaments = 90;
            entrances = 6;
        }
        internal Building(double height, short floors, short apartaments, short entrances)
        {
            id = ID;
            ID++;
            this.height = height;
            this.floors = floors;
            this.apartaments = apartaments;
            this.entrances = entrances;
            floorHeight = (double)height / floors;
            apartamentsInEntrance = (double)apartaments / entrances;
            apartamentsInFloor = (double)apartaments / floors;
        }
        public override string ToString()
        {
            return $"Дом номер {id}\nКоличество этажей: {floors}\nКоличество квартир: {apartaments}\nКоличество подъездов: {entrances}\nСреднее кол-во квартир на этаже: {apartamentsInFloor}\nСреднее кол-во квартир в подъезде: {apartamentsInEntrance}\nВысота этажа: {floorHeight}";
        }
        public int GetID()
        {
            return id;
        }
    }
}
